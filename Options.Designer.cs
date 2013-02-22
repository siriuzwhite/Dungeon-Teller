namespace Dungeon_Teller
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_autoSelect = new System.Windows.Forms.CheckBox();
            this.cb_trayOnly = new System.Windows.Forms.CheckBox();
            this.num_opacity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_lockWindow = new System.Windows.Forms.CheckBox();
            this.cb_bringToFront = new System.Windows.Forms.CheckBox();
            this.cb_sound = new System.Windows.Forms.CheckBox();
            this.cb_balloonTips = new System.Windows.Forms.CheckBox();
            this.cb_desktopNotification = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_mailTest = new System.Windows.Forms.Button();
            this.btn_pushOverTest = new System.Windows.Forms.Button();
            this.tb_mailTo = new System.Windows.Forms.TextBox();
            this.lnk_pushOver = new System.Windows.Forms.LinkLabel();
            this.lbl_mailAddress = new System.Windows.Forms.Label();
            this.tb_pushOverUserKey = new System.Windows.Forms.TextBox();
            this.cb_mailNotification = new System.Windows.Forms.CheckBox();
            this.lbl_nma = new System.Windows.Forms.Label();
            this.cb_pushOver = new System.Windows.Forms.CheckBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cb_antiAfk = new System.Windows.Forms.CheckBox();
            this.cb_autoJoin = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_pauseFocus = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_opacity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(313, 316);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Enabled = false;
            this.btn_apply.Location = new System.Drawing.Point(475, 316);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 11;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(394, 316);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_pauseFocus);
            this.groupBox1.Controls.Add(this.cb_autoSelect);
            this.groupBox1.Controls.Add(this.cb_trayOnly);
            this.groupBox1.Controls.Add(this.num_opacity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_lockWindow);
            this.groupBox1.Location = new System.Drawing.Point(340, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 176);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General options";
            // 
            // cb_autoSelect
            // 
            this.cb_autoSelect.AutoSize = true;
            this.cb_autoSelect.Location = new System.Drawing.Point(15, 65);
            this.cb_autoSelect.Name = "cb_autoSelect";
            this.cb_autoSelect.Size = new System.Drawing.Size(150, 17);
            this.cb_autoSelect.TabIndex = 21;
            this.cb_autoSelect.Text = "Auto select WoW process";
            this.toolTip1.SetToolTip(this.cb_autoSelect, "If checked the first WoW process found will be selected automatically at startup");
            this.cb_autoSelect.UseVisualStyleBackColor = true;
            // 
            // cb_trayOnly
            // 
            this.cb_trayOnly.AutoSize = true;
            this.cb_trayOnly.Location = new System.Drawing.Point(15, 19);
            this.cb_trayOnly.Name = "cb_trayOnly";
            this.cb_trayOnly.Size = new System.Drawing.Size(78, 17);
            this.cb_trayOnly.TabIndex = 20;
            this.cb_trayOnly.Text = "Stay in tray";
            this.toolTip1.SetToolTip(this.cb_trayOnly, "If checked the main window will stay in tray");
            this.cb_trayOnly.UseVisualStyleBackColor = true;
            // 
            // num_opacity
            // 
            this.num_opacity.Location = new System.Drawing.Point(14, 136);
            this.num_opacity.Name = "num_opacity";
            this.num_opacity.Size = new System.Drawing.Size(85, 20);
            this.num_opacity.TabIndex = 18;
            this.num_opacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Main window opacity:";
            // 
            // cb_lockWindow
            // 
            this.cb_lockWindow.AutoSize = true;
            this.cb_lockWindow.Checked = true;
            this.cb_lockWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_lockWindow.Location = new System.Drawing.Point(15, 42);
            this.cb_lockWindow.Name = "cb_lockWindow";
            this.cb_lockWindow.Size = new System.Drawing.Size(159, 17);
            this.cb_lockWindow.TabIndex = 12;
            this.cb_lockWindow.Text = "Lock window to bottom right";
            this.toolTip1.SetToolTip(this.cb_lockWindow, "If checked the main window is locked to the bottom right corner of your desktop");
            this.cb_lockWindow.UseVisualStyleBackColor = true;
            // 
            // cb_bringToFront
            // 
            this.cb_bringToFront.AutoSize = true;
            this.cb_bringToFront.Location = new System.Drawing.Point(15, 88);
            this.cb_bringToFront.Name = "cb_bringToFront";
            this.cb_bringToFront.Size = new System.Drawing.Size(117, 17);
            this.cb_bringToFront.TabIndex = 22;
            this.cb_bringToFront.Text = "Bring WoW to front";
            this.toolTip1.SetToolTip(this.cb_bringToFront, "If checked WoW is made in foreground when a queue is ready");
            this.cb_bringToFront.UseVisualStyleBackColor = true;
            // 
            // cb_sound
            // 
            this.cb_sound.AutoSize = true;
            this.cb_sound.Checked = true;
            this.cb_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_sound.Location = new System.Drawing.Point(15, 42);
            this.cb_sound.Name = "cb_sound";
            this.cb_sound.Size = new System.Drawing.Size(96, 17);
            this.cb_sound.TabIndex = 19;
            this.cb_sound.Text = "Enable sounds";
            this.toolTip1.SetToolTip(this.cb_sound, "If checked a sound will be played when a queue is ready");
            this.cb_sound.UseVisualStyleBackColor = true;
            // 
            // cb_balloonTips
            // 
            this.cb_balloonTips.AutoSize = true;
            this.cb_balloonTips.Checked = true;
            this.cb_balloonTips.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_balloonTips.Location = new System.Drawing.Point(15, 65);
            this.cb_balloonTips.Name = "cb_balloonTips";
            this.cb_balloonTips.Size = new System.Drawing.Size(115, 17);
            this.cb_balloonTips.TabIndex = 11;
            this.cb_balloonTips.Text = "Enable balloon tips";
            this.toolTip1.SetToolTip(this.cb_balloonTips, "If checked balloont tips will inform you about different queue events");
            this.cb_balloonTips.UseVisualStyleBackColor = true;
            // 
            // cb_desktopNotification
            // 
            this.cb_desktopNotification.AutoSize = true;
            this.cb_desktopNotification.Checked = true;
            this.cb_desktopNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_desktopNotification.Location = new System.Drawing.Point(15, 19);
            this.cb_desktopNotification.Name = "cb_desktopNotification";
            this.cb_desktopNotification.Size = new System.Drawing.Size(165, 17);
            this.cb_desktopNotification.TabIndex = 10;
            this.cb_desktopNotification.Text = "Enbable desktop notifications";
            this.toolTip1.SetToolTip(this.cb_desktopNotification, "If checked a message box is shown when a queue is ready");
            this.cb_desktopNotification.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_bringToFront);
            this.groupBox2.Controls.Add(this.btn_mailTest);
            this.groupBox2.Controls.Add(this.btn_pushOverTest);
            this.groupBox2.Controls.Add(this.tb_mailTo);
            this.groupBox2.Controls.Add(this.cb_sound);
            this.groupBox2.Controls.Add(this.lnk_pushOver);
            this.groupBox2.Controls.Add(this.lbl_mailAddress);
            this.groupBox2.Controls.Add(this.cb_balloonTips);
            this.groupBox2.Controls.Add(this.tb_pushOverUserKey);
            this.groupBox2.Controls.Add(this.cb_mailNotification);
            this.groupBox2.Controls.Add(this.lbl_nma);
            this.groupBox2.Controls.Add(this.cb_desktopNotification);
            this.groupBox2.Controls.Add(this.cb_pushOver);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 289);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notification options";
            // 
            // btn_mailTest
            // 
            this.btn_mailTest.Enabled = false;
            this.btn_mailTest.Location = new System.Drawing.Point(229, 246);
            this.btn_mailTest.Name = "btn_mailTest";
            this.btn_mailTest.Size = new System.Drawing.Size(75, 23);
            this.btn_mailTest.TabIndex = 18;
            this.btn_mailTest.Text = "Test";
            this.toolTip1.SetToolTip(this.btn_mailTest, "Send a test mail to the given address");
            this.btn_mailTest.UseVisualStyleBackColor = true;
            this.btn_mailTest.Click += new System.EventHandler(this.btn_mailTest_Click);
            // 
            // btn_pushOverTest
            // 
            this.btn_pushOverTest.Enabled = false;
            this.btn_pushOverTest.Location = new System.Drawing.Point(229, 154);
            this.btn_pushOverTest.Name = "btn_pushOverTest";
            this.btn_pushOverTest.Size = new System.Drawing.Size(75, 23);
            this.btn_pushOverTest.TabIndex = 8;
            this.btn_pushOverTest.Text = "Test";
            this.toolTip1.SetToolTip(this.btn_pushOverTest, "Send a test push message with the given NMA API key");
            this.btn_pushOverTest.UseVisualStyleBackColor = true;
            this.btn_pushOverTest.Click += new System.EventHandler(this.btn_nmaTest_Click);
            // 
            // tb_mailTo
            // 
            this.tb_mailTo.Enabled = false;
            this.tb_mailTo.Location = new System.Drawing.Point(29, 248);
            this.tb_mailTo.Name = "tb_mailTo";
            this.tb_mailTo.Size = new System.Drawing.Size(194, 20);
            this.tb_mailTo.TabIndex = 2;
            // 
            // lnk_pushOver
            // 
            this.lnk_pushOver.AutoSize = true;
            this.lnk_pushOver.Enabled = false;
            this.lnk_pushOver.Location = new System.Drawing.Point(29, 183);
            this.lnk_pushOver.Name = "lnk_pushOver";
            this.lnk_pushOver.Size = new System.Drawing.Size(138, 13);
            this.lnk_pushOver.TabIndex = 5;
            this.lnk_pushOver.TabStop = true;
            this.lnk_pushOver.Text = "Get your Pushover user key";
            this.lnk_pushOver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_nma_LinkClicked);
            // 
            // lbl_mailAddress
            // 
            this.lbl_mailAddress.AutoSize = true;
            this.lbl_mailAddress.Enabled = false;
            this.lbl_mailAddress.Location = new System.Drawing.Point(29, 232);
            this.lbl_mailAddress.Name = "lbl_mailAddress";
            this.lbl_mailAddress.Size = new System.Drawing.Size(69, 13);
            this.lbl_mailAddress.TabIndex = 1;
            this.lbl_mailAddress.Text = "Mail address:";
            // 
            // tb_pushOverUserKey
            // 
            this.tb_pushOverUserKey.Enabled = false;
            this.tb_pushOverUserKey.Location = new System.Drawing.Point(29, 156);
            this.tb_pushOverUserKey.Name = "tb_pushOverUserKey";
            this.tb_pushOverUserKey.Size = new System.Drawing.Size(194, 20);
            this.tb_pushOverUserKey.TabIndex = 2;
            // 
            // cb_mailNotification
            // 
            this.cb_mailNotification.AutoSize = true;
            this.cb_mailNotification.Location = new System.Drawing.Point(15, 211);
            this.cb_mailNotification.Name = "cb_mailNotification";
            this.cb_mailNotification.Size = new System.Drawing.Size(137, 17);
            this.cb_mailNotification.TabIndex = 0;
            this.cb_mailNotification.Text = "Send E-Mail notification";
            this.toolTip1.SetToolTip(this.cb_mailNotification, "If checked a mail will be send to the given address when a queue is ready");
            this.cb_mailNotification.UseVisualStyleBackColor = true;
            this.cb_mailNotification.CheckedChanged += new System.EventHandler(this.cb_mail_CheckedChanged);
            // 
            // lbl_nma
            // 
            this.lbl_nma.AutoSize = true;
            this.lbl_nma.Enabled = false;
            this.lbl_nma.Location = new System.Drawing.Point(26, 140);
            this.lbl_nma.Name = "lbl_nma";
            this.lbl_nma.Size = new System.Drawing.Size(126, 13);
            this.lbl_nma.TabIndex = 1;
            this.lbl_nma.Text = "Your Pushover User Key:";
            // 
            // cb_pushOver
            // 
            this.cb_pushOver.AutoSize = true;
            this.cb_pushOver.Location = new System.Drawing.Point(15, 120);
            this.cb_pushOver.Name = "cb_pushOver";
            this.cb_pushOver.Size = new System.Drawing.Size(269, 17);
            this.cb_pushOver.TabIndex = 0;
            this.cb_pushOver.Text = "Send push notifications to your mobile via Pushover";
            this.toolTip1.SetToolTip(this.cb_pushOver, "If checked a push message will be send via Notify My Android to your mobile when " +
        "a queue is ready");
            this.cb_pushOver.UseVisualStyleBackColor = true;
            this.cb_pushOver.CheckedChanged += new System.EventHandler(this.cb_nma_CheckedChanged);
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(12, 316);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(119, 23);
            this.btn_restore.TabIndex = 19;
            this.btn_restore.Text = "Restore defaults";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // cb_antiAfk
            // 
            this.cb_antiAfk.AutoSize = true;
            this.cb_antiAfk.Checked = true;
            this.cb_antiAfk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_antiAfk.Location = new System.Drawing.Point(15, 23);
            this.cb_antiAfk.Name = "cb_antiAfk";
            this.cb_antiAfk.Size = new System.Drawing.Size(103, 17);
            this.cb_antiAfk.TabIndex = 10;
            this.cb_antiAfk.Text = "Enable Anti-AFK";
            this.toolTip1.SetToolTip(this.cb_antiAfk, "If checked Anti-AFK protection while in queue is enabled");
            this.cb_antiAfk.UseVisualStyleBackColor = true;
            // 
            // cb_autoJoin
            // 
            this.cb_autoJoin.AutoSize = true;
            this.cb_autoJoin.Checked = true;
            this.cb_autoJoin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_autoJoin.Location = new System.Drawing.Point(15, 46);
            this.cb_autoJoin.Name = "cb_autoJoin";
            this.cb_autoJoin.Size = new System.Drawing.Size(106, 17);
            this.cb_autoJoin.TabIndex = 11;
            this.cb_autoJoin.Text = "Enable Auto-Join";
            this.toolTip1.SetToolTip(this.cb_autoJoin, "If checked auto joining when a queue is ready is enabled");
            this.cb_autoJoin.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_antiAfk);
            this.groupBox3.Controls.Add(this.cb_autoJoin);
            this.groupBox3.Location = new System.Drawing.Point(340, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 106);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keyboard emulation options";
            // 
            // cb_pauseFocus
            // 
            this.cb_pauseFocus.AutoSize = true;
            this.cb_pauseFocus.Location = new System.Drawing.Point(15, 88);
            this.cb_pauseFocus.Name = "cb_pauseFocus";
            this.cb_pauseFocus.Size = new System.Drawing.Size(151, 17);
            this.cb_pauseFocus.TabIndex = 22;
            this.cb_pauseFocus.Text = "Pause when WoW in front";
            this.cb_pauseFocus.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 349);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.Text = "Dungeon Teller - Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_opacity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_pushOverUserKey;
        private System.Windows.Forms.Label lbl_nma;
        private System.Windows.Forms.CheckBox cb_pushOver;
        private System.Windows.Forms.CheckBox cb_lockWindow;
        private System.Windows.Forms.CheckBox cb_balloonTips;
        private System.Windows.Forms.CheckBox cb_desktopNotification;
        private System.Windows.Forms.Button btn_pushOverTest;
        private System.Windows.Forms.LinkLabel lnk_pushOver;
        private System.Windows.Forms.Button btn_mailTest;
        private System.Windows.Forms.TextBox tb_mailTo;
        private System.Windows.Forms.Label lbl_mailAddress;
        private System.Windows.Forms.CheckBox cb_mailNotification;
        private System.Windows.Forms.CheckBox cb_sound;
        private System.Windows.Forms.NumericUpDown num_opacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.CheckBox cb_trayOnly;
        private System.Windows.Forms.CheckBox cb_autoSelect;
        private System.Windows.Forms.CheckBox cb_bringToFront;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_antiAfk;
        private System.Windows.Forms.CheckBox cb_autoJoin;
        private System.Windows.Forms.CheckBox cb_pauseFocus;
    }
}