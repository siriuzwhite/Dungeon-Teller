using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dungeon_Teller
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            AddEvents(this.Controls);
        }

        Properties.Settings settings = Properties.Settings.Default;

        void AddEvents(System.Windows.Forms.Control.ControlCollection Controls)
        {
            foreach (Control c in Controls)
            {
                if (c is GroupBox)
                {
                    AddEvents(((GroupBox)c).Controls);
                }
                else if (c is Panel)
                {
                    AddEvents(((Panel)c).Controls);
                }
                //Expand this series of if...else... to include any 
                //other type of container control
                else if (c is TextBox)
                {
                    ((TextBox)c).TextChanged += new EventHandler(SettingsChanged);
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).CheckedChanged += new EventHandler(SettingsChanged);
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).CheckedChanged += new EventHandler(SettingsChanged);
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).ValueChanged += new EventHandler(SettingsChanged);
                }
                //Expand this to include any other type of controls your form 
                //has that you need to add the event to
            }
        }

        void SettingsChanged(object obj, EventArgs e)
        {
            btn_apply.Enabled = true;
        }

        private void cb_nma_CheckedChanged(object sender, EventArgs e)
        {
            tb_nma.Enabled = !tb_nma.Enabled;
            lnk_nma.Enabled = !lnk_nma.Enabled;
            lbl_nma.Enabled = !lbl_nma.Enabled;
            btn_nmaTest.Enabled = !btn_nmaTest.Enabled;
        }

        
        private void cb_prowl_CheckedChanged(object sender, EventArgs e)
        {
            tb_prowl.Enabled = !tb_prowl.Enabled;
            lnk_prowl.Enabled = !lnk_prowl.Enabled;
            lbl_prowl.Enabled = !lbl_prowl.Enabled;
            btn_prowlTest.Enabled = !btn_prowlTest.Enabled;
        }

        private void cb_mail_CheckedChanged(object sender, EventArgs e)
        {
            lbl_mailSMTP.Enabled = !lbl_mailSMTP.Enabled;
            lbl_mailAddress.Enabled = !lbl_mailAddress.Enabled;
            tb_mailTo.Enabled = !tb_mailTo.Enabled;
            tb_mailSMTP.Enabled = !tb_mailSMTP.Enabled;
            btn_mailTest.Enabled = !btn_mailTest.Enabled;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applySettings()
        {
            settings.AntiAFK = cb_antiAfk.Checked;
            settings.AutoJoin = cb_autoJoin.Checked;

            settings.Sound = cb_sound.Checked;
            settings.DesktopNotification = cb_desktopNotification.Checked;
            settings.BalloonTips = cb_balloonTips.Checked;

            settings.Opacity = (int)num_opacity.Value;
            settings.LockWindow = cb_lockWindow.Checked;

            if (rb_windowNormal.Checked) settings.WindowPreferences = "Normal";
            if (rb_windowTop.Checked) settings.WindowPreferences = "AlwaysTop";
            if (rb_windowTray.Checked) settings.WindowPreferences = "TrayOnly";

            settings.NmaNotification = cb_nmaNotification.Checked;
            settings.NmaAPIKey = tb_nma.Text;

            settings.ProwlNotification = cb_prowlNotification.Checked;
            settings.ProwlAPIKey = tb_prowl.Text;

            settings.MailNotification = cb_mailNotification.Checked;
            settings.MailAddress = tb_mailTo.Text;
            settings.MailSmpt = tb_mailSMTP.Text;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            applySettings();
            this.Close();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            btn_apply.Enabled = false;
            applySettings();
        }

        private void lnk_nma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.notifymyandroid.com/register.jsp");
        }

        private void lnk_prowl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.prowlapp.com/register.php");
        }

        private void btn_nmaTest_Click(object sender, EventArgs e)
        {

        }

        public void overwriteControlsFromSettings()
        {
            cb_antiAfk.Checked = settings.AntiAFK;
            cb_autoJoin.Checked = settings.AutoJoin;

            cb_sound.Checked = settings.Sound;
            cb_desktopNotification.Checked = settings.DesktopNotification;
            cb_balloonTips.Checked = settings.BalloonTips;

            num_opacity.Value = settings.Opacity;
            cb_lockWindow.Checked = settings.LockWindow;

            switch (settings.WindowPreferences)
            {
                case "normal":
                    rb_windowNormal.Checked = true;
                    rb_windowTop.Checked = false;
                    rb_windowTray.Checked = false;
                    break;
                case "AlwaysTop":
                    rb_windowNormal.Checked = false;
                    rb_windowTop.Checked = true;
                    rb_windowTray.Checked = false;
                    break;
                case "TrayOnly":
                    rb_windowNormal.Checked = false;
                    rb_windowTop.Checked = false;
                    rb_windowTray.Checked = true;
                    break;
            }

            cb_lockWindow.Checked = settings.LockWindow;

            cb_nmaNotification.Checked = settings.NmaNotification;
            tb_nma.Text = settings.NmaAPIKey;
            if (settings.NmaNotification)
            {
                lbl_nma.Enabled = true;
                tb_nma.Enabled = true;
                lnk_nma.Enabled = true;
                btn_nmaTest.Enabled = true;
            }

            cb_prowlNotification.Checked = settings.ProwlNotification;
            tb_prowl.Text = settings.ProwlAPIKey;
            if (settings.ProwlNotification)
            {
                lbl_prowl.Enabled = true;
                tb_prowl.Enabled = true;
                lnk_prowl.Enabled = true;
                btn_prowlTest.Enabled = true;
            }

            cb_mailNotification.Checked = settings.MailNotification;
            tb_mailTo.Text = settings.MailAddress;
            tb_mailSMTP.Text = settings.MailSmpt;
            if (settings.MailNotification)
            {
                lbl_mailAddress.Enabled = true;
                lbl_mailSMTP.Enabled = true;
                tb_mailTo.Enabled = true;
                tb_mailSMTP.Enabled = true;
                btn_mailTest.Enabled = true;
            }

            btn_apply.Enabled = false;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            overwriteControlsFromSettings();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            settings.Reset();
            overwriteControlsFromSettings();
        }
    }
}
