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
            this.timerAntiAFK = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_options = new System.Windows.Forms.LinkLabel();
            this.lbl_LfdDps = new System.Windows.Forms.Label();
            this.lbl_LfdHealer = new System.Windows.Forms.Label();
            this.lbl_LfdTank = new System.Windows.Forms.Label();
            this.pic_LfdTank = new System.Windows.Forms.PictureBox();
            this.pic_LfdHeal = new System.Windows.Forms.PictureBox();
            this.pic_LfdDps = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_BG2Status = new System.Windows.Forms.Label();
            this.lbl_BG1Status = new System.Windows.Forms.Label();
            this.lbl_LfrStatus = new System.Windows.Forms.Label();
            this.lbl_LfdStatus = new System.Windows.Forms.Label();
            this.gb_lfd = new System.Windows.Forms.GroupBox();
            this.lbl_LfdQueueTime = new System.Windows.Forms.Label();
            this.lbl_LfdWait = new System.Windows.Forms.Label();
            this.cgb_lfr = new System.Windows.Forms.GroupBox();
            this.lbl_LfrDps = new System.Windows.Forms.Label();
            this.pic_LfrHeal = new System.Windows.Forms.PictureBox();
            this.pic_LfrDps = new System.Windows.Forms.PictureBox();
            this.lbl_LfrHealer = new System.Windows.Forms.Label();
            this.pic_LfrTank = new System.Windows.Forms.PictureBox();
            this.lbl_LfrTank = new System.Windows.Forms.Label();
            this.lbl_LfrQueueTime = new System.Windows.Forms.Label();
            this.lbl_LfrWait = new System.Windows.Forms.Label();
            this.cgb_bg = new System.Windows.Forms.GroupBox();
            this.lbl_Bg2QueuedTime = new System.Windows.Forms.Label();
            this.lbl_Bg2Wait = new System.Windows.Forms.Label();
            this.lbl_Bg1QueuedTime = new System.Windows.Forms.Label();
            this.lbl_Bg1Wait = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timerLfdRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerLfrRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerBg1Refresh = new System.Windows.Forms.Timer(this.components);
            this.timerBg2Refresh = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfdTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfdHeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfdDps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_lfd.SuspendLayout();
            this.cgb_lfr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfrHeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfrDps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfrTank)).BeginInit();
            this.cgb_bg.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMemoryRead
            // 
            this.timerMemoryRead.Interval = 250;
            this.timerMemoryRead.Tick += new System.EventHandler(this.timerMemoryRead_Tick);
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
            this.lnk_options.Location = new System.Drawing.Point(3, 318);
            this.lnk_options.Name = "lnk_options";
            this.lnk_options.Size = new System.Drawing.Size(43, 13);
            this.lnk_options.TabIndex = 6;
            this.lnk_options.TabStop = true;
            this.lnk_options.Text = "Options";
            this.lnk_options.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_options_LinkClicked);
            // 
            // lbl_LfdDps
            // 
            this.lbl_LfdDps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LfdDps.Location = new System.Drawing.Point(422, 68);
            this.lbl_LfdDps.Name = "lbl_LfdDps";
            this.lbl_LfdDps.Size = new System.Drawing.Size(30, 13);
            this.lbl_LfdDps.TabIndex = 62;
            this.lbl_LfdDps.Text = "n/a";
            this.lbl_LfdDps.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_LfdHealer
            // 
            this.lbl_LfdHealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LfdHealer.Location = new System.Drawing.Point(373, 68);
            this.lbl_LfdHealer.Name = "lbl_LfdHealer";
            this.lbl_LfdHealer.Size = new System.Drawing.Size(32, 13);
            this.lbl_LfdHealer.TabIndex = 61;
            this.lbl_LfdHealer.Text = "n/a";
            this.lbl_LfdHealer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_LfdTank
            // 
            this.lbl_LfdTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LfdTank.Location = new System.Drawing.Point(326, 68);
            this.lbl_LfdTank.Name = "lbl_LfdTank";
            this.lbl_LfdTank.Size = new System.Drawing.Size(32, 13);
            this.lbl_LfdTank.TabIndex = 60;
            this.lbl_LfdTank.Text = "n/a";
            this.lbl_LfdTank.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pic_LfdTank
            // 
            this.pic_LfdTank.Image = global::Dungeon_Teller.Properties.Resources.role_tank_32x32;
            this.pic_LfdTank.Location = new System.Drawing.Point(326, 34);
            this.pic_LfdTank.Name = "pic_LfdTank";
            this.pic_LfdTank.Size = new System.Drawing.Size(32, 32);
            this.pic_LfdTank.TabIndex = 59;
            this.pic_LfdTank.TabStop = false;
            // 
            // pic_LfdHeal
            // 
            this.pic_LfdHeal.Image = global::Dungeon_Teller.Properties.Resources.role_heal_32x32;
            this.pic_LfdHeal.Location = new System.Drawing.Point(373, 34);
            this.pic_LfdHeal.Name = "pic_LfdHeal";
            this.pic_LfdHeal.Size = new System.Drawing.Size(32, 32);
            this.pic_LfdHeal.TabIndex = 58;
            this.pic_LfdHeal.TabStop = false;
            // 
            // pic_LfdDps
            // 
            this.pic_LfdDps.Image = global::Dungeon_Teller.Properties.Resources.role_dps_32x32;
            this.pic_LfdDps.Location = new System.Drawing.Point(420, 34);
            this.pic_LfdDps.Name = "pic_LfdDps";
            this.pic_LfdDps.Size = new System.Drawing.Size(32, 32);
            this.pic_LfdDps.TabIndex = 57;
            this.pic_LfdDps.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Avg. Wait:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Queued Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Avg. Wait:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Queued Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Status:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dungeon_Teller.Properties.Resources.pvp_finder_icon;
            this.pictureBox3.Location = new System.Drawing.Point(6, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dungeon_Teller.Properties.Resources.raid_finder_icon;
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dungeon_Teller.Properties.Resources.dungeon_finder_icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_BG2Status
            // 
            this.lbl_BG2Status.AutoSize = true;
            this.lbl_BG2Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_BG2Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_BG2Status.Location = new System.Drawing.Point(353, 19);
            this.lbl_BG2Status.Name = "lbl_BG2Status";
            this.lbl_BG2Status.Size = new System.Drawing.Size(80, 17);
            this.lbl_BG2Status.TabIndex = 41;
            this.lbl_BG2Status.Text = "not queued";
            // 
            // lbl_BG1Status
            // 
            this.lbl_BG1Status.AutoSize = true;
            this.lbl_BG1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_BG1Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_BG1Status.Location = new System.Drawing.Point(197, 19);
            this.lbl_BG1Status.Name = "lbl_BG1Status";
            this.lbl_BG1Status.Size = new System.Drawing.Size(80, 17);
            this.lbl_BG1Status.TabIndex = 40;
            this.lbl_BG1Status.Text = "not queued";
            // 
            // lbl_LfrStatus
            // 
            this.lbl_LfrStatus.AutoSize = true;
            this.lbl_LfrStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_LfrStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_LfrStatus.Location = new System.Drawing.Point(193, 16);
            this.lbl_LfrStatus.Name = "lbl_LfrStatus";
            this.lbl_LfrStatus.Size = new System.Drawing.Size(80, 17);
            this.lbl_LfrStatus.TabIndex = 39;
            this.lbl_LfrStatus.Text = "not queued";
            // 
            // lbl_LfdStatus
            // 
            this.lbl_LfdStatus.AutoSize = true;
            this.lbl_LfdStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_LfdStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_LfdStatus.Location = new System.Drawing.Point(193, 17);
            this.lbl_LfdStatus.Name = "lbl_LfdStatus";
            this.lbl_LfdStatus.Size = new System.Drawing.Size(80, 17);
            this.lbl_LfdStatus.TabIndex = 38;
            this.lbl_LfdStatus.Text = "not queued";
            // 
            // gb_lfd
            // 
            this.gb_lfd.Controls.Add(this.lbl_LfdQueueTime);
            this.gb_lfd.Controls.Add(this.lbl_LfdWait);
            this.gb_lfd.Controls.Add(this.pictureBox1);
            this.gb_lfd.Controls.Add(this.lbl_LfdDps);
            this.gb_lfd.Controls.Add(this.pic_LfdHeal);
            this.gb_lfd.Controls.Add(this.label3);
            this.gb_lfd.Controls.Add(this.lbl_LfdStatus);
            this.gb_lfd.Controls.Add(this.pic_LfdDps);
            this.gb_lfd.Controls.Add(this.lbl_LfdHealer);
            this.gb_lfd.Controls.Add(this.pic_LfdTank);
            this.gb_lfd.Controls.Add(this.label4);
            this.gb_lfd.Controls.Add(this.lbl_LfdTank);
            this.gb_lfd.Controls.Add(this.label1);
            this.gb_lfd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_lfd.Location = new System.Drawing.Point(3, 3);
            this.gb_lfd.Name = "gb_lfd";
            this.gb_lfd.Size = new System.Drawing.Size(465, 100);
            this.gb_lfd.TabIndex = 66;
            this.gb_lfd.TabStop = false;
            this.gb_lfd.Text = "Dungeon Finder";
            // 
            // lbl_LfdQueueTime
            // 
            this.lbl_LfdQueueTime.AutoSize = true;
            this.lbl_LfdQueueTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_LfdQueueTime.Location = new System.Drawing.Point(197, 66);
            this.lbl_LfdQueueTime.Name = "lbl_LfdQueueTime";
            this.lbl_LfdQueueTime.Size = new System.Drawing.Size(28, 17);
            this.lbl_LfdQueueTime.TabIndex = 64;
            this.lbl_LfdQueueTime.Text = "n/a";
            // 
            // lbl_LfdWait
            // 
            this.lbl_LfdWait.AutoSize = true;
            this.lbl_LfdWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_LfdWait.Location = new System.Drawing.Point(197, 41);
            this.lbl_LfdWait.Name = "lbl_LfdWait";
            this.lbl_LfdWait.Size = new System.Drawing.Size(28, 17);
            this.lbl_LfdWait.TabIndex = 63;
            this.lbl_LfdWait.Text = "n/a";
            // 
            // cgb_lfr
            // 
            this.cgb_lfr.Controls.Add(this.lbl_LfrDps);
            this.cgb_lfr.Controls.Add(this.pic_LfrHeal);
            this.cgb_lfr.Controls.Add(this.pic_LfrDps);
            this.cgb_lfr.Controls.Add(this.lbl_LfrHealer);
            this.cgb_lfr.Controls.Add(this.pic_LfrTank);
            this.cgb_lfr.Controls.Add(this.lbl_LfrTank);
            this.cgb_lfr.Controls.Add(this.lbl_LfrQueueTime);
            this.cgb_lfr.Controls.Add(this.lbl_LfrWait);
            this.cgb_lfr.Controls.Add(this.pictureBox2);
            this.cgb_lfr.Controls.Add(this.label2);
            this.cgb_lfr.Controls.Add(this.lbl_LfrStatus);
            this.cgb_lfr.Controls.Add(this.label6);
            this.cgb_lfr.Controls.Add(this.label5);
            this.cgb_lfr.Location = new System.Drawing.Point(3, 109);
            this.cgb_lfr.Name = "cgb_lfr";
            this.cgb_lfr.Size = new System.Drawing.Size(465, 100);
            this.cgb_lfr.TabIndex = 67;
            this.cgb_lfr.TabStop = false;
            this.cgb_lfr.Text = "Raid Finder";
            // 
            // lbl_LfrDps
            // 
            this.lbl_LfrDps.Location = new System.Drawing.Point(416, 70);
            this.lbl_LfrDps.Name = "lbl_LfrDps";
            this.lbl_LfrDps.Size = new System.Drawing.Size(39, 13);
            this.lbl_LfrDps.TabIndex = 68;
            this.lbl_LfrDps.Text = "n/a";
            this.lbl_LfrDps.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pic_LfrHeal
            // 
            this.pic_LfrHeal.Image = global::Dungeon_Teller.Properties.Resources.role_heal_32x32;
            this.pic_LfrHeal.Location = new System.Drawing.Point(373, 35);
            this.pic_LfrHeal.Name = "pic_LfrHeal";
            this.pic_LfrHeal.Size = new System.Drawing.Size(32, 32);
            this.pic_LfrHeal.TabIndex = 64;
            this.pic_LfrHeal.TabStop = false;
            // 
            // pic_LfrDps
            // 
            this.pic_LfrDps.Image = global::Dungeon_Teller.Properties.Resources.role_dps_32x32;
            this.pic_LfrDps.Location = new System.Drawing.Point(420, 35);
            this.pic_LfrDps.Name = "pic_LfrDps";
            this.pic_LfrDps.Size = new System.Drawing.Size(32, 32);
            this.pic_LfrDps.TabIndex = 63;
            this.pic_LfrDps.TabStop = false;
            // 
            // lbl_LfrHealer
            // 
            this.lbl_LfrHealer.Location = new System.Drawing.Point(373, 70);
            this.lbl_LfrHealer.Name = "lbl_LfrHealer";
            this.lbl_LfrHealer.Size = new System.Drawing.Size(32, 13);
            this.lbl_LfrHealer.TabIndex = 67;
            this.lbl_LfrHealer.Text = "n/a";
            this.lbl_LfrHealer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pic_LfrTank
            // 
            this.pic_LfrTank.Image = global::Dungeon_Teller.Properties.Resources.role_tank_32x32;
            this.pic_LfrTank.Location = new System.Drawing.Point(326, 36);
            this.pic_LfrTank.Name = "pic_LfrTank";
            this.pic_LfrTank.Size = new System.Drawing.Size(32, 32);
            this.pic_LfrTank.TabIndex = 65;
            this.pic_LfrTank.TabStop = false;
            // 
            // lbl_LfrTank
            // 
            this.lbl_LfrTank.Location = new System.Drawing.Point(326, 71);
            this.lbl_LfrTank.Name = "lbl_LfrTank";
            this.lbl_LfrTank.Size = new System.Drawing.Size(32, 13);
            this.lbl_LfrTank.TabIndex = 66;
            this.lbl_LfrTank.Text = "n/a";
            this.lbl_LfrTank.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_LfrQueueTime
            // 
            this.lbl_LfrQueueTime.AutoSize = true;
            this.lbl_LfrQueueTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_LfrQueueTime.Location = new System.Drawing.Point(193, 67);
            this.lbl_LfrQueueTime.Name = "lbl_LfrQueueTime";
            this.lbl_LfrQueueTime.Size = new System.Drawing.Size(28, 17);
            this.lbl_LfrQueueTime.TabIndex = 58;
            this.lbl_LfrQueueTime.Text = "n/a";
            // 
            // lbl_LfrWait
            // 
            this.lbl_LfrWait.AutoSize = true;
            this.lbl_LfrWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_LfrWait.Location = new System.Drawing.Point(193, 43);
            this.lbl_LfrWait.Name = "lbl_LfrWait";
            this.lbl_LfrWait.Size = new System.Drawing.Size(28, 17);
            this.lbl_LfrWait.TabIndex = 57;
            this.lbl_LfrWait.Text = "n/a";
            // 
            // cgb_bg
            // 
            this.cgb_bg.Controls.Add(this.lbl_Bg2QueuedTime);
            this.cgb_bg.Controls.Add(this.lbl_Bg2Wait);
            this.cgb_bg.Controls.Add(this.lbl_Bg1QueuedTime);
            this.cgb_bg.Controls.Add(this.lbl_Bg1Wait);
            this.cgb_bg.Controls.Add(this.label10);
            this.cgb_bg.Controls.Add(this.label11);
            this.cgb_bg.Controls.Add(this.label12);
            this.cgb_bg.Controls.Add(this.pictureBox3);
            this.cgb_bg.Controls.Add(this.lbl_BG2Status);
            this.cgb_bg.Controls.Add(this.lbl_BG1Status);
            this.cgb_bg.Location = new System.Drawing.Point(3, 215);
            this.cgb_bg.Name = "cgb_bg";
            this.cgb_bg.Size = new System.Drawing.Size(465, 100);
            this.cgb_bg.TabIndex = 68;
            this.cgb_bg.TabStop = false;
            this.cgb_bg.Text = "Battleground";
            // 
            // lbl_Bg2QueuedTime
            // 
            this.lbl_Bg2QueuedTime.AutoSize = true;
            this.lbl_Bg2QueuedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Bg2QueuedTime.Location = new System.Drawing.Point(353, 65);
            this.lbl_Bg2QueuedTime.Name = "lbl_Bg2QueuedTime";
            this.lbl_Bg2QueuedTime.Size = new System.Drawing.Size(28, 17);
            this.lbl_Bg2QueuedTime.TabIndex = 68;
            this.lbl_Bg2QueuedTime.Text = "n/a";
            // 
            // lbl_Bg2Wait
            // 
            this.lbl_Bg2Wait.AutoSize = true;
            this.lbl_Bg2Wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Bg2Wait.Location = new System.Drawing.Point(353, 43);
            this.lbl_Bg2Wait.Name = "lbl_Bg2Wait";
            this.lbl_Bg2Wait.Size = new System.Drawing.Size(28, 17);
            this.lbl_Bg2Wait.TabIndex = 67;
            this.lbl_Bg2Wait.Text = "n/a";
            // 
            // lbl_Bg1QueuedTime
            // 
            this.lbl_Bg1QueuedTime.AutoSize = true;
            this.lbl_Bg1QueuedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Bg1QueuedTime.Location = new System.Drawing.Point(197, 65);
            this.lbl_Bg1QueuedTime.Name = "lbl_Bg1QueuedTime";
            this.lbl_Bg1QueuedTime.Size = new System.Drawing.Size(28, 17);
            this.lbl_Bg1QueuedTime.TabIndex = 66;
            this.lbl_Bg1QueuedTime.Text = "n/a";
            // 
            // lbl_Bg1Wait
            // 
            this.lbl_Bg1Wait.AutoSize = true;
            this.lbl_Bg1Wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Bg1Wait.Location = new System.Drawing.Point(197, 43);
            this.lbl_Bg1Wait.Name = "lbl_Bg1Wait";
            this.lbl_Bg1Wait.Size = new System.Drawing.Size(28, 17);
            this.lbl_Bg1Wait.TabIndex = 65;
            this.lbl_Bg1Wait.Text = "n/a";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(76, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Avg. Wait:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(76, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Queued Time:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.gb_lfd);
            this.flowLayoutPanel1.Controls.Add(this.cgb_lfr);
            this.flowLayoutPanel1.Controls.Add(this.cgb_bg);
            this.flowLayoutPanel1.Controls.Add(this.lnk_options);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(471, 331);
            this.flowLayoutPanel1.TabIndex = 69;
            // 
            // timerLfdRefresh
            // 
            this.timerLfdRefresh.Interval = 1000;
            this.timerLfdRefresh.Tick += new System.EventHandler(this.timerLFDRefresh_Tick);
            // 
            // timerLfrRefresh
            // 
            this.timerLfrRefresh.Interval = 1000;
            this.timerLfrRefresh.Tick += new System.EventHandler(this.timerLfrRefresh_Tick);
            // 
            // timerBg1Refresh
            // 
            this.timerBg1Refresh.Interval = 1000;
            this.timerBg1Refresh.Tick += new System.EventHandler(this.timerBg1Refresh_Tick);
            // 
            // timerBg2Refresh
            // 
            this.timerBg2Refresh.Interval = 1000;
            this.timerBg2Refresh.Tick += new System.EventHandler(this.timerBg2Refresh_Tick);
            // 
            // DungeonTeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(483, 341);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.SizeChanged += new System.EventHandler(this.DungeonTeller_SizeChanged);
            this.Resize += new System.EventHandler(this.DungeonTeller_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfdTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfdHeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfdDps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_lfd.ResumeLayout(false);
            this.gb_lfd.PerformLayout();
            this.cgb_lfr.ResumeLayout(false);
            this.cgb_lfr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfrHeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfrDps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LfrTank)).EndInit();
            this.cgb_bg.ResumeLayout(false);
            this.cgb_bg.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMemoryRead;
        private System.Windows.Forms.Timer timerAntiAFK;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Restore;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.LinkLabel lnk_options;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label lbl_LfdDps;
        private System.Windows.Forms.Label lbl_LfdHealer;
        private System.Windows.Forms.Label lbl_LfdTank;
        private System.Windows.Forms.PictureBox pic_LfdTank;
        private System.Windows.Forms.PictureBox pic_LfdHeal;
        private System.Windows.Forms.PictureBox pic_LfdDps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_BG2Status;
        private System.Windows.Forms.Label lbl_BG1Status;
        private System.Windows.Forms.Label lbl_LfrStatus;
        private System.Windows.Forms.Label lbl_LfdStatus;
        private System.Windows.Forms.GroupBox gb_lfd;
        private System.Windows.Forms.GroupBox cgb_lfr;
        private System.Windows.Forms.GroupBox cgb_bg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timerLfdRefresh;
        private System.Windows.Forms.Label lbl_LfdQueueTime;
        private System.Windows.Forms.Label lbl_LfdWait;
        private System.Windows.Forms.Label lbl_LfrQueueTime;
        private System.Windows.Forms.Label lbl_LfrWait;
        private System.Windows.Forms.Label lbl_Bg2QueuedTime;
        private System.Windows.Forms.Label lbl_Bg2Wait;
        private System.Windows.Forms.Label lbl_Bg1QueuedTime;
        private System.Windows.Forms.Label lbl_Bg1Wait;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_LfrDps;
        private System.Windows.Forms.PictureBox pic_LfrHeal;
        private System.Windows.Forms.PictureBox pic_LfrDps;
        private System.Windows.Forms.Label lbl_LfrHealer;
        private System.Windows.Forms.PictureBox pic_LfrTank;
        private System.Windows.Forms.Label lbl_LfrTank;
        private System.Windows.Forms.Timer timerLfrRefresh;
        private System.Windows.Forms.Timer timerBg1Refresh;
        private System.Windows.Forms.Timer timerBg2Refresh;

    }
}