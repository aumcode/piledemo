namespace UserGraph
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
      this.pnlStatus = new System.Windows.Forms.StatusStrip();
      this.lblJitter = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblRamAvailable = new System.Windows.Forms.ToolStripStatusLabel();
      this.pnlTop = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.tbThreads = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbUsers = new System.Windows.Forms.TextBox();
      this.btnStop = new System.Windows.Forms.Button();
      this.btnStart = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.cboBackend = new System.Windows.Forms.ComboBox();
      this.btnGC = new System.Windows.Forms.Button();
      this.pnlJitter = new System.Windows.Forms.Panel();
      this.pnlMain = new System.Windows.Forms.Panel();
      this.pnlInfo = new System.Windows.Forms.Panel();
      this.chart = new NFX.WinForms.Controls.ChartKit.Temporal.TimeSeriesChart();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.pnlControl = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.label18 = new System.Windows.Forms.Label();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.label19 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.stbTotalSegments = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
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
      this.lblPileDeletes = new System.Windows.Forms.Label();
      this.lbPileLog = new System.Windows.Forms.ListBox();
      this.sbPileDeletes = new System.Windows.Forms.HScrollBar();
      this.lblPileWrites = new System.Windows.Forms.Label();
      this.lblPileReads = new System.Windows.Forms.Label();
      this.sbPileWrites = new System.Windows.Forms.HScrollBar();
      this.sbPileReads = new System.Windows.Forms.HScrollBar();
      this.tmrUI = new System.Windows.Forms.Timer(this.components);
      this.pnlStatus.SuspendLayout();
      this.pnlTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.pnlMain.SuspendLayout();
      this.pnlInfo.SuspendLayout();
      this.pnlControl.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlStatus
      // 
      this.pnlStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblJitter,
            this.lblRamAvailable});
      this.pnlStatus.Location = new System.Drawing.Point(0, 723);
      this.pnlStatus.Name = "pnlStatus";
      this.pnlStatus.Size = new System.Drawing.Size(1116, 22);
      this.pnlStatus.TabIndex = 0;
      this.pnlStatus.Text = "statusStrip1";
      // 
      // lblJitter
      // 
      this.lblJitter.Name = "lblJitter";
      this.lblJitter.Size = new System.Drawing.Size(118, 17);
      this.lblJitter.Text = "toolStripStatusLabel1";
      // 
      // lblRamAvailable
      // 
      this.lblRamAvailable.Name = "lblRamAvailable";
      this.lblRamAvailable.Size = new System.Drawing.Size(118, 17);
      this.lblRamAvailable.Text = "toolStripStatusLabel1";
      // 
      // pnlTop
      // 
      this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.pnlTop.Controls.Add(this.label5);
      this.pnlTop.Controls.Add(this.tbThreads);
      this.pnlTop.Controls.Add(this.label3);
      this.pnlTop.Controls.Add(this.label2);
      this.pnlTop.Controls.Add(this.tbUsers);
      this.pnlTop.Controls.Add(this.btnStop);
      this.pnlTop.Controls.Add(this.btnStart);
      this.pnlTop.Controls.Add(this.pictureBox1);
      this.pnlTop.Controls.Add(this.cboBackend);
      this.pnlTop.Controls.Add(this.btnGC);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(1116, 43);
      this.pnlTop.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ForeColor = System.Drawing.Color.Silver;
      this.label5.Location = new System.Drawing.Point(387, 14);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(46, 13);
      this.label5.TabIndex = 30;
      this.label5.Text = "Threads";
      // 
      // tbThreads
      // 
      this.tbThreads.BackColor = System.Drawing.Color.Silver;
      this.tbThreads.Location = new System.Drawing.Point(439, 11);
      this.tbThreads.Name = "tbThreads";
      this.tbThreads.Size = new System.Drawing.Size(49, 20);
      this.tbThreads.TabIndex = 29;
      this.tbThreads.Text = "0";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.Silver;
      this.label3.Location = new System.Drawing.Point(98, 15);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(50, 13);
      this.label3.TabIndex = 28;
      this.label3.Text = "Backend";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Silver;
      this.label2.Location = new System.Drawing.Point(252, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 13);
      this.label2.TabIndex = 27;
      this.label2.Text = "Users";
      // 
      // tbUsers
      // 
      this.tbUsers.BackColor = System.Drawing.Color.Silver;
      this.tbUsers.Location = new System.Drawing.Point(289, 11);
      this.tbUsers.Name = "tbUsers";
      this.tbUsers.Size = new System.Drawing.Size(86, 20);
      this.tbUsers.TabIndex = 26;
      this.tbUsers.Text = "1,000,000";
      this.tbUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btnStop
      // 
      this.btnStop.BackColor = System.Drawing.Color.Maroon;
      this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStop.ForeColor = System.Drawing.Color.Salmon;
      this.btnStop.Location = new System.Drawing.Point(592, 9);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.TabIndex = 4;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = false;
      // 
      // btnStart
      // 
      this.btnStart.BackColor = System.Drawing.Color.Green;
      this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStart.ForeColor = System.Drawing.Color.LawnGreen;
      this.btnStart.Location = new System.Drawing.Point(511, 9);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Image = global::UserGraph.Properties.Resources.New_NFX_Logo_25;
      this.pictureBox1.Location = new System.Drawing.Point(1006, 9);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(104, 25);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // cboBackend
      // 
      this.cboBackend.BackColor = System.Drawing.Color.Silver;
      this.cboBackend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboBackend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cboBackend.FormattingEnabled = true;
      this.cboBackend.Items.AddRange(new object[] {
            "NFX Pile",
            "CLR Objects"});
      this.cboBackend.Location = new System.Drawing.Point(152, 11);
      this.cboBackend.Name = "cboBackend";
      this.cboBackend.Size = new System.Drawing.Size(89, 21);
      this.cboBackend.TabIndex = 1;
      // 
      // btnGC
      // 
      this.btnGC.BackColor = System.Drawing.Color.Purple;
      this.btnGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.btnGC.Location = new System.Drawing.Point(12, 9);
      this.btnGC.Name = "btnGC";
      this.btnGC.Size = new System.Drawing.Size(75, 23);
      this.btnGC.TabIndex = 0;
      this.btnGC.Text = "Full GC";
      this.btnGC.UseVisualStyleBackColor = false;
      this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
      // 
      // pnlJitter
      // 
      this.pnlJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.pnlJitter.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlJitter.Location = new System.Drawing.Point(0, 682);
      this.pnlJitter.Name = "pnlJitter";
      this.pnlJitter.Size = new System.Drawing.Size(1116, 41);
      this.pnlJitter.TabIndex = 2;
      this.pnlJitter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlJitter_Paint);
      // 
      // pnlMain
      // 
      this.pnlMain.Controls.Add(this.pnlInfo);
      this.pnlMain.Controls.Add(this.splitter1);
      this.pnlMain.Controls.Add(this.pnlControl);
      this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlMain.Location = new System.Drawing.Point(0, 43);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new System.Drawing.Size(1116, 639);
      this.pnlMain.TabIndex = 3;
      // 
      // pnlInfo
      // 
      this.pnlInfo.BackColor = System.Drawing.Color.Gray;
      this.pnlInfo.Controls.Add(this.chart);
      this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlInfo.Location = new System.Drawing.Point(484, 0);
      this.pnlInfo.Name = "pnlInfo";
      this.pnlInfo.Size = new System.Drawing.Size(632, 639);
      this.pnlInfo.TabIndex = 2;
      // 
      // chart
      // 
      this.chart.AllowMultiLineTitle = false;
      this.chart.AutoScroll = true;
      this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.chart.HScrollPosition = 0;
      this.chart.ID = "";
      this.chart.Location = new System.Drawing.Point(3, 6);
      this.chart.MouseCursorMode = NFX.WinForms.Controls.ChartKit.Temporal.MouseCursorMode.Click;
      this.chart.Name = "chart";
      this.chart.ReadOnly = false;
      this.chart.Series = null;
      this.chart.ShowTimeGaps = true;
      this.chart.Size = new System.Drawing.Size(623, 270);
      this.chart.TabIndex = 0;
      this.chart.Text = "timeSeriesChart1";
      this.chart.TimeLineTickSpace = 52;
      this.chart.UseLocalTime = false;
      this.chart.VRulerDefaultFormat = null;
      this.chart.VRulerFixedWidth = 0;
      this.chart.VRulerPosition = NFX.WinForms.Controls.ChartKit.VRulerPosition.Right;
      this.chart.Zoom = 1F;
      this.chart.ZoomStepPercent = 5;
      // 
      // splitter1
      // 
      this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.splitter1.Location = new System.Drawing.Point(478, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(6, 639);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      // 
      // pnlControl
      // 
      this.pnlControl.BackColor = System.Drawing.Color.Gray;
      this.pnlControl.Controls.Add(this.panel1);
      this.pnlControl.Controls.Add(this.panel2);
      this.pnlControl.Controls.Add(this.lblPileDeletes);
      this.pnlControl.Controls.Add(this.lbPileLog);
      this.pnlControl.Controls.Add(this.sbPileDeletes);
      this.pnlControl.Controls.Add(this.lblPileWrites);
      this.pnlControl.Controls.Add(this.lblPileReads);
      this.pnlControl.Controls.Add(this.sbPileWrites);
      this.pnlControl.Controls.Add(this.sbPileReads);
      this.pnlControl.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlControl.Location = new System.Drawing.Point(0, 0);
      this.pnlControl.Name = "pnlControl";
      this.pnlControl.Size = new System.Drawing.Size(478, 639);
      this.pnlControl.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.textBox6);
      this.panel1.Controls.Add(this.label17);
      this.panel1.Controls.Add(this.textBox7);
      this.panel1.Controls.Add(this.label18);
      this.panel1.Controls.Add(this.textBox8);
      this.panel1.Controls.Add(this.label19);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 415);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(478, 93);
      this.panel1.TabIndex = 23;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.Silver;
      this.label4.Location = new System.Drawing.Point(426, 60);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(32, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "/ sec";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.ForeColor = System.Drawing.Color.Silver;
      this.label6.Location = new System.Drawing.Point(426, 34);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(32, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "/ sec";
      // 
      // textBox6
      // 
      this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox6.ForeColor = System.Drawing.Color.Red;
      this.textBox6.Location = new System.Drawing.Point(327, 53);
      this.textBox6.Name = "textBox6";
      this.textBox6.ReadOnly = true;
      this.textBox6.Size = new System.Drawing.Size(93, 20);
      this.textBox6.TabIndex = 5;
      this.textBox6.Text = "0";
      this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.ForeColor = System.Drawing.Color.Silver;
      this.label17.Location = new System.Drawing.Point(241, 56);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(65, 13);
      this.label17.TabIndex = 4;
      this.label17.Text = "Events /sec";
      // 
      // textBox7
      // 
      this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox7.ForeColor = System.Drawing.Color.Aqua;
      this.textBox7.Location = new System.Drawing.Point(327, 27);
      this.textBox7.Name = "textBox7";
      this.textBox7.ReadOnly = true;
      this.textBox7.Size = new System.Drawing.Size(93, 20);
      this.textBox7.TabIndex = 3;
      this.textBox7.Text = "0";
      this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.ForeColor = System.Drawing.Color.Silver;
      this.label18.Location = new System.Drawing.Point(241, 30);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(71, 13);
      this.label18.TabIndex = 2;
      this.label18.Text = "Queries / sec";
      // 
      // textBox8
      // 
      this.textBox8.BackColor = System.Drawing.Color.Black;
      this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox8.ForeColor = System.Drawing.Color.Lime;
      this.textBox8.Location = new System.Drawing.Point(17, 37);
      this.textBox8.Name = "textBox8";
      this.textBox8.ReadOnly = true;
      this.textBox8.Size = new System.Drawing.Size(146, 24);
      this.textBox8.TabIndex = 1;
      this.textBox8.Text = "0";
      this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label19.ForeColor = System.Drawing.Color.White;
      this.label19.Location = new System.Drawing.Point(14, 17);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(70, 13);
      this.label19.TabIndex = 0;
      this.label19.Text = "User Count";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      this.panel2.Controls.Add(this.stbTotalSegments);
      this.panel2.Controls.Add(this.label15);
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
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 508);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(478, 131);
      this.panel2.TabIndex = 22;
      // 
      // stbTotalSegments
      // 
      this.stbTotalSegments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbTotalSegments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbTotalSegments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stbTotalSegments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.stbTotalSegments.Location = new System.Drawing.Point(327, 100);
      this.stbTotalSegments.Name = "stbTotalSegments";
      this.stbTotalSegments.ReadOnly = true;
      this.stbTotalSegments.Size = new System.Drawing.Size(59, 20);
      this.stbTotalSegments.TabIndex = 16;
      this.stbTotalSegments.Text = "0";
      this.stbTotalSegments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.ForeColor = System.Drawing.Color.Silver;
      this.label15.Location = new System.Drawing.Point(252, 103);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(58, 13);
      this.label15.TabIndex = 15;
      this.label15.Text = "Total Segs";
      // 
      // stbSegments
      // 
      this.stbSegments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbSegments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbSegments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stbSegments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.stbSegments.Location = new System.Drawing.Point(327, 74);
      this.stbSegments.Name = "stbSegments";
      this.stbSegments.ReadOnly = true;
      this.stbSegments.Size = new System.Drawing.Size(59, 20);
      this.stbSegments.TabIndex = 13;
      this.stbSegments.Text = "0";
      this.stbSegments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.ForeColor = System.Drawing.Color.Silver;
      this.label14.Location = new System.Drawing.Point(252, 77);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(54, 13);
      this.label14.TabIndex = 12;
      this.label14.Text = "Segments";
      // 
      // stbOverheadBytesObject
      // 
      this.stbOverheadBytesObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbOverheadBytesObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbOverheadBytesObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stbOverheadBytesObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.stbOverheadBytesObject.Location = new System.Drawing.Point(327, 48);
      this.stbOverheadBytesObject.Name = "stbOverheadBytesObject";
      this.stbOverheadBytesObject.ReadOnly = true;
      this.stbOverheadBytesObject.Size = new System.Drawing.Size(138, 20);
      this.stbOverheadBytesObject.TabIndex = 11;
      this.stbOverheadBytesObject.Text = "0";
      this.stbOverheadBytesObject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.ForeColor = System.Drawing.Color.Silver;
      this.label13.Location = new System.Drawing.Point(252, 51);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(57, 13);
      this.label13.TabIndex = 10;
      this.label13.Text = "Per Object";
      // 
      // stbOverheadBytes
      // 
      this.stbOverheadBytes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbOverheadBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbOverheadBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stbOverheadBytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.stbOverheadBytes.Location = new System.Drawing.Point(327, 22);
      this.stbOverheadBytes.Name = "stbOverheadBytes";
      this.stbOverheadBytes.ReadOnly = true;
      this.stbOverheadBytes.Size = new System.Drawing.Size(138, 20);
      this.stbOverheadBytes.TabIndex = 9;
      this.stbOverheadBytes.Text = "0";
      this.stbOverheadBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.ForeColor = System.Drawing.Color.Silver;
      this.label12.Location = new System.Drawing.Point(252, 25);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(54, 13);
      this.label12.TabIndex = 8;
      this.label12.Text = "Overhead";
      // 
      // stbUtilizedBytesObject
      // 
      this.stbUtilizedBytesObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.stbUtilizedBytesObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbUtilizedBytesObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stbUtilizedBytesObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.stbUtilizedBytesObject.Location = new System.Drawing.Point(100, 99);
      this.stbUtilizedBytesObject.Name = "stbUtilizedBytesObject";
      this.stbUtilizedBytesObject.ReadOnly = true;
      this.stbUtilizedBytesObject.Size = new System.Drawing.Size(146, 20);
      this.stbUtilizedBytesObject.TabIndex = 7;
      this.stbUtilizedBytesObject.Text = "0";
      this.stbUtilizedBytesObject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.ForeColor = System.Drawing.Color.Silver;
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
      this.stbUtilizedBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stbUtilizedBytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.stbUtilizedBytes.Location = new System.Drawing.Point(100, 73);
      this.stbUtilizedBytes.Name = "stbUtilizedBytes";
      this.stbUtilizedBytes.ReadOnly = true;
      this.stbUtilizedBytes.Size = new System.Drawing.Size(146, 20);
      this.stbUtilizedBytes.TabIndex = 5;
      this.stbUtilizedBytes.Text = "0";
      this.stbUtilizedBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.ForeColor = System.Drawing.Color.Silver;
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
      this.stbMemBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stbMemBytes.ForeColor = System.Drawing.Color.Red;
      this.stbMemBytes.Location = new System.Drawing.Point(100, 47);
      this.stbMemBytes.Name = "stbMemBytes";
      this.stbMemBytes.ReadOnly = true;
      this.stbMemBytes.Size = new System.Drawing.Size(146, 20);
      this.stbMemBytes.TabIndex = 3;
      this.stbMemBytes.Text = "0";
      this.stbMemBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.ForeColor = System.Drawing.Color.Silver;
      this.label9.Location = new System.Drawing.Point(14, 50);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(51, 13);
      this.label9.TabIndex = 2;
      this.label9.Text = "Allocated";
      // 
      // stbObjectCount
      // 
      this.stbObjectCount.BackColor = System.Drawing.Color.Black;
      this.stbObjectCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.stbObjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stbObjectCount.ForeColor = System.Drawing.Color.Lime;
      this.stbObjectCount.Location = new System.Drawing.Point(100, 19);
      this.stbObjectCount.Name = "stbObjectCount";
      this.stbObjectCount.ReadOnly = true;
      this.stbObjectCount.Size = new System.Drawing.Size(146, 24);
      this.stbObjectCount.TabIndex = 1;
      this.stbObjectCount.Text = "0";
      this.stbObjectCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.ForeColor = System.Drawing.Color.White;
      this.label8.Location = new System.Drawing.Point(14, 24);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(81, 13);
      this.label8.TabIndex = 0;
      this.label8.Text = "Object Count";
      // 
      // lblPileDeletes
      // 
      this.lblPileDeletes.AutoSize = true;
      this.lblPileDeletes.ForeColor = System.Drawing.Color.Silver;
      this.lblPileDeletes.Location = new System.Drawing.Point(3, 88);
      this.lblPileDeletes.Name = "lblPileDeletes";
      this.lblPileDeletes.Size = new System.Drawing.Size(43, 13);
      this.lblPileDeletes.TabIndex = 21;
      this.lblPileDeletes.Text = "Deletes";
      // 
      // lbPileLog
      // 
      this.lbPileLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbPileLog.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbPileLog.FormattingEnabled = true;
      this.lbPileLog.ItemHeight = 16;
      this.lbPileLog.Location = new System.Drawing.Point(12, 133);
      this.lbPileLog.Name = "lbPileLog";
      this.lbPileLog.Size = new System.Drawing.Size(454, 276);
      this.lbPileLog.TabIndex = 14;
      // 
      // sbPileDeletes
      // 
      this.sbPileDeletes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sbPileDeletes.Location = new System.Drawing.Point(48, 87);
      this.sbPileDeletes.Name = "sbPileDeletes";
      this.sbPileDeletes.Size = new System.Drawing.Size(407, 22);
      this.sbPileDeletes.TabIndex = 20;
      // 
      // lblPileWrites
      // 
      this.lblPileWrites.AutoSize = true;
      this.lblPileWrites.ForeColor = System.Drawing.Color.Silver;
      this.lblPileWrites.Location = new System.Drawing.Point(4, 52);
      this.lblPileWrites.Name = "lblPileWrites";
      this.lblPileWrites.Size = new System.Drawing.Size(37, 13);
      this.lblPileWrites.TabIndex = 19;
      this.lblPileWrites.Text = "Writes";
      // 
      // lblPileReads
      // 
      this.lblPileReads.AutoSize = true;
      this.lblPileReads.ForeColor = System.Drawing.Color.Silver;
      this.lblPileReads.Location = new System.Drawing.Point(4, 14);
      this.lblPileReads.Name = "lblPileReads";
      this.lblPileReads.Size = new System.Drawing.Size(38, 13);
      this.lblPileReads.TabIndex = 18;
      this.lblPileReads.Text = "Reads";
      // 
      // sbPileWrites
      // 
      this.sbPileWrites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sbPileWrites.Location = new System.Drawing.Point(48, 49);
      this.sbPileWrites.Name = "sbPileWrites";
      this.sbPileWrites.Size = new System.Drawing.Size(407, 22);
      this.sbPileWrites.TabIndex = 17;
      // 
      // sbPileReads
      // 
      this.sbPileReads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sbPileReads.Location = new System.Drawing.Point(48, 11);
      this.sbPileReads.Name = "sbPileReads";
      this.sbPileReads.Size = new System.Drawing.Size(407, 22);
      this.sbPileReads.TabIndex = 16;
      // 
      // tmrUI
      // 
      this.tmrUI.Interval = 150;
      this.tmrUI.Tick += new System.EventHandler(this.tmrUI_Tick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1116, 745);
      this.Controls.Add(this.pnlMain);
      this.Controls.Add(this.pnlJitter);
      this.Controls.Add(this.pnlTop);
      this.Controls.Add(this.pnlStatus);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(800, 250);
      this.Name = "MainForm";
      this.Text = "User Graph";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.pnlStatus.ResumeLayout(false);
      this.pnlStatus.PerformLayout();
      this.pnlTop.ResumeLayout(false);
      this.pnlTop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlInfo.ResumeLayout(false);
      this.pnlControl.ResumeLayout(false);
      this.pnlControl.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip pnlStatus;
    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ComboBox cboBackend;
    private System.Windows.Forms.Button btnGC;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Panel pnlJitter;
    private System.Windows.Forms.Panel pnlMain;
    private System.Windows.Forms.Panel pnlInfo;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Panel pnlControl;
    private System.Windows.Forms.Label lblPileDeletes;
    private System.Windows.Forms.HScrollBar sbPileDeletes;
    private System.Windows.Forms.Label lblPileWrites;
    private System.Windows.Forms.Label lblPileReads;
    private System.Windows.Forms.HScrollBar sbPileWrites;
    private System.Windows.Forms.HScrollBar sbPileReads;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbThreads;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbUsers;
    private System.Windows.Forms.ToolStripStatusLabel lblJitter;
    private System.Windows.Forms.ToolStripStatusLabel lblRamAvailable;
    private System.Windows.Forms.Timer tmrUI;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox stbTotalSegments;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.ListBox lbPileLog;
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
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.Label label19;
    private NFX.WinForms.Controls.ChartKit.Temporal.TimeSeriesChart chart;
  }
}

