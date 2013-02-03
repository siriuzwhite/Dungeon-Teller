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
            this.cb_autoJoin = new System.Windows.Forms.CheckBox();
            this.cb_antiAfk = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_sound = new System.Windows.Forms.CheckBox();
            this.num_opacity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_windowTray = new System.Windows.Forms.RadioButton();
            this.rb_windowTop = new System.Windows.Forms.RadioButton();
            this.rb_windowNormal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_lockWindow = new System.Windows.Forms.CheckBox();
            this.cb_balloonTips = new System.Windows.Forms.CheckBox();
            this.cb_desktopNotification = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_prowlTest = new System.Windows.Forms.Button();
            this.btn_nmaTest = new System.Windows.Forms.Button();
            this.lnk_prowl = new System.Windows.Forms.LinkLabel();
            this.tb_prowl = new System.Windows.Forms.TextBox();
            this.lnk_nma = new System.Windows.Forms.LinkLabel();
            this.lbl_prowl = new System.Windows.Forms.Label();
            this.cb_prowlNotification = new System.Windows.Forms.CheckBox();
            this.tb_nma = new System.Windows.Forms.TextBox();
            this.lbl_nma = new System.Windows.Forms.Label();
            this.cb_nmaNotification = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_mailTest = new System.Windows.Forms.Button();
            this.tb_mailSMTP = new System.Windows.Forms.TextBox();
            this.lbl_mailSMTP = new System.Windows.Forms.Label();
            this.tb_mailTo = new System.Windows.Forms.TextBox();
            this.lbl_mailAddress = new System.Windows.Forms.Label();
            this.cb_mailNotification = new System.Windows.Forms.CheckBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_opacity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_autoJoin
            // 
            this.cb_autoJoin.AutoSize = true;
            this.cb_autoJoin.Checked = true;
            this.cb_autoJoin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_autoJoin.Location = new System.Drawing.Point(16, 42);
            this.cb_autoJoin.Name = "cb_autoJoin";
            this.cb_autoJoin.Size = new System.Drawing.Size(106, 17);
            this.cb_autoJoin.TabIndex = 9;
            this.cb_autoJoin.Text = "Enable Auto-Join";
            this.cb_autoJoin.UseVisualStyleBackColor = true;
            // 
            // cb_antiAfk
            // 
            this.cb_antiAfk.AutoSize = true;
            this.cb_antiAfk.Checked = true;
            this.cb_antiAfk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_antiAfk.Location = new System.Drawing.Point(16, 19);
            this.cb_antiAfk.Name = "cb_antiAfk";
            this.cb_antiAfk.Size = new System.Drawing.Size(103, 17);
            this.cb_antiAfk.TabIndex = 8;
            this.cb_antiAfk.Text = "Enable Anti-AFK";
            this.cb_antiAfk.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(313, 386);
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
            this.btn_apply.Location = new System.Drawing.Point(475, 386);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 11;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(394, 386);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_sound);
            this.groupBox1.Controls.Add(this.num_opacity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_windowTray);
            this.groupBox1.Controls.Add(this.rb_windowTop);
            this.groupBox1.Controls.Add(this.rb_windowNormal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_lockWindow);
            this.groupBox1.Controls.Add(this.cb_balloonTips);
            this.groupBox1.Controls.Add(this.cb_desktopNotification);
            this.groupBox1.Controls.Add(this.cb_antiAfk);
            this.groupBox1.Controls.Add(this.cb_autoJoin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 359);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General options";
            // 
            // cb_sound
            // 
            this.cb_sound.AutoSize = true;
            this.cb_sound.Checked = true;
            this.cb_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_sound.Location = new System.Drawing.Point(16, 88);
            this.cb_sound.Name = "cb_sound";
            this.cb_sound.Size = new System.Drawing.Size(96, 17);
            this.cb_sound.TabIndex = 19;
            this.cb_sound.Text = "Enable sounds";
            this.cb_sound.UseVisualStyleBackColor = true;
            // 
            // num_opacity
            // 
            this.num_opacity.Location = new System.Drawing.Point(26, 281);
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
            this.label2.Location = new System.Drawing.Point(8, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Opacity:";
            // 
            // rb_windowTray
            // 
            this.rb_windowTray.AutoSize = true;
            this.rb_windowTray.Location = new System.Drawing.Point(26, 239);
            this.rb_windowTray.Name = "rb_windowTray";
            this.rb_windowTray.Size = new System.Drawing.Size(88, 17);
            this.rb_windowTray.TabIndex = 16;
            this.rb_windowTray.Text = "always in tray";
            this.rb_windowTray.UseVisualStyleBackColor = true;
            // 
            // rb_windowTop
            // 
            this.rb_windowTop.AutoSize = true;
            this.rb_windowTop.Checked = true;
            this.rb_windowTop.Location = new System.Drawing.Point(26, 216);
            this.rb_windowTop.Name = "rb_windowTop";
            this.rb_windowTop.Size = new System.Drawing.Size(90, 17);
            this.rb_windowTop.TabIndex = 15;
            this.rb_windowTop.TabStop = true;
            this.rb_windowTop.Text = "always on top";
            this.rb_windowTop.UseVisualStyleBackColor = true;
            // 
            // rb_windowNormal
            // 
            this.rb_windowNormal.AutoSize = true;
            this.rb_windowNormal.Location = new System.Drawing.Point(26, 194);
            this.rb_windowNormal.Name = "rb_windowNormal";
            this.rb_windowNormal.Size = new System.Drawing.Size(56, 17);
            this.rb_windowNormal.TabIndex = 14;
            this.rb_windowNormal.Text = "normal";
            this.rb_windowNormal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Window preferences";
            // 
            // cb_lockWindow
            // 
            this.cb_lockWindow.AutoSize = true;
            this.cb_lockWindow.Checked = true;
            this.cb_lockWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_lockWindow.Location = new System.Drawing.Point(16, 307);
            this.cb_lockWindow.Name = "cb_lockWindow";
            this.cb_lockWindow.Size = new System.Drawing.Size(143, 17);
            this.cb_lockWindow.TabIndex = 12;
            this.cb_lockWindow.Text = "Lock application window";
            this.cb_lockWindow.UseVisualStyleBackColor = true;
            // 
            // cb_balloonTips
            // 
            this.cb_balloonTips.AutoSize = true;
            this.cb_balloonTips.Checked = true;
            this.cb_balloonTips.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_balloonTips.Location = new System.Drawing.Point(16, 135);
            this.cb_balloonTips.Name = "cb_balloonTips";
            this.cb_balloonTips.Size = new System.Drawing.Size(115, 17);
            this.cb_balloonTips.TabIndex = 11;
            this.cb_balloonTips.Text = "Enable balloon tips";
            this.cb_balloonTips.UseVisualStyleBackColor = true;
            // 
            // cb_desktopNotification
            // 
            this.cb_desktopNotification.AutoSize = true;
            this.cb_desktopNotification.Checked = true;
            this.cb_desktopNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_desktopNotification.Location = new System.Drawing.Point(16, 111);
            this.cb_desktopNotification.Name = "cb_desktopNotification";
            this.cb_desktopNotification.Size = new System.Drawing.Size(165, 17);
            this.cb_desktopNotification.TabIndex = 10;
            this.cb_desktopNotification.Text = "Enbable desktop notifications";
            this.cb_desktopNotification.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_prowlTest);
            this.groupBox2.Controls.Add(this.btn_nmaTest);
            this.groupBox2.Controls.Add(this.lnk_prowl);
            this.groupBox2.Controls.Add(this.tb_prowl);
            this.groupBox2.Controls.Add(this.lnk_nma);
            this.groupBox2.Controls.Add(this.lbl_prowl);
            this.groupBox2.Controls.Add(this.cb_prowlNotification);
            this.groupBox2.Controls.Add(this.tb_nma);
            this.groupBox2.Controls.Add(this.lbl_nma);
            this.groupBox2.Controls.Add(this.cb_nmaNotification);
            this.groupBox2.Location = new System.Drawing.Point(228, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 200);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Push notification options";
            // 
            // btn_prowlTest
            // 
            this.btn_prowlTest.Enabled = false;
            this.btn_prowlTest.Location = new System.Drawing.Point(224, 144);
            this.btn_prowlTest.Name = "btn_prowlTest";
            this.btn_prowlTest.Size = new System.Drawing.Size(75, 23);
            this.btn_prowlTest.TabIndex = 9;
            this.btn_prowlTest.Text = "Test";
            this.btn_prowlTest.UseVisualStyleBackColor = true;
            // 
            // btn_nmaTest
            // 
            this.btn_nmaTest.Enabled = false;
            this.btn_nmaTest.Location = new System.Drawing.Point(223, 53);
            this.btn_nmaTest.Name = "btn_nmaTest";
            this.btn_nmaTest.Size = new System.Drawing.Size(75, 23);
            this.btn_nmaTest.TabIndex = 8;
            this.btn_nmaTest.Text = "Test";
            this.btn_nmaTest.UseVisualStyleBackColor = true;
            this.btn_nmaTest.Click += new System.EventHandler(this.btn_nmaTest_Click);
            // 
            // lnk_prowl
            // 
            this.lnk_prowl.AutoSize = true;
            this.lnk_prowl.Enabled = false;
            this.lnk_prowl.Location = new System.Drawing.Point(41, 175);
            this.lnk_prowl.Name = "lnk_prowl";
            this.lnk_prowl.Size = new System.Drawing.Size(139, 13);
            this.lnk_prowl.TabIndex = 7;
            this.lnk_prowl.TabStop = true;
            this.lnk_prowl.Text = "Register for a Prowl API key";
            this.lnk_prowl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_prowl_LinkClicked);
            // 
            // tb_prowl
            // 
            this.tb_prowl.Enabled = false;
            this.tb_prowl.Location = new System.Drawing.Point(38, 148);
            this.tb_prowl.Name = "tb_prowl";
            this.tb_prowl.Size = new System.Drawing.Size(179, 20);
            this.tb_prowl.TabIndex = 6;
            // 
            // lnk_nma
            // 
            this.lnk_nma.AutoSize = true;
            this.lnk_nma.Enabled = false;
            this.lnk_nma.Location = new System.Drawing.Point(38, 82);
            this.lnk_nma.Name = "lnk_nma";
            this.lnk_nma.Size = new System.Drawing.Size(137, 13);
            this.lnk_nma.TabIndex = 5;
            this.lnk_nma.TabStop = true;
            this.lnk_nma.Text = "Register for a NMA API key";
            this.lnk_nma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_nma_LinkClicked);
            // 
            // lbl_prowl
            // 
            this.lbl_prowl.AutoSize = true;
            this.lbl_prowl.Enabled = false;
            this.lbl_prowl.Location = new System.Drawing.Point(35, 131);
            this.lbl_prowl.Name = "lbl_prowl";
            this.lbl_prowl.Size = new System.Drawing.Size(101, 13);
            this.lbl_prowl.TabIndex = 4;
            this.lbl_prowl.Text = "Your Prowl API key:";
            // 
            // cb_prowlNotification
            // 
            this.cb_prowlNotification.AutoSize = true;
            this.cb_prowlNotification.Location = new System.Drawing.Point(15, 111);
            this.cb_prowlNotification.Name = "cb_prowlNotification";
            this.cb_prowlNotification.Size = new System.Drawing.Size(185, 17);
            this.cb_prowlNotification.TabIndex = 3;
            this.cb_prowlNotification.Text = "Use iOS push notifications (Prowl)";
            this.cb_prowlNotification.UseVisualStyleBackColor = true;
            this.cb_prowlNotification.CheckedChanged += new System.EventHandler(this.cb_prowl_CheckedChanged);
            // 
            // tb_nma
            // 
            this.tb_nma.Enabled = false;
            this.tb_nma.Location = new System.Drawing.Point(38, 55);
            this.tb_nma.Name = "tb_nma";
            this.tb_nma.Size = new System.Drawing.Size(179, 20);
            this.tb_nma.TabIndex = 2;
            // 
            // lbl_nma
            // 
            this.lbl_nma.AutoSize = true;
            this.lbl_nma.Enabled = false;
            this.lbl_nma.Location = new System.Drawing.Point(35, 39);
            this.lbl_nma.Name = "lbl_nma";
            this.lbl_nma.Size = new System.Drawing.Size(99, 13);
            this.lbl_nma.TabIndex = 1;
            this.lbl_nma.Text = "Your NMA API key:";
            // 
            // cb_nmaNotification
            // 
            this.cb_nmaNotification.AutoSize = true;
            this.cb_nmaNotification.Location = new System.Drawing.Point(15, 19);
            this.cb_nmaNotification.Name = "cb_nmaNotification";
            this.cb_nmaNotification.Size = new System.Drawing.Size(202, 17);
            this.cb_nmaNotification.TabIndex = 0;
            this.cb_nmaNotification.Text = "Use Android push notifications (NMA)";
            this.cb_nmaNotification.UseVisualStyleBackColor = true;
            this.cb_nmaNotification.CheckedChanged += new System.EventHandler(this.cb_nma_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_mailTest);
            this.groupBox3.Controls.Add(this.tb_mailSMTP);
            this.groupBox3.Controls.Add(this.lbl_mailSMTP);
            this.groupBox3.Controls.Add(this.tb_mailTo);
            this.groupBox3.Controls.Add(this.lbl_mailAddress);
            this.groupBox3.Controls.Add(this.cb_mailNotification);
            this.groupBox3.Location = new System.Drawing.Point(228, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 153);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E-Mail natificatons";
            // 
            // btn_mailTest
            // 
            this.btn_mailTest.Enabled = false;
            this.btn_mailTest.Location = new System.Drawing.Point(223, 103);
            this.btn_mailTest.Name = "btn_mailTest";
            this.btn_mailTest.Size = new System.Drawing.Size(75, 23);
            this.btn_mailTest.TabIndex = 18;
            this.btn_mailTest.Text = "Test";
            this.btn_mailTest.UseVisualStyleBackColor = true;
            // 
            // tb_mailSMTP
            // 
            this.tb_mailSMTP.Enabled = false;
            this.tb_mailSMTP.Location = new System.Drawing.Point(38, 106);
            this.tb_mailSMTP.Name = "tb_mailSMTP";
            this.tb_mailSMTP.Size = new System.Drawing.Size(179, 20);
            this.tb_mailSMTP.TabIndex = 17;
            // 
            // lbl_mailSMTP
            // 
            this.lbl_mailSMTP.AutoSize = true;
            this.lbl_mailSMTP.Enabled = false;
            this.lbl_mailSMTP.Location = new System.Drawing.Point(38, 90);
            this.lbl_mailSMTP.Name = "lbl_mailSMTP";
            this.lbl_mailSMTP.Size = new System.Drawing.Size(133, 13);
            this.lbl_mailSMTP.TabIndex = 3;
            this.lbl_mailSMTP.Text = "SMTP Server (server:port):";
            // 
            // tb_mailTo
            // 
            this.tb_mailTo.Enabled = false;
            this.tb_mailTo.Location = new System.Drawing.Point(38, 58);
            this.tb_mailTo.Name = "tb_mailTo";
            this.tb_mailTo.Size = new System.Drawing.Size(179, 20);
            this.tb_mailTo.TabIndex = 2;
            // 
            // lbl_mailAddress
            // 
            this.lbl_mailAddress.AutoSize = true;
            this.lbl_mailAddress.Enabled = false;
            this.lbl_mailAddress.Location = new System.Drawing.Point(35, 42);
            this.lbl_mailAddress.Name = "lbl_mailAddress";
            this.lbl_mailAddress.Size = new System.Drawing.Size(69, 13);
            this.lbl_mailAddress.TabIndex = 1;
            this.lbl_mailAddress.Text = "Mail address:";
            // 
            // cb_mailNotification
            // 
            this.cb_mailNotification.AutoSize = true;
            this.cb_mailNotification.Location = new System.Drawing.Point(16, 22);
            this.cb_mailNotification.Name = "cb_mailNotification";
            this.cb_mailNotification.Size = new System.Drawing.Size(126, 17);
            this.cb_mailNotification.TabIndex = 0;
            this.cb_mailNotification.Text = "Send mail notification";
            this.cb_mailNotification.UseVisualStyleBackColor = true;
            this.cb_mailNotification.CheckedChanged += new System.EventHandler(this.cb_mail_CheckedChanged);
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(12, 386);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(119, 23);
            this.btn_restore.TabIndex = 19;
            this.btn_restore.Text = "Restore defaults";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 424);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.groupBox3);
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

        private System.Windows.Forms.CheckBox cb_autoJoin;
        private System.Windows.Forms.CheckBox cb_antiAfk;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_nma;
        private System.Windows.Forms.Label lbl_nma;
        private System.Windows.Forms.CheckBox cb_nmaNotification;
        private System.Windows.Forms.CheckBox cb_prowlNotification;
        private System.Windows.Forms.RadioButton rb_windowTray;
        private System.Windows.Forms.RadioButton rb_windowTop;
        private System.Windows.Forms.RadioButton rb_windowNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_lockWindow;
        private System.Windows.Forms.CheckBox cb_balloonTips;
        private System.Windows.Forms.CheckBox cb_desktopNotification;
        private System.Windows.Forms.Button btn_prowlTest;
        private System.Windows.Forms.Button btn_nmaTest;
        private System.Windows.Forms.LinkLabel lnk_prowl;
        private System.Windows.Forms.TextBox tb_prowl;
        private System.Windows.Forms.LinkLabel lnk_nma;
        private System.Windows.Forms.Label lbl_prowl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_mailTest;
        private System.Windows.Forms.TextBox tb_mailSMTP;
        private System.Windows.Forms.Label lbl_mailSMTP;
        private System.Windows.Forms.TextBox tb_mailTo;
        private System.Windows.Forms.Label lbl_mailAddress;
        private System.Windows.Forms.CheckBox cb_mailNotification;
        private System.Windows.Forms.CheckBox cb_sound;
        private System.Windows.Forms.NumericUpDown num_opacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_restore;
    }
}