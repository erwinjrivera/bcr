
namespace BatteryChargeReminder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minimizeMaximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblBatteryStatus = new System.Windows.Forms.Label();
            this.pbBatteryStatus = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEstimatedTimeRemaining = new System.Windows.Forms.Label();
            this.lblEstimatedTimeRemainingValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblValueLeft = new System.Windows.Forms.Label();
            this.lblValueRight = new System.Windows.Forms.Label();
            this.toggleSwitch1 = new BatteryChargeReminder.ToggleSwitch();
            this.doubleTrackBar1 = new DoubleTrackBar.DoubleTrackBar();
            this.lblEnabled = new System.Windows.Forms.Label();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBatteryStatus)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "To exit, right click on the notification icon and select Exit.";
            this.notifyIcon1.BalloonTipTitle = "Application is still running...";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Tag = "Tag";
            this.notifyIcon1.Text = "Battery Charge Reminder";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableToolStripMenuItem,
            this.minimizeMaximizeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // minimizeMaximizeToolStripMenuItem
            // 
            this.minimizeMaximizeToolStripMenuItem.Name = "minimizeMaximizeToolStripMenuItem";
            this.minimizeMaximizeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.minimizeMaximizeToolStripMenuItem.Text = "Minimize Maximize";
            this.minimizeMaximizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeMaximizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(38, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notify to START charging when battery charge level is below:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(848, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(848, 408);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(320, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 56);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notify to STOP charging when battery charge level reaches:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "50%",
            "58%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.comboBox1.Location = new System.Drawing.Point(999, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 25);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%",
            "25%",
            "30%",
            "35%",
            "40%",
            "45%"});
            this.comboBox2.Location = new System.Drawing.Point(1008, 267);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 25);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblBatteryStatus
            // 
            this.lblBatteryStatus.AutoSize = true;
            this.lblBatteryStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblBatteryStatus.Location = new System.Drawing.Point(3, 0);
            this.lblBatteryStatus.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblBatteryStatus.Name = "lblBatteryStatus";
            this.lblBatteryStatus.Size = new System.Drawing.Size(104, 71);
            this.lblBatteryStatus.TabIndex = 8;
            this.lblBatteryStatus.Text = "0%";
            // 
            // pbBatteryStatus
            // 
            this.pbBatteryStatus.Location = new System.Drawing.Point(110, 3);
            this.pbBatteryStatus.Name = "pbBatteryStatus";
            this.pbBatteryStatus.Size = new System.Drawing.Size(57, 70);
            this.pbBatteryStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBatteryStatus.TabIndex = 9;
            this.pbBatteryStatus.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "charging");
            this.imageList1.Images.SetKeyName(1, "low");
            this.imageList1.Images.SetKeyName(2, "medium");
            this.imageList1.Images.SetKeyName(3, "high");
            this.imageList1.Images.SetKeyName(4, "full");
            this.imageList1.Images.SetKeyName(5, "no");
            this.imageList1.Images.SetKeyName(6, "unknown");
            this.imageList1.Images.SetKeyName(7, "empty");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblBatteryStatus);
            this.flowLayoutPanel1.Controls.Add(this.pbBatteryStatus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 76);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // lblEstimatedTimeRemaining
            // 
            this.lblEstimatedTimeRemaining.AutoSize = true;
            this.lblEstimatedTimeRemaining.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedTimeRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblEstimatedTimeRemaining.Location = new System.Drawing.Point(3, 0);
            this.lblEstimatedTimeRemaining.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEstimatedTimeRemaining.Name = "lblEstimatedTimeRemaining";
            this.lblEstimatedTimeRemaining.Size = new System.Drawing.Size(159, 17);
            this.lblEstimatedTimeRemaining.TabIndex = 11;
            this.lblEstimatedTimeRemaining.Text = "Estimated time remaining:";
            // 
            // lblEstimatedTimeRemainingValue
            // 
            this.lblEstimatedTimeRemainingValue.AutoSize = true;
            this.lblEstimatedTimeRemainingValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedTimeRemainingValue.ForeColor = System.Drawing.Color.Black;
            this.lblEstimatedTimeRemainingValue.Location = new System.Drawing.Point(162, 0);
            this.lblEstimatedTimeRemainingValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblEstimatedTimeRemainingValue.Name = "lblEstimatedTimeRemainingValue";
            this.lblEstimatedTimeRemainingValue.Size = new System.Drawing.Size(61, 17);
            this.lblEstimatedTimeRemainingValue.TabIndex = 12;
            this.lblEstimatedTimeRemainingValue.Text = "1h 43min";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblEstimatedTimeRemaining);
            this.flowLayoutPanel2.Controls.Add(this.lblEstimatedTimeRemainingValue);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(34, 99);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(454, 24);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(582, 150);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(357, 29);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblValueLeft
            // 
            this.lblValueLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lblValueLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblValueLeft.Location = new System.Drawing.Point(37, 281);
            this.lblValueLeft.Name = "lblValueLeft";
            this.lblValueLeft.Size = new System.Drawing.Size(151, 21);
            this.lblValueLeft.TabIndex = 15;
            this.lblValueLeft.Text = "20%";
            this.lblValueLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValueRight
            // 
            this.lblValueRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lblValueRight.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblValueRight.Location = new System.Drawing.Point(323, 281);
            this.lblValueRight.Name = "lblValueRight";
            this.lblValueRight.Size = new System.Drawing.Size(135, 21);
            this.lblValueRight.TabIndex = 17;
            this.lblValueRight.Text = "90%";
            this.lblValueRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.toggleSwitch1.Checked = true;
            this.toggleSwitch1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleSwitch1.Location = new System.Drawing.Point(391, 159);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Padding = new System.Windows.Forms.Padding(6);
            this.toggleSwitch1.Size = new System.Drawing.Size(67, 26);
            this.toggleSwitch1.TabIndex = 19;
            this.toggleSwitch1.Text = "toggleSwitch1";
            this.toggleSwitch1.UseVisualStyleBackColor = false;
            this.toggleSwitch1.CheckedChanged += new System.EventHandler(this.toggleSwitch1_CheckedChanged);
            // 
            // doubleTrackBar1
            // 
            this.doubleTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.doubleTrackBar1.BorderColor = System.Drawing.Color.Transparent;
            this.doubleTrackBar1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.doubleTrackBar1.LeftThumbColor = System.Drawing.Color.DodgerBlue;
            this.doubleTrackBar1.LeftThumbDirection = DoubleTrackBar.DoubleTrackBar.ThumbDirection.Bottom;
            this.doubleTrackBar1.Location = new System.Drawing.Point(35, 308);
            this.doubleTrackBar1.Maximum = 10;
            this.doubleTrackBar1.Minimum = 0;
            this.doubleTrackBar1.Name = "doubleTrackBar1";
            this.doubleTrackBar1.RightThumbColor = System.Drawing.Color.DodgerBlue;
            this.doubleTrackBar1.RightThumbDirection = DoubleTrackBar.DoubleTrackBar.ThumbDirection.Bottom;
            this.doubleTrackBar1.Size = new System.Drawing.Size(423, 45);
            this.doubleTrackBar1.SmallChange = 1;
            this.doubleTrackBar1.TabIndex = 18;
            this.doubleTrackBar1.Text = "doubleTrackBar1";
            this.doubleTrackBar1.TickEdgeStyle = System.Windows.Forms.VisualStyles.EdgeStyle.Etched;
            this.doubleTrackBar1.TickStyle = DoubleTrackBar.DoubleTrackBar.Tickstyle.None;
            this.doubleTrackBar1.ValueLeft = 0;
            this.doubleTrackBar1.ValueRight = 7;
            this.doubleTrackBar1.LeftValueChanged += new System.EventHandler(this.doubleTrackBar1_LeftValueChanged);
            this.doubleTrackBar1.RightValueChanged += new System.EventHandler(this.doubleTrackBar1_RightValueChanged);
            // 
            // lblEnabled
            // 
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lblEnabled.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnabled.ForeColor = System.Drawing.Color.Black;
            this.lblEnabled.Location = new System.Drawing.Point(320, 162);
            this.lblEnabled.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(55, 17);
            this.lblEnabled.TabIndex = 20;
            this.lblEnabled.Text = "Enabled";
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(473, 232);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "info.png";
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(455, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 28);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "info.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(497, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEnabled);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.doubleTrackBar1);
            this.Controls.Add(this.lblValueRight);
            this.Controls.Add(this.lblValueLeft);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(513, 439);
            this.MinimumSize = new System.Drawing.Size(513, 439);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battery Charge Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBatteryStatus)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem minimizeMaximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblBatteryStatus;
        private System.Windows.Forms.PictureBox pbBatteryStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblEstimatedTimeRemaining;
        private System.Windows.Forms.Label lblEstimatedTimeRemainingValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblValueLeft;
        private System.Windows.Forms.Label lblValueRight;
        private DoubleTrackBar.DoubleTrackBar doubleTrackBar1;
        private ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.Label lblEnabled;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

