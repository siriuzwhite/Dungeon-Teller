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
            this.Check = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_LFDStatus = new System.Windows.Forms.Label();
            this.lbl_LFRStatus = new System.Windows.Forms.Label();
            this.grbx_Main = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_antiAfk = new System.Windows.Forms.CheckBox();
            this.grbx_options = new System.Windows.Forms.GroupBox();
            this.cb_autoJoin = new System.Windows.Forms.CheckBox();
            this.timer_antiAFK = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbx_Main.SuspendLayout();
            this.grbx_options.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Tick += new System.EventHandler(this.Check_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dungeon_Teller.Properties.Resources.NotInQueue;
            this.pictureBox1.Location = new System.Drawing.Point(27, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_LFDStatus
            // 
            this.lbl_LFDStatus.AutoSize = true;
            this.lbl_LFDStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LFDStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_LFDStatus.Location = new System.Drawing.Point(259, 31);
            this.lbl_LFDStatus.Name = "lbl_LFDStatus";
            this.lbl_LFDStatus.Size = new System.Drawing.Size(91, 20);
            this.lbl_LFDStatus.TabIndex = 5;
            this.lbl_LFDStatus.Text = "LFD Status";
            // 
            // lbl_LFRStatus
            // 
            this.lbl_LFRStatus.AutoSize = true;
            this.lbl_LFRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LFRStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_LFRStatus.Location = new System.Drawing.Point(259, 64);
            this.lbl_LFRStatus.Name = "lbl_LFRStatus";
            this.lbl_LFRStatus.Size = new System.Drawing.Size(91, 20);
            this.lbl_LFRStatus.TabIndex = 6;
            this.lbl_LFRStatus.Text = "LFR Status";
            // 
            // grbx_Main
            // 
            this.grbx_Main.Controls.Add(this.label2);
            this.grbx_Main.Controls.Add(this.label1);
            this.grbx_Main.Controls.Add(this.lbl_LFRStatus);
            this.grbx_Main.Controls.Add(this.lbl_LFDStatus);
            this.grbx_Main.Controls.Add(this.pictureBox1);
            this.grbx_Main.Location = new System.Drawing.Point(2, 3);
            this.grbx_Main.Name = "grbx_Main";
            this.grbx_Main.Size = new System.Drawing.Size(370, 104);
            this.grbx_Main.TabIndex = 5;
            this.grbx_Main.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Raid Finder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dungeon Finder:";
            // 
            // cb_antiAfk
            // 
            this.cb_antiAfk.AutoSize = true;
            this.cb_antiAfk.Checked = true;
            this.cb_antiAfk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_antiAfk.Location = new System.Drawing.Point(78, 28);
            this.cb_antiAfk.Name = "cb_antiAfk";
            this.cb_antiAfk.Size = new System.Drawing.Size(67, 17);
            this.cb_antiAfk.TabIndex = 6;
            this.cb_antiAfk.Text = "Anti-AFK";
            this.toolTip1.SetToolTip(this.cb_antiAfk, "Check to eneble AntiAFK while in queue");
            this.cb_antiAfk.UseVisualStyleBackColor = true;
            // 
            // grbx_options
            // 
            this.grbx_options.Controls.Add(this.cb_autoJoin);
            this.grbx_options.Controls.Add(this.cb_antiAfk);
            this.grbx_options.Location = new System.Drawing.Point(5, 115);
            this.grbx_options.Name = "grbx_options";
            this.grbx_options.Size = new System.Drawing.Size(367, 63);
            this.grbx_options.TabIndex = 9;
            this.grbx_options.TabStop = false;
            this.grbx_options.Text = "Options";
            // 
            // cb_autoJoin
            // 
            this.cb_autoJoin.AutoSize = true;
            this.cb_autoJoin.Checked = true;
            this.cb_autoJoin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_autoJoin.Location = new System.Drawing.Point(214, 28);
            this.cb_autoJoin.Name = "cb_autoJoin";
            this.cb_autoJoin.Size = new System.Drawing.Size(70, 17);
            this.cb_autoJoin.TabIndex = 7;
            this.cb_autoJoin.Text = "Auto-Join";
            this.toolTip1.SetToolTip(this.cb_autoJoin, "Check to eneble autojoin when queue is ready");
            this.cb_autoJoin.UseVisualStyleBackColor = true;
            // 
            // timer_antiAFK
            // 
            this.timer_antiAFK.Interval = 30000;
            this.timer_antiAFK.Tick += new System.EventHandler(this.timer_antiAFK_Tick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
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
            this.Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // Restore
            // 
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(113, 22);
            this.Restore.Text = "Restore";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 22);
            this.Exit.Text = "Exit";
            // 
            // DungeonTeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 185);
            this.Controls.Add(this.grbx_Main);
            this.Controls.Add(this.grbx_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DungeonTeller";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dungeon Teller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DungeonTeller_FormClosing);
            this.Load += new System.EventHandler(this.DungeonTeller_Load);
            this.LocationChanged += new System.EventHandler(this.DungeonTeller_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.DungeonTeller_VisibleChanged);
            this.Resize += new System.EventHandler(this.DungeonTeller_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbx_Main.ResumeLayout(false);
            this.grbx_Main.PerformLayout();
            this.grbx_options.ResumeLayout(false);
            this.grbx_options.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Check;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_LFDStatus;
        private System.Windows.Forms.Label lbl_LFRStatus;
        private System.Windows.Forms.GroupBox grbx_Main;
        private System.Windows.Forms.CheckBox cb_antiAfk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbx_options;
        private System.Windows.Forms.Timer timer_antiAFK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.CheckBox cb_autoJoin;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Restore;
        private System.Windows.Forms.ToolStripMenuItem Exit;

    }
}