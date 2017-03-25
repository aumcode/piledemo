using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NFX;
using NFX.ApplicationModel.Pile;

namespace SocialTrading
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }


    private const int TIMER_NORM_MS = 250;


    private IUserStore m_CLRStore;
    private IUserStore m_PileStore;

    private ThreadSet m_CLRThreads;
    private ThreadSet m_PileThreads;

    private DefaultPile m_Pile;
    private DateTime m_PriorTimer = App.TimeSource.UTCNow;
    private List<int> m_Jitters = new List<int>(128);

    private void MainForm_Load(object sender, EventArgs e)
    {
      m_Pile = new DefaultPile();
      m_Pile.Configure(null);
     // m_Pile.SegmentSize = 512 * 1024 * 1024;
      m_Pile.Start();
      m_CLRStore  = new CLRSocialTradingStore();
      m_PileStore = new PileSocialTradingStore(m_Pile);
      //m_PileStore = new PileCacheSocialTradingStore(m_Pile);
      m_CLRThreads = new ThreadSet(m_CLRStore);
      m_PileThreads = new ThreadSet(m_PileStore);




      tbSegSizeMb.Text = "{0:n0}".Args(m_Pile.SegmentSize / (1024 * 1024));
      tbMaxMemMb.Text = "{0:n0}".Args(m_Pile.MaxMemoryLimit / (1024 * 1024));

      tmrUI.Interval = TIMER_NORM_MS;
      tmrUI.Enabled = true;
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      m_Pile.WaitForCompleteStop();
      DisposableObject.DisposeAndNull(ref m_CLRStore);
      DisposableObject.DisposeAndNull(ref m_PileStore);
      DisposableObject.DisposeAndNull(ref m_CLRThreads);
      DisposableObject.DisposeAndNull(ref m_PileThreads);
    }

    private void tmrUI_Tick(object sender, EventArgs e)
    {
      if (tmrUI.Interval != TIMER_NORM_MS) tmrUI.Interval = TIMER_NORM_MS;
      var now = App.TimeSource.UTCNow;

      var msSincePrior = (int)(now - m_PriorTimer).TotalMilliseconds;

      if (msSincePrior < TIMER_NORM_MS / 2) return;

      var msJitter = msSincePrior - TIMER_NORM_MS;
      if (msJitter < 0) msJitter = 0;
      m_PriorTimer = now;
      //-------------------------------------

      m_Jitters.Add(msJitter);
      var jc = pnlJitter.Width / 3;
      if (jc < 100) jc = 100;
      while (m_Jitters.Count == jc) m_Jitters.RemoveAt(0);
      var max = m_Jitters.Count >0 ? m_Jitters.Max() : 0;
      var maxRecent = m_Jitters.Count > 0 ? m_Jitters.Reverse<int>().Take(25).Max() : 0;
      lblJitter.Text = "Jitter: {0,12:n3} sec.   All Max: {1,10:n3} sec.   Recent Max: {2,10:n3} sec.".Args(msJitter / 1000f, max / 1000f, maxRecent / 1000f);
      pnlJitter.Refresh();

      //-------------------------------------

      var count = m_Pile.ObjectCount;
      var utilized = m_Pile.UtilizedBytes;
      var overhead = m_Pile.OverheadBytes;

      stbMemBytes.Text = m_Pile.AllocatedMemoryBytes.ToString("n0");
      stbObjectCount.Text = count.ToString("n0");
      stbOverheadBytes.Text = overhead.ToString("n0");
      stbOverheadBytesObject.Text = count > 0 ? (overhead / count).ToString("n0") : "<n/a>";
      stbUtilizedBytes.Text = utilized.ToString("n0");
      stbUtilizedBytesObject.Text = count > 0 ? (utilized / count).ToString("n0") : "<n/a>";
      stbSegments.Text = m_Pile.SegmentCount.ToString("n0");
      stbTotalSegments.Text = m_Pile.SegmentTotalCount.ToString("n0");
      lblRamAvailable.Text = "Available RAM: {0,12:n0} bytes".Args(m_Pile.MemoryCapacityBytes);


      //-----
      stbCLRObjectCount.Text = "{0:n}".Args(m_CLRStore.Count);
      //----

      m_CLRThreads.Set(tbCLRThreads.Text.AsInt(0),
                       sbCLRReads.Value,
                       sbCLRWrites.Value,
                       sbCLRDeletes.Value);

      m_PileThreads.Set(tbPileThreads.Text.AsInt(0),
                             sbPileReads.Value,
                             sbPileWrites.Value,
                             sbPileDeletes.Value);
      //--------------------

      while(true)
      {
        var msg = m_CLRThreads.TryGetLog();
        if (msg == null) break;
        lbLog.Items.Insert(0, msg);
        if (lbLog.Items.Count > 100) lbLog.Items.RemoveAt(lbLog.Items.Count - 1);
      }

      while (true)
      {
        var msg = m_PileThreads.TryGetLog();
        if (msg == null) break;
        lbLog.Items.Insert(0, msg);
        if (lbLog.Items.Count > 100) lbLog.Items.RemoveAt(lbLog.Items.Count - 1);
      }

      //-----------------------------------------------------------------------------------------------------------
      long rHit, rMiss, dHit, dMiss, writes;
      m_CLRThreads.Stats(out rHit, out rMiss, out dHit, out dMiss, out writes);

      rHit   = (long)(rHit   / (msSincePrior / 1000d));
      rMiss  = (long)(rMiss  / (msSincePrior / 1000d));
      dHit   = (long)(dHit   / (msSincePrior / 1000d));
      dMiss  = (long)(dMiss  / (msSincePrior / 1000d));
      writes = (long)(writes / (msSincePrior / 1000d));


      var txt = "rH: {0:n0} rM: {1:n0}|R: {2:n0}   dH: {3:n0} dM: {4:n0}|D: {5:n0}  |W: {6:n0}  || T: {7:n0}  : {8:n3} ms"
                .Args(rHit, rMiss, rHit+rMiss,  dHit, dMiss, dHit+dMiss,   writes,   rHit+rMiss+dHit+dMiss+writes, msSincePrior);
      lbCLRLog.Items.Insert(0, txt);
      while (lbCLRLog.Items.Count > 100) lbCLRLog.Items.RemoveAt(lbCLRLog.Items.Count-1);

      //----
      m_PileThreads.Stats(out rHit, out rMiss, out dHit, out dMiss, out writes);

      rHit   = (long)(rHit   / (msSincePrior / 1000d));
      rMiss  = (long)(rMiss  / (msSincePrior / 1000d));
      dHit   = (long)(dHit   / (msSincePrior / 1000d));
      dMiss  = (long)(dMiss  / (msSincePrior / 1000d));
      writes = (long)(writes / (msSincePrior / 1000d));

      txt = "rH: {0:n0} rM: {1:n0}|R: {2:n0}   dH: {3:n0} dM: {4:n0}|D: {5:n0}  |W: {6:n0}  || T: {7:n0}  : {8:n3} ms"
            .Args(rHit, rMiss, rHit + rMiss, dHit, dMiss, dHit + dMiss, writes, rHit + rMiss + dHit + dMiss + writes, msSincePrior);
      lbPileLog.Items.Insert(0, txt);
      while (lbPileLog.Items.Count > 100) lbPileLog.Items.RemoveAt(lbPileLog.Items.Count - 1);

    }

    private void pnlJitter_Paint(object sender, PaintEventArgs e)
    {
      if (m_Jitters.Count == 0) return;
      var x = pnlJitter.Width;
      var i = m_Jitters.Count - 1;
      var max = m_Jitters.Max();
      if (max == 0) return;
      while (i >= 0 && x >= 0)
      {
        var jit = m_Jitters[i];
        var y = (int)(jit * (pnlJitter.Height / (float)max));

        var pen = jit > 1500 ? Pens.Red :
                  jit > 1000 ? Pens.Coral :
                  jit > 700 ? Pens.Gold :
                  jit > 250 ? Pens.YellowGreen : Pens.LawnGreen;

        e.Graphics.DrawRectangle(pen, x, pnlJitter.Height-y, 1, y);
        x-=3;
        i--;
      }
    }

    private void chkSpeed_CheckedChanged(object sender, EventArgs e)
    {
      m_Pile.AllocMode = chkSpeed.Checked ? AllocationMode.FavorSpeed : AllocationMode.ReuseSpace;
    }

    private void btnPurge_Click(object sender, EventArgs e)
    {
      m_PileStore.Purge();
    }

    private void btnCrawl_Click(object sender, EventArgs e)
    {
      var w = Stopwatch.StartNew();
      var status = m_Pile.Crawl(true);
      Text = "Crawl {0} in {1:n0} ms".Args(status, w.ElapsedMilliseconds);
    }

    private void btnGC_Click(object sender, EventArgs e)
    {
      var was = GC.GetTotalMemory(false);
      var w = Stopwatch.StartNew();
      GC.Collect();
      Text = "GC Freed {0:n0} bytes in {1:n0} ms".Args(was - GC.GetTotalMemory(false), w.ElapsedMilliseconds);
    }


    private void btnCLRPurge_Click(object sender, EventArgs e)
    {
      m_CLRStore.Purge();
    }

  }
}
