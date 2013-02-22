namespace Dungeon_Teller
{
    partial class DungeonTeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DungeonTeller));
            this.timerMemoryRead = new System.Windows.Forms.Timer(this.components);
            this.lbl_LFDStatus = new System.Windows.Forms.Label();
            this.lbl_LFRStatus = new System.Windows.Forms.Label();
            this.grbx_Main = new System.Windows.Forms.GroupBox();
            this.lbl_BG2Status = new System.Windows.Forms.Label();
            this.lbl_BG1Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerAntiAFK = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_options = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.grbx_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMemoryRead
            // 
            this.timerMemoryRead.Interval = 250;
            this.timerMemoryRead.Tick += new System.EventHandler(this.timerMemoryRead_Tick);
            // 
            // lbl_LFDStatus
            // 
            this.lbl_LFDStatus.AutoSize = true;
            this.lbl_LFDStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LFDStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_LFDStatus.Location = new System.Drawing.Point(257, 16);
            this.lbl_LFDStatus.Name = "lbl_LFDStatus";
            this.lbl_LFDStatus.Size = new System.Drawing.Size(90, 20);
            this.lbl_LFDStatus.TabIndex = 5;
            this.lbl_LFDStatus.Text = "not queued";
            // 
            // lbl_LFRStatus
            // 
            this.lbl_LFRStatus.AutoSize = true;
            this.lbl_LFRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LFRStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_LFRStatus.Location = new System.Drawing.Point(257, 45);
            this.lbl_LFRStatus.Name = "lbl_LFRStatus";
            this.lbl_LFRStatus.Size = new System.Drawing.Size(90, 20);
            this.lbl_LFRStatus.TabIndex = 6;
            this.lbl_LFRStatus.Text = "not queued";
            // 
            // grbx_Main
            // 
            this.grbx_Main.Controls.Add(this.lbl_BG2Status);
            this.grbx_Main.Controls.Add(this.lbl_BG1Status);
            this.grbx_Main.Controls.Add(this.label3);
            this.grbx_Main.Controls.Add(this.label2);
            this.grbx_Main.Controls.Add(this.label4);
            this.grbx_Main.Controls.Add(this.pictureBox1);
            this.grbx_Main.Controls.Add(this.label1);
            this.grbx_Main.Controls.Add(this.lbl_LFRStatus);
            this.grbx_Main.Controls.Add(this.lbl_LFDStatus);
            this.grbx_Main.Location = new System.Drawing.Point(12, 3);
            this.grbx_Main.Name = "grbx_Main";
            this.grbx_Main.Size = new System.Drawing.Size(356, 137);
            this.grbx_Main.TabIndex = 5;
            this.grbx_Main.TabStop = false;
            this.grbx_Main.Text = "Queue Status";
            // 
            // lbl_BG2Status
            // 
            this.lbl_BG2Status.AutoSize = true;
            this.lbl_BG2Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BG2Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_BG2Status.Location = new System.Drawing.Point(257, 103);
            this.lbl_BG2Status.Name = "lbl_BG2Status";
            this.lbl_BG2Status.Size = new System.Drawing.Size(90, 20);
            this.lbl_BG2Status.TabIndex = 12;
            this.lbl_BG2Status.Text = "not queued";
            // 
            // lbl_BG1Status
            // 
            this.lbl_BG1Status.AutoSize = true;
            this.lbl_BG1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BG1Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_BG1Status.Location = new System.Drawing.Point(257, 74);
            this.lbl_BG1Status.Name = "lbl_BG1Status";
            this.lbl_BG1Status.Size = new System.Drawing.Size(90, 20);
            this.lbl_BG1Status.TabIndex = 11;
            this.lbl_BG1Status.Text = "not queued";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Battleground 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Raid Finder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Battleground 1:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dungeon_Teller.Properties.Resources.NotInQueue;
            this.pictureBox1.Location = new System.Drawing.Point(21, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dungeon Finder:";
            // 
            // timerAntiAFK
            // 
            this.timerAntiAFK.Interval = 30000;
            this.timerAntiAFK.Tick += new System.EventHandler(this.timer_antiAFK_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Dungeon Teller is now in tray.";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Dungeon Teller";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Restore,
            this.optionsToolStripMenuItem,
            this.Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 70);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // Restore
            // 
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(116, 22);
            this.Restore.Text = "Restore";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 22);
            this.Exit.Text = "Exit";
            // 
            // lnk_options
            // 
            this.lnk_options.AutoSize = true;
            this.lnk_options.Location = new System.Drawing.Point(12, 143);
            this.lnk_options.Name = "lnk_options";
            this.lnk_options.Size = new System.Drawing.Size(43, 13);
            this.lnk_options.TabIndex = 6;
            this.lnk_options.TabStop = true;
            this.lnk_options.Text = "Options";
            this.lnk_options.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_options_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DungeonTeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 164);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnk_options);
            this.Controls.Add(this.grbx_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DungeonTeller";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dungeon Teller";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DungeonTeller_FormClosing);
            this.Load += new System.EventHandler(this.DungeonTeller_Load);
            this.Shown += new System.EventHandler(this.DungeonTeller_Shown);
            this.LocationChanged += new System.EventHandler(this.DungeonTeller_LocationChanged);
            this.Resize += new System.EventHandler(this.DungeonTeller_Resize);
            this.grbx_Main.ResumeLayout(false);
            this.grbx_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMemoryRead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_LFDStatus;
        private System.Windows.Forms.Label lbl_LFRStatus;
        private System.Windows.Forms.GroupBox grbx_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerAntiAFK;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Restore;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.LinkLabel lnk_options;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label lbl_BG2Status;
        private System.Windows.Forms.Label lbl_BG1Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;

    }
}