using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NFX;
using NFX.DataAccess.Distributed;

namespace SocialTrading
{
  public class ThreadSet : DisposableObject
  {

    public ThreadSet(IUserStore store)
    {
      m_Store = store;
      m_Log = new ConcurrentQueue<string>();
      m_List = new List<Thread>();
    }

    private IUserStore m_Store;

    private int m_Reads;
    private int m_Writes;
    private int m_Deletes;

    private ConcurrentQueue<string> m_Log;
    private List<Thread> m_List;


    private long m_stat_ReadHit;
    private long m_stat_ReadMiss;
    private long m_stat_Write;
    private long m_stat_DeleteHit;
    private long m_stat_DeleteMiss;


    public int Count { get { return m_List.Count; } }

    public string TryGetLog()
    {
      string result;
      if (!m_Log.TryDequeue(out result)) return null;
      return result;
    }

    public void Log(string message)
    {
      if (m_Log.Count > 1000) return;
      m_Log.Enqueue(message);
    }


    public void Stats(out long rHit,
                      out long rMiss,
                      out long dHit,
                      out long dMiss,
                      out long write
                      )
    {
      rHit  = Interlocked.Exchange(ref m_stat_ReadHit, 0);
      rMiss = Interlocked.Exchange(ref m_stat_ReadMiss, 0);
      dHit  = Interlocked.Exchange(ref m_stat_DeleteHit, 0);
      dMiss = Interlocked.Exchange(ref m_stat_DeleteMiss, 0);
      write = Interlocked.Exchange(ref m_stat_Write, 0);
    }


    public void Set(int threads, int reads, int writes, int deletes)
    {
      m_Reads = reads;
      m_Writes = writes;
      m_Deletes = deletes;

      lock(m_List)
      {
        while (m_List.Count > threads) m_List.RemoveAt(0);
        while (m_List.Count < threads)
        {
          var t = new Thread(threadSpin);
          t.IsBackground = true;
          m_List.Add(t);
          t.Start(m_List.Count);
        }
      }
    }



    private void threadSpin(object thread)
    {
      Log("{0} {1} Thread Started".Args(m_Store.GetType().Name, App.TimeSource.Now));
      var num = (int)thread;
      var missing = new List<GDID>();
      while(!DisposeStarted)
      {
        lock(m_List)
        {
          if (m_List.Count < num) break;
        }

        try
        {
          var idseed = m_Store.IDSeed;
          for (var i = 0; i < m_Reads; i++)
          {
            var gExisting = new GDID(0, (ulong)(idseed * ExternalRandomGenerator.Instance.NextScaledRandomDouble(0, 1.0d)));

            var existing = m_Store.Get(gExisting);
            if (existing == null)
            {
              missing.Add(gExisting);
              Interlocked.Increment(ref m_stat_ReadMiss);
            }
            else
            {
              Interlocked.Increment(ref m_stat_ReadHit);
            }
          }

          for (var i = 0; i < m_Deletes; i++)
          {
            var gExisting = new GDID(0, (ulong)(idseed * ExternalRandomGenerator.Instance.NextScaledRandomDouble(0, 1.0d)));

            var deleted = m_Store.Remove(gExisting);
            if (deleted)
            {
              missing.Add(gExisting);
              Interlocked.Increment(ref m_stat_DeleteHit);
            }
            else
            {
              Interlocked.Increment(ref m_stat_DeleteHit);
            }
          }


          for (var i = 0; i < m_Writes; i++)
          {
            User user;
            if (missing.Count > 0)
            {
              user = makeUser(missing[missing.Count - 1]);
              missing.RemoveAt(missing.Count - 1);
            }
            else
            {
              var id = m_Store.MakeID();
              user = makeUser(id);
            }

            m_Store.Put(user);
            Interlocked.Increment(ref m_stat_Write);
          }

          //randomize
          Thread.SpinWait(ExternalRandomGenerator.Instance.NextScaledRandomInteger(10, 1000));
        }
        catch(Exception error)
        {
          Log("{0} {1} Thread Exception: {2}".Args(m_Store.GetType().Name, App.TimeSource.Now, error.ToMessageWithType()));
        }
      }
      Log("{0} {1} Thread Finished".Args(m_Store.GetType().Name, App.TimeSource.Now));
    }

    private User makeUser(GDID id)
    {
      var chance = ExternalRandomGenerator.Instance.NextScaledRandomInteger(0, 100);
      NFX.Collections.StringMap sm = null;
      if (chance > 50)
      {
        sm = new NFX.Collections.StringMap();
        for (var i = 0; i < chance % 3; i++)
          sm.Add("Key-" + i, "iuydsaaduyfnsdfnuwgfgf" + i);
      }

      return new User(id)
      {
         Name = "Abcds"+id,
         DOB = new DateTime(1980, 1, 1),
         SocialMsg = sm,
         BuyerScore = 34,
         SellerScore = 473,
         GVendor = id.Counter%3==0 ? null : (GDID?)id,
         IsVendor = true,
         ReturnApproved = false
      };
    }


  }
}
