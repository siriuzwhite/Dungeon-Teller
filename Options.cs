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
        DungeonTeller dt;

        public Options(DungeonTeller dt)
        {
            InitializeComponent();
            AddEvents(this.Controls);
            this.dt = dt;
        }

        Properties.Settings settings = Properties.Settings.Default;

        void AddEvents(System.Windows.Forms.Control.ControlCollection Controls)
        {
            foreach (Control c in Controls)
            {
                if (c.HasChildren)
                {
                    AddEvents(c.Controls);
                }
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
            tb_nmaAPIKey.Enabled = !tb_nmaAPIKey.Enabled;
            lnk_nma.Enabled = !lnk_nma.Enabled;
            lbl_nma.Enabled = !lbl_nma.Enabled;
            btn_nmaTest.Enabled = !btn_nmaTest.Enabled;
        }

        
        private void cb_prowl_CheckedChanged(object sender, EventArgs e)
        {
            tb_prowlAPIKey.Enabled = !tb_prowlAPIKey.Enabled;
            lnk_prowl.Enabled = !lnk_prowl.Enabled;
            lbl_prowl.Enabled = !lbl_prowl.Enabled;
            btn_prowlTest.Enabled = !btn_prowlTest.Enabled;
        }

        private void cb_mail_CheckedChanged(object sender, EventArgs e)
        {
            lbl_mailAddress.Enabled = !lbl_mailAddress.Enabled;
            tb_mailTo.Enabled = !tb_mailTo.Enabled;
            btn_mailTest.Enabled = !btn_mailTest.Enabled;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool applySettings()
        {
            if (cb_nmaNotification.Checked && tb_nmaAPIKey.Text == "")
            {
                MessageBox.Show("NMA push notifications are checked but no API Key is given!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cb_prowlNotification.Checked && tb_prowlAPIKey.Text == "")
            {
                MessageBox.Show("Prowl push notifications are checked but no API Key is given!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (cb_mailNotification.Checked && tb_mailTo.Text == "")
            {
                MessageBox.Show("Mail notifications are checked but no mail address is given!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                settings.AntiAFK = cb_antiAfk.Checked;
                settings.AutoJoin = cb_autoJoin.Checked;

                settings.Sound = cb_sound.Checked;
                settings.DesktopNotification = cb_desktopNotification.Checked;
                settings.BalloonTips = cb_balloonTips.Checked;


                settings.TrayOnly = cb_trayOnly.Checked;
                settings.LockWindow = cb_lockWindow.Checked;
                settings.BringToFront = cb_bringToFront.Checked;
                settings.Opacity = (int)num_opacity.Value;

                settings.AutoSelect = cb_autoSelect.Checked;

                settings.NmaNotification = cb_nmaNotification.Checked;
                settings.NmaAPIKey = tb_nmaAPIKey.Text;

                settings.ProwlNotification = cb_prowlNotification.Checked;
                settings.ProwlAPIKey = tb_prowlAPIKey.Text;

                settings.MailNotification = cb_mailNotification.Checked;
                settings.MailAddress = tb_mailTo.Text;

                if (settings.LockWindow) dt.lockToBottomRight();

                if (settings.TrayOnly)
                {
                    dt.Hide();
                    this.Focus();
                }
                else
                {
                    dt.Show();
                    this.Focus();
                }

                dt.Opacity = (double)settings.Opacity / 100;
                dt.Refresh();

                return true;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if ( applySettings() )
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

        public void overwriteControlsFromSettings()
        {
            cb_antiAfk.Checked = settings.AntiAFK;
            cb_autoJoin.Checked = settings.AutoJoin;

            cb_sound.Checked = settings.Sound;
            cb_desktopNotification.Checked = settings.DesktopNotification;
            cb_balloonTips.Checked = settings.BalloonTips;

            cb_lockWindow.Checked = settings.LockWindow;
            cb_trayOnly.Checked = settings.TrayOnly;
            cb_bringToFront.Checked = settings.BringToFront;
            num_opacity.Value = settings.Opacity;

            cb_autoSelect.Checked = settings.AutoSelect;

            cb_nmaNotification.Checked = settings.NmaNotification;
            tb_nmaAPIKey.Text = settings.NmaAPIKey;
            if (settings.NmaNotification)
            {
                lbl_nma.Enabled = true;
                tb_nmaAPIKey.Enabled = true;
                lnk_nma.Enabled = true;
                btn_nmaTest.Enabled = true;
            }

            cb_prowlNotification.Checked = settings.ProwlNotification;
            tb_prowlAPIKey.Text = settings.ProwlAPIKey;
            if (settings.ProwlNotification)
            {
                lbl_prowl.Enabled = true;
                tb_prowlAPIKey.Enabled = true;
                lnk_prowl.Enabled = true;
                btn_prowlTest.Enabled = true;
            }

            cb_mailNotification.Checked = settings.MailNotification;
            tb_mailTo.Text = settings.MailAddress;
            if (settings.MailNotification)
            {
                lbl_mailAddress.Enabled = true;
                tb_mailTo.Enabled = true;
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

        private void btn_nmaTest_Click(object sender, EventArgs e)
        {
            Notification.pushNMA(tb_nmaAPIKey.Text, "Test Event", "Test message");
        }

        private void btn_prowlTest_Click(object sender, EventArgs e)
        {
            Notification.pushProwl(tb_prowlAPIKey.Text, "Test Event", "Test message");
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.optOpen = false;
        }

        private void btn_mailTest_Click(object sender, EventArgs e)
        {
            Notification.sendMail(tb_mailTo.Text, "Dungeon Teller Test", "This is just a test");
        }
    }
}
