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
      this.pnlStatus = new System.Windows.Forms.StatusStrip();
      this.pnlTop = new System.Windows.Forms.Panel();
      this.btnGC = new System.Windows.Forms.Button();
      this.cboBackend = new System.Windows.Forms.ComboBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.pnlJitter = new System.Windows.Forms.Panel();
      this.pnlMain = new System.Windows.Forms.Panel();
      this.pnlControl = new System.Windows.Forms.Panel();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.pnlInfo = new System.Windows.Forms.Panel();
      this.pnlTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.pnlMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlStatus
      // 
      this.pnlStatus.Location = new System.Drawing.Point(0, 416);
      this.pnlStatus.Name = "pnlStatus";
      this.pnlStatus.Size = new System.Drawing.Size(805, 22);
      this.pnlStatus.TabIndex = 0;
      this.pnlStatus.Text = "statusStrip1";
      // 
      // pnlTop
      // 
      this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.pnlTop.Controls.Add(this.btnStop);
      this.pnlTop.Controls.Add(this.btnStart);
      this.pnlTop.Controls.Add(this.pictureBox1);
      this.pnlTop.Controls.Add(this.cboBackend);
      this.pnlTop.Controls.Add(this.btnGC);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(805, 43);
      this.pnlTop.TabIndex = 1;
      // 
      // btnGC
      // 
      this.btnGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGC.ForeColor = System.Drawing.Color.Purple;
      this.btnGC.Location = new System.Drawing.Point(12, 9);
      this.btnGC.Name = "btnGC";
      this.btnGC.Size = new System.Drawing.Size(75, 23);
      this.btnGC.TabIndex = 0;
      this.btnGC.Text = "Full GC";
      this.btnGC.UseVisualStyleBackColor = true;
      // 
      // cboBackend
      // 
      this.cboBackend.FormattingEnabled = true;
      this.cboBackend.Items.AddRange(new object[] {
            "CLR",
            "NFX Pile"});
      this.cboBackend.Location = new System.Drawing.Point(111, 11);
      this.cboBackend.Name = "cboBackend";
      this.cboBackend.Size = new System.Drawing.Size(121, 21);
      this.cboBackend.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Image = global::UserGraph.Properties.Resources.New_NFX_Logo_25;
      this.pictureBox1.Location = new System.Drawing.Point(695, 9);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(104, 25);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // btnStart
      // 
      this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStart.ForeColor = System.Drawing.Color.Green;
      this.btnStart.Location = new System.Drawing.Point(247, 9);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      // 
      // btnStop
      // 
      this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStop.ForeColor = System.Drawing.Color.Maroon;
      this.btnStop.Location = new System.Drawing.Point(328, 9);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.TabIndex = 4;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      // 
      // pnlJitter
      // 
      this.pnlJitter.BackColor = System.Drawing.Color.Black;
      this.pnlJitter.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlJitter.Location = new System.Drawing.Point(0, 375);
      this.pnlJitter.Name = "pnlJitter";
      this.pnlJitter.Size = new System.Drawing.Size(805, 41);
      this.pnlJitter.TabIndex = 2;
      // 
      // pnlMain
      // 
      this.pnlMain.Controls.Add(this.pnlInfo);
      this.pnlMain.Controls.Add(this.splitter1);
      this.pnlMain.Controls.Add(this.pnlControl);
      this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlMain.Location = new System.Drawing.Point(0, 43);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new System.Drawing.Size(805, 332);
      this.pnlMain.TabIndex = 3;
      // 
      // pnlControl
      // 
      this.pnlControl.BackColor = System.Drawing.Color.Gray;
      this.pnlControl.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlControl.Location = new System.Drawing.Point(0, 0);
      this.pnlControl.Name = "pnlControl";
      this.pnlControl.Size = new System.Drawing.Size(289, 332);
      this.pnlControl.TabIndex = 0;
      // 
      // splitter1
      // 
      this.splitter1.BackColor = System.Drawing.Color.Olive;
      this.splitter1.Location = new System.Drawing.Point(289, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(6, 332);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      // 
      // pnlInfo
      // 
      this.pnlInfo.BackColor = System.Drawing.Color.Gray;
      this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlInfo.Location = new System.Drawing.Point(295, 0);
      this.pnlInfo.Name = "pnlInfo";
      this.pnlInfo.Size = new System.Drawing.Size(510, 332);
      this.pnlInfo.TabIndex = 2;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(805, 438);
      this.Controls.Add(this.pnlMain);
      this.Controls.Add(this.pnlJitter);
      this.Controls.Add(this.pnlTop);
      this.Controls.Add(this.pnlStatus);
      this.Name = "MainForm";
      this.Text = "User Graph";
      this.pnlTop.ResumeLayout(false);
      this.pnlTop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.pnlMain.ResumeLayout(false);
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
  }
}

