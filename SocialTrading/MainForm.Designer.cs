namespace SocialTrading
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.tmrUI = new System.Windows.Forms.Timer(this.components);
      this.pnlTop = new System.Windows.Forms.Panel();
      this.lbLog = new System.Windows.Forms.ListBox();
      this.btnGC = new System.Windows.Forms.Button();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.lblJitter = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblRamAvailable = new System.Windows.Forms.ToolStripStatusLabel();
      this.pnlCLR = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lbCLRLog = new System.Windows.Forms.ListBox();
      this.stbCLRObjectCount = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.btnCLRPurge = new System.Windows.Forms.Button();
      this.lblCLRDeletes = new System.Windows.Forms.Label();
      this.sbCLRDeletes = new System.Windows.Forms.HScrollBar();
      this.lblCLRWrites = new System.Windows.Forms.Label();
      this.lblCLRReads = new System.Windows.Forms.Label();
      this.sbCLRWrites = new System.Windows.Forms.HScrollBar();
      this.sbCLRReads = new System.Windows.Forms.HScrollBar();
      this.label3 = new System.Windows.Forms.Label();
      this.tbCLRThreads = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pnlPile = new System.Windows.Forms.Panel();
      this.chkSpeed = new System.Windows.Forms.CheckBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.stbTotalSegments = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
      this.lbPileLog = new System.Windows.Forms.ListBox();
      this.stbSegments = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.stbOverheadBytesObject = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.stbOverheadBytes = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.stbUtilizedBytesObject = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.stbUtilizedBytes = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.stbMemBytes = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.stbObjectCount = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.btnCrawl = new System.Windows.Forms.Button();
      this.btnPurge = new System.Windows.Forms.Button();
      this.lblPileDeletes = new System.Windows.Forms.Label();
      this.sbPileDeletes = new System.Windows.Forms.HScrollBar();
      this.lblPileWrites = new System.Windows.Forms.Label();
      this.lblPileReads = new System.Windows.Forms.Label();
      this.sbPileWrites = new System.Windows.Forms.HScrollBar();
      this.sbPileReads = new System.Windows.Forms.HScrollBar();
      this.label6 = new System.Windows.Forms.Label();
      this.tbMaxMemMb = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tbSegSizeMb = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbPileThreads = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.pnlJitter = new System.Windows.Forms.Panel();
      this.pnlMain = new System.Windows.Forms.Panel();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.pnlTop.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.pnlCLR.SuspendLayout();
      this.panel1.SuspendLayout();
      this.pnlPile.SuspendLayout();
      this.panel2.SuspendLayout();
      this.pnlMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // tmrUI
      // 
      this.tmrUI.Interval = 150;
      this.tmrUI.Tick += new System.EventHandler(this.tmrUI_Tick);
      // 
      // pnlTop
      // 
      this.pnlTop.Controls.Add(this.lbLog);
      this.pnlTop.Controls.Add(this.btnGC);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(1012, 113);
      this.pnlTop.TabIndex = 0;
      // 
      // lbLog
      // 
      this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbLog.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbLog.FormattingEnabled = true;
      this.lbLog.ItemHeight = 16;
      this.lbLog.Location = new System.Drawing.Point(84, 6);
      this.lbLog.Name = "lbLog";
      this.lbLog.Size = new System.Drawing.Size(916, 100);
      this.lbLog.TabIndex = 1;
      // 
      // btnGC
      // 
      this.btnGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.btnGC.Location = new System.Drawing.Point(4, 2);
      this.btnGC.Name = "btnGC";
      this.btnGC.Size = new System.Drawing.Size(75, 23);
      this.btnGC.TabIndex = 0;
      this.btnGC.Text = "GC";
      this.btnGC.UseVisualStyleBackColor = true;
      this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblJitter,
            this.lblRamAvailable});
      this.statusStrip.Location = new System.Drawing.Point(0, 740);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(1012, 22);
      this.statusStrip.TabIndex = 1;
      this.statusStrip.Text = "statusStrip1";
      // 
      // lblJitter
      // 
      this.lblJitter.Name = "lblJitter";
      this.lblJitter.Size = new System.Drawing.Size(109, 17);
      this.lblJitter.Text = "Jitter:           0.00 sec";
      // 
      // lblRamAvailable
      // 
      this.lblRamAvailable.Name = "lblRamAvailable";
      this.lblRamAvailable.Size = new System.Drawing.Size(85, 17);
      this.lblRamAvailable.Text = "Available Ram:";
      // 
      // pnlCLR
      // 
      this.pnlCLR.BackColor = System.Drawing.Color.Gray;
      this.pnlCLR.Controls.Add(this.panel1);
      this.pnlCLR.Controls.Add(this.btnCLRPurge);
      this.pnlCLR.Controls.Add(this.lblCLRDeletes);
      this.pnlCLR.Controls.Add(this.sbCLRDeletes);
      this.pnlCLR.Controls.Add(this.lblCLRWrites);
      this.pnlCLR.Controls.Add(this.lblCLRReads);
      this.pnlCLR.Controls.Add(this.sbCLRWrites);
      this.pnlCLR.Controls.Add(this.sbCLRReads);
      this.pnlCLR.Controls.Add(this.label3);
      this.pnlCLR.Controls.Add(this.tbCLRThreads);
      this.pnlCLR.Controls.Add(this.label1);
      this.pnlCLR.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlCLR.Location = new System.Drawing.Point(517, 0);
      this.pnlCLR.Name = "pnlCLR";
      this.pnlCLR.Padding = new System.Windows.Forms.Padding(2);
      this.pnlCLR.Size = new System.Drawing.Size(495, 593);
      this.pnlCLR.TabIndex = 2;
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.Color.DarkGray;
      this.panel1.Controls.Add(this.lbCLRLog);
      this.panel1.Controls.Add(this.stbCLRObjectCount);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Location = new System.Drawing.Point(15, 315);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(463, 254);
      this.panel1.TabIndex = 11;
      // 
      // lbCLRLog
      // 
      this.lbCLRLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbCLRLog.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbCLRLog.FormattingEnabled = true;
      this.lbCLRLog.ItemHeight = 16;
      this.lbCLRLog.Location = new System.Drawing.Point(10, 48);
      this.lbCLRLog.Name = "lbCLRLog";
      this.lbCLRLog.Size = new System.Drawing.Size(362, 196);
      this.lbCLRLog.TabIndex = 15;
      // 
      // stbCLRObjectCount
      // 
      this.stbCLRObjectCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbCLRObjectCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbCLRObjectCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.stbCLRObjectCount.Location = new System.Drawing.Point(82, 21);
      this.stbCLRObjectCount.Name = "stbCLRObjectCount";
      this.stbCLRObjectCount.ReadOnly = true;
      this.stbCLRObjectCount.Size = new System.Drawing.Size(100, 20);
      this.stbCLRObjectCount.TabIndex = 1;
      this.stbCLRObjectCount.Text = "0";
      this.stbCLRObjectCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(7, 24);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(69, 13);
      this.label7.TabIndex = 0;
      this.label7.Text = "Object Count";
      // 
      // btnCLRPurge
      // 
      this.btnCLRPurge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCLRPurge.BackColor = System.Drawing.Color.Red;
      this.btnCLRPurge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCLRPurge.ForeColor = System.Drawing.Color.Yellow;
      this.btnCLRPurge.Location = new System.Drawing.Point(403, 20);
      this.btnCLRPurge.Name = "btnCLRPurge";
      this.btnCLRPurge.Size = new System.Drawing.Size(75, 37);
      this.btnCLRPurge.TabIndex = 10;
      this.btnCLRPurge.Text = "Purge";
      this.btnCLRPurge.UseVisualStyleBackColor = false;
      this.btnCLRPurge.Click += new System.EventHandler(this.btnCLRPurge_Click);
      // 
      // lblCLRDeletes
      // 
      this.lblCLRDeletes.AutoSize = true;
      this.lblCLRDeletes.ForeColor = System.Drawing.Color.Silver;
      this.lblCLRDeletes.Location = new System.Drawing.Point(14, 199);
      this.lblCLRDeletes.Name = "lblCLRDeletes";
      this.lblCLRDeletes.Size = new System.Drawing.Size(43, 13);
      this.lblCLRDeletes.TabIndex = 9;
      this.lblCLRDeletes.Text = "Deletes";
      // 
      // sbCLRDeletes
      // 
      this.sbCLRDeletes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sbCLRDeletes.Location = new System.Drawing.Point(15, 225);
      this.sbCLRDeletes.Name = "sbCLRDeletes";
      this.sbCLRDeletes.Size = new System.Drawing.Size(463, 27);
      this.sbCLRDeletes.TabIndex = 8;
      // 
      // lblCLRWrites
      // 
      this.lblCLRWrites.AutoSize = true;
      this.lblCLRWrites.ForeColor = System.Drawing.Color.Silver;
      this.lblCLRWrites.Location = new System.Drawing.Point(12, 132);
      this.lblCLRWrites.Name = "lblCLRWrites";
      this.lblCLRWrites.Size = new System.Drawing.Size(37, 13);
      this.lblCLRWrites.TabIndex = 7;
      this.lblCLRWrites.Text = "Writes";
      // 
      // lblCLRReads
      // 
      this.lblCLRReads.AutoSize = true;
      this.lblCLRReads.ForeColor = System.Drawing.Color.Silver;
      this.lblCLRReads.Location = new System.Drawing.Point(12, 66);
      this.lblCLRReads.Name = "lblCLRReads";
      this.lblCLRReads.Size = new System.Drawing.Size(41, 13);
      this.lblCLRReads.TabIndex = 6;
      this.lblCLRReads.Text = "Reads:";
      // 
      // sbCLRWrites
      // 
      this.sbCLRWrites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sbCLRWrites.Location = new System.Drawing.Point(15, 158);
      this.sbCLRWrites.Name = "sbCLRWrites";
      this.sbCLRWrites.Size = new System.Drawing.Size(463, 27);
      this.sbCLRWrites.TabIndex = 5;
      // 
      // sbCLRReads
      // 
      this.sbCLRReads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sbCLRReads.Location = new System.Drawing.Point(15, 89);
      this.sbCLRReads.Name = "sbCLRReads";
      this.sbCLRReads.Size = new System.Drawing.Size(463, 27);
      this.sbCLRReads.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.Silver;
      this.label3.Location = new System.Drawing.Point(12, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Threads";
      // 
      // tbCLRThreads
      // 
      this.tbCLRThreads.Location = new System.Drawing.Point(64, 29);
      this.tbCLRThreads.Name = "tbCLRThreads";
      this.tbCLRThreads.Size = new System.Drawing.Size(49, 20);
      this.tbCLRThreads.TabIndex = 1;
      this.tbCLRThreads.Text = "0";
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.DimGray;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(2, 2);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(491, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "CLR";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // pnlPile
      // 
      this.pnlPile.BackColor = System.Drawing.Color.Gray;
      this.pnlPile.Controls.Add(this.chkSpeed);
      this.pnlPile.Controls.Add(this.panel2);
      this.pnlPile.Controls.Add(this.btnCrawl);
      this.pnlPile.Controls.Add(this.btnPurge);
      this.pnlPile.Controls.Add(this.lblPileDeletes);
      this.pnlPile.Controls.Add(this.sbPileDeletes);
      this.pnlPile.Controls.Add(this.lblPileWrites);
      this.pnlPile.Controls.Add(this.lblPileReads);
      this.pnlPile.Controls.Add(this.sbPileWrites);
      this.pnlPile.Controls.Add(this.sbPileReads);
      this.pnlPile.Controls.Add(this.label6);
      this.pnlPile.Controls.Add(this.tbMaxMemMb);
      this.pnlPile.Controls.Add(this.label5);
      this.pnlPile.Controls.Add(this.tbSegSizeMb);
      this.pnlPile.Controls.Add(this.label4);
      this.pnlPile.Controls.Add(this.tbPileThreads);
      this.pnlPile.Controls.Add(this.label2);
      this.pnlPile.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlPile.Location = new System.Drawing.Point(0, 0);
      this.pnlPile.Name = "pnlPile";
      this.pnlPile.Padding = new System.Windows.Forms.Padding(2);
      this.pnlPile.Size = new System.Drawing.Size(517, 593);
      this.pnlPile.TabIndex = 4;
      // 
      // chkSpeed
      // 
      this.chkSpeed.AutoSize = true;
      this.chkSpeed.Checked = true;
      this.chkSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkSpeed.ForeColor = System.Drawing.Color.Silver;
      this.chkSpeed.Location = new System.Drawing.Point(191, 276);
      this.chkSpeed.Name = "chkSpeed";
      this.chkSpeed.Size = new System.Drawing.Size(63, 17);
      this.chkSpeed.TabIndex = 19;
      this.chkSpeed.Text = "Speed+";
      this.chkSpeed.UseVisualStyleBackColor = true;
      this.chkSpeed.CheckedChanged += new System.EventHandler(this.chkSpeed_CheckedChanged);
      // 
      // panel2
      // 
      this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel2.BackColor = System.Drawing.Color.DarkGray;
      this.panel2.Controls.Add(this.stbTotalSegments);
      this.panel2.Controls.Add(this.label15);
      this.panel2.Controls.Add(this.lbPileLog);
      this.panel2.Controls.Add(this.stbSegments);
      this.panel2.Controls.Add(this.label14);
      this.panel2.Controls.Add(this.stbOverheadBytesObject);
      this.panel2.Controls.Add(this.label13);
      this.panel2.Controls.Add(this.stbOverheadBytes);
      this.panel2.Controls.Add(this.label12);
      this.panel2.Controls.Add(this.stbUtilizedBytesObject);
      this.panel2.Controls.Add(this.label11);
      this.panel2.Controls.Add(this.stbUtilizedBytes);
      this.panel2.Controls.Add(this.label10);
      this.panel2.Controls.Add(this.stbMemBytes);
      this.panel2.Controls.Add(this.label9);
      this.panel2.Controls.Add(this.stbObjectCount);
      this.panel2.Controls.Add(this.label8);
      this.panel2.Location = new System.Drawing.Point(20, 315);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(465, 254);
      this.panel2.TabIndex = 18;
      // 
      // stbTotalSegments
      // 
      this.stbTotalSegments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbTotalSegments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbTotalSegments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.stbTotalSegments.Location = new System.Drawing.Point(89, 203);
      this.stbTotalSegments.Name = "stbTotalSegments";
      this.stbTotalSegments.ReadOnly = true;
      this.stbTotalSegments.Size = new System.Drawing.Size(100, 20);
      this.stbTotalSegments.TabIndex = 16;
      this.stbTotalSegments.Text = "0";
      this.stbTotalSegments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(14, 206);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(58, 13);
      this.label15.TabIndex = 15;
      this.label15.Text = "Total Segs";
      // 
      // lbPileLog
      // 
      this.lbPileLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbPileLog.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbPileLog.FormattingEnabled = true;
      this.lbPileLog.ItemHeight = 16;
      this.lbPileLog.Location = new System.Drawing.Point(199, 19);
      this.lbPileLog.Name = "lbPileLog";
      this.lbPileLog.Size = new System.Drawing.Size(255, 228);
      this.lbPileLog.TabIndex = 14;
      // 
      // stbSegments
      // 
      this.stbSegments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbSegments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbSegments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.stbSegments.Location = new System.Drawing.Point(89, 177);
      this.stbSegments.Name = "stbSegments";
      this.stbSegments.ReadOnly = true;
      this.stbSegments.Size = new System.Drawing.Size(100, 20);
      this.stbSegments.TabIndex = 13;
      this.stbSegments.Text = "0";
      this.stbSegments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(14, 180);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(54, 13);
      this.label14.TabIndex = 12;
      this.label14.Text = "Segments";
      // 
      // stbOverheadBytesObject
      // 
      this.stbOverheadBytesObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbOverheadBytesObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbOverheadBytesObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.stbOverheadBytesObject.Location = new System.Drawing.Point(89, 151);
      this.stbOverheadBytesObject.Name = "stbOverheadBytesObject";
      this.stbOverheadBytesObject.ReadOnly = true;
      this.stbOverheadBytesObject.Size = new System.Drawing.Size(100, 20);
      this.stbOverheadBytesObject.TabIndex = 11;
      this.stbOverheadBytesObject.Text = "0";
      this.stbOverheadBytesObject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(14, 154);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(57, 13);
      this.label13.TabIndex = 10;
      this.label13.Text = "Per Object";
      // 
      // stbOverheadBytes
      // 
      this.stbOverheadBytes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbOverheadBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbOverheadBytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.stbOverheadBytes.Location = new System.Drawing.Point(89, 125);
      this.stbOverheadBytes.Name = "stbOverheadBytes";
      this.stbOverheadBytes.ReadOnly = true;
      this.stbOverheadBytes.Size = new System.Drawing.Size(100, 20);
      this.stbOverheadBytes.TabIndex = 9;
      this.stbOverheadBytes.Text = "0";
      this.stbOverheadBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(14, 128);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(54, 13);
      this.label12.TabIndex = 8;
      this.label12.Text = "Overhead";
      // 
      // stbUtilizedBytesObject
      // 
      this.stbUtilizedBytesObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbUtilizedBytesObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbUtilizedBytesObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.stbUtilizedBytesObject.Location = new System.Drawing.Point(89, 99);
      this.stbUtilizedBytesObject.Name = "stbUtilizedBytesObject";
      this.stbUtilizedBytesObject.ReadOnly = true;
      this.stbUtilizedBytesObject.Size = new System.Drawing.Size(100, 20);
      this.stbUtilizedBytesObject.TabIndex = 7;
      this.stbUtilizedBytesObject.Text = "0";
      this.stbUtilizedBytesObject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(14, 102);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(57, 13);
      this.label11.TabIndex = 6;
      this.label11.Text = "Per Object";
      // 
      // stbUtilizedBytes
      // 
      this.stbUtilizedBytes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbUtilizedBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbUtilizedBytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.stbUtilizedBytes.Location = new System.Drawing.Point(89, 73);
      this.stbUtilizedBytes.Name = "stbUtilizedBytes";
      this.stbUtilizedBytes.ReadOnly = true;
      this.stbUtilizedBytes.Size = new System.Drawing.Size(100, 20);
      this.stbUtilizedBytes.TabIndex = 5;
      this.stbUtilizedBytes.Text = "0";
      this.stbUtilizedBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(14, 76);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(41, 13);
      this.label10.TabIndex = 4;
      this.label10.Text = "Utilized";
      // 
      // stbMemBytes
      // 
      this.stbMemBytes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbMemBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbMemBytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.stbMemBytes.Location = new System.Drawing.Point(89, 47);
      this.stbMemBytes.Name = "stbMemBytes";
      this.stbMemBytes.ReadOnly = true;
      this.stbMemBytes.Size = new System.Drawing.Size(100, 20);
      this.stbMemBytes.TabIndex = 3;
      this.stbMemBytes.Text = "0";
      this.stbMemBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(14, 50);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(51, 13);
      this.label9.TabIndex = 2;
      this.label9.Text = "Allocated";
      // 
      // stbObjectCount
      // 
      this.stbObjectCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbObjectCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbObjectCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.stbObjectCount.Location = new System.Drawing.Point(89, 21);
      this.stbObjectCount.Name = "stbObjectCount";
      this.stbObjectCount.ReadOnly = true;
      this.stbObjectCount.Size = new System.Drawing.Size(100, 20);
      this.stbObjectCount.TabIndex = 1;
      this.stbObjectCount.Text = "0";
      this.stbObjectCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(14, 24);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(69, 13);
      this.label8.TabIndex = 0;
      this.label8.Text = "Object Count";
      // 
      // btnCrawl
      // 
      this.btnCrawl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btnCrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCrawl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnCrawl.Location = new System.Drawing.Point(96, 266);
      this.btnCrawl.Name = "btnCrawl";
      this.btnCrawl.Size = new System.Drawing.Size(75, 37);
      this.btnCrawl.TabIndex = 17;
      this.btnCrawl.Text = "Crawl";
      this.btnCrawl.UseVisualStyleBackColor = false;
      this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
      // 
      // btnPurge
      // 
      this.btnPurge.BackColor = System.Drawing.Color.Red;
      this.btnPurge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPurge.ForeColor = System.Drawing.Color.Yellow;
      this.btnPurge.Location = new System.Drawing.Point(15, 266);
      this.btnPurge.Name = "btnPurge";
      this.btnPurge.Size = new System.Drawing.Size(75, 37);
      this.btnPurge.TabIndex = 16;
      this.btnPurge.Text = "Purge";
      this.btnPurge.UseVisualStyleBackColor = false;
      this.btnPurge.Click += new System.EventHandler(this.btnPurge_Click);
      // 
      // lblPileDeletes
      // 
      this.lblPileDeletes.AutoSize = true;
      this.lblPileDeletes.ForeColor = System.Drawing.Color.Silver;
      this.lblPileDeletes.Location = new System.Drawing.Point(17, 199);
      this.lblPileDeletes.Name = "lblPileDeletes";
      this.lblPileDeletes.Size = new System.Drawing.Size(43, 13);
      this.lblPileDeletes.TabIndex = 15;
      this.lblPileDeletes.Text = "Deletes";
      // 
      // sbPileDeletes
      // 
      this.sbPileDeletes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sbPileDeletes.Location = new System.Drawing.Point(18, 225);
      this.sbPileDeletes.Name = "sbPileDeletes";
      this.sbPileDeletes.Size = new System.Drawing.Size(490, 27);
      this.sbPileDeletes.TabIndex = 14;
      // 
      // lblPileWrites
      // 
      this.lblPileWrites.AutoSize = true;
      this.lblPileWrites.ForeColor = System.Drawing.Color.Silver;
      this.lblPileWrites.Location = new System.Drawing.Point(15, 132);
      this.lblPileWrites.Name = "lblPileWrites";
      this.lblPileWrites.Size = new System.Drawing.Size(37, 13);
      this.lblPileWrites.TabIndex = 13;
      this.lblPileWrites.Text = "Writes";
      // 
      // lblPileReads
      // 
      this.lblPileReads.AutoSize = true;
      this.lblPileReads.ForeColor = System.Drawing.Color.Silver;
      this.lblPileReads.Location = new System.Drawing.Point(15, 66);
      this.lblPileReads.Name = "lblPileReads";
      this.lblPileReads.Size = new System.Drawing.Size(41, 13);
      this.lblPileReads.TabIndex = 12;
      this.lblPileReads.Text = "Reads:";
      // 
      // sbPileWrites
      // 
      this.sbPileWrites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sbPileWrites.Location = new System.Drawing.Point(18, 158);
      this.sbPileWrites.Name = "sbPileWrites";
      this.sbPileWrites.Size = new System.Drawing.Size(490, 27);
      this.sbPileWrites.TabIndex = 11;
      // 
      // sbPileReads
      // 
      this.sbPileReads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sbPileReads.Location = new System.Drawing.Point(18, 89);
      this.sbPileReads.Name = "sbPileReads";
      this.sbPileReads.Size = new System.Drawing.Size(490, 27);
      this.sbPileReads.TabIndex = 10;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.ForeColor = System.Drawing.Color.Silver;
      this.label6.Location = new System.Drawing.Point(270, 32);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(71, 13);
      this.label6.TabIndex = 8;
      this.label6.Text = "Max Mem Mb";
      // 
      // tbMaxMemMb
      // 
      this.tbMaxMemMb.BackColor = System.Drawing.Color.Gray;
      this.tbMaxMemMb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbMaxMemMb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbMaxMemMb.Location = new System.Drawing.Point(343, 29);
      this.tbMaxMemMb.Name = "tbMaxMemMb";
      this.tbMaxMemMb.ReadOnly = true;
      this.tbMaxMemMb.Size = new System.Drawing.Size(49, 20);
      this.tbMaxMemMb.TabIndex = 7;
      this.tbMaxMemMb.Text = "0";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ForeColor = System.Drawing.Color.Silver;
      this.label5.Location = new System.Drawing.Point(128, 32);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(67, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Seg Size Mb";
      // 
      // tbSegSizeMb
      // 
      this.tbSegSizeMb.BackColor = System.Drawing.Color.Gray;
      this.tbSegSizeMb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbSegSizeMb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbSegSizeMb.Location = new System.Drawing.Point(201, 29);
      this.tbSegSizeMb.Name = "tbSegSizeMb";
      this.tbSegSizeMb.ReadOnly = true;
      this.tbSegSizeMb.Size = new System.Drawing.Size(49, 20);
      this.tbSegSizeMb.TabIndex = 5;
      this.tbSegSizeMb.Text = "512";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.Silver;
      this.label4.Location = new System.Drawing.Point(15, 32);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Threads";
      // 
      // tbPileThreads
      // 
      this.tbPileThreads.Location = new System.Drawing.Point(67, 29);
      this.tbPileThreads.Name = "tbPileThreads";
      this.tbPileThreads.Size = new System.Drawing.Size(49, 20);
      this.tbPileThreads.TabIndex = 3;
      this.tbPileThreads.Text = "0";
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.DimGray;
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(2, 2);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(513, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "NFX Pile";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // pnlJitter
      // 
      this.pnlJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.pnlJitter.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlJitter.Location = new System.Drawing.Point(0, 706);
      this.pnlJitter.Name = "pnlJitter";
      this.pnlJitter.Size = new System.Drawing.Size(1012, 34);
      this.pnlJitter.TabIndex = 5;
      this.pnlJitter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlJitter_Paint);
      // 
      // pnlMain
      // 
      this.pnlMain.Controls.Add(this.splitter1);
      this.pnlMain.Controls.Add(this.pnlCLR);
      this.pnlMain.Controls.Add(this.pnlPile);
      this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlMain.Location = new System.Drawing.Point(0, 113);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new System.Drawing.Size(1012, 593);
      this.pnlMain.TabIndex = 6;
      // 
      // splitter1
      // 
      this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.splitter1.Location = new System.Drawing.Point(517, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(6, 593);
      this.splitter1.TabIndex = 3;
      this.splitter1.TabStop = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1012, 762);
      this.Controls.Add(this.pnlMain);
      this.Controls.Add(this.pnlJitter);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.pnlTop);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Social Trading";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.pnlTop.ResumeLayout(false);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.pnlCLR.ResumeLayout(false);
      this.pnlCLR.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.pnlPile.ResumeLayout(false);
      this.pnlPile.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.pnlMain.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer tmrUI;
    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel lblJitter;
    private System.Windows.Forms.ToolStripStatusLabel lblRamAvailable;
    private System.Windows.Forms.Panel pnlCLR;
    private System.Windows.Forms.Panel pnlPile;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnGC;
    private System.Windows.Forms.Label lblCLRDeletes;
    private System.Windows.Forms.HScrollBar sbCLRDeletes;
    private System.Windows.Forms.Label lblCLRWrites;
    private System.Windows.Forms.Label lblCLRReads;
    private System.Windows.Forms.HScrollBar sbCLRWrites;
    private System.Windows.Forms.HScrollBar sbCLRReads;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbCLRThreads;
    private System.Windows.Forms.Label lblPileDeletes;
    private System.Windows.Forms.HScrollBar sbPileDeletes;
    private System.Windows.Forms.Label lblPileWrites;
    private System.Windows.Forms.Label lblPileReads;
    private System.Windows.Forms.HScrollBar sbPileWrites;
    private System.Windows.Forms.HScrollBar sbPileReads;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbMaxMemMb;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbSegSizeMb;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbPileThreads;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox stbCLRObjectCount;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnCLRPurge;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox stbSegments;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox stbOverheadBytesObject;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox stbOverheadBytes;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox stbUtilizedBytesObject;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox stbUtilizedBytes;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox stbMemBytes;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox stbObjectCount;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnCrawl;
    private System.Windows.Forms.Button btnPurge;
    private System.Windows.Forms.ListBox lbPileLog;
    private System.Windows.Forms.CheckBox chkSpeed;
    private System.Windows.Forms.TextBox stbTotalSegments;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.ListBox lbLog;
    private System.Windows.Forms.Panel pnlJitter;
    private System.Windows.Forms.Panel pnlMain;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.ListBox lbCLRLog;
  }
}

