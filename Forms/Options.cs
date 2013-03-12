using Dungeon_Teller.Classes;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Dungeon_Teller.Forms
{
	public partial class Options : Form
	{
		DungeonTellerMain dt;
		ProcessSelector ps;
		Properties.Settings settings = Properties.Settings.Default;

		public Options(DungeonTellerMain dt)
		{
			InitializeComponent();
			AddEvents(this.Controls);
			this.dt = dt;
		}

		public Options(ProcessSelector ps)
		{
			InitializeComponent();
			AddEvents(this.Controls);
			this.ps = ps;
		}

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
			tb_pushOverUserKey.Enabled = !tb_pushOverUserKey.Enabled;
			lnk_pushOver.Enabled = !lnk_pushOver.Enabled;
			lbl_nma.Enabled = !lbl_nma.Enabled;
			btn_pushOverTest.Enabled = !btn_pushOverTest.Enabled;
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
			if (cb_pushOver.Checked && tb_pushOverUserKey.Text == "")
			{
				MessageBox.Show("PushOver notifications are checked but no API Key is given!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				settings.AutoSelect = cb_autoSelect.Checked;
				settings.PauseFocus = cb_pauseFocus.Checked;
				settings.Opacity = (int)num_opacity.Value;
				settings.CheckForUpdates = cb_updates.Checked;

				settings.PushNotification = cb_pushOver.Checked;
				settings.PushOverUserKey = tb_pushOverUserKey.Text;

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
			if (applySettings())
				this.Close();
		}

		private void btn_apply_Click(object sender, EventArgs e)
		{
			btn_apply.Enabled = false;
			applySettings();
		}

		private void lnk_nma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://pushover.net/");
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

			cb_autoSelect.Checked = settings.AutoSelect;
			cb_pauseFocus.Checked = settings.PauseFocus;
			num_opacity.Value = settings.Opacity;
			cb_updates.Checked = settings.CheckForUpdates;

			cb_pushOver.Checked = settings.PushNotification;
			tb_pushOverUserKey.Text = settings.PushOverUserKey;
			if (settings.PushNotification)
			{
				lbl_nma.Enabled = true;
				tb_pushOverUserKey.Enabled = true;
				lnk_pushOver.Enabled = true;
				btn_pushOverTest.Enabled = true;
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

			bool settingsUpgradeRequired = settings.SettingsUpgradeRequired;
			settings.Reset();
			settings.SettingsUpgradeRequired = settingsUpgradeRequired;
			overwriteControlsFromSettings();
		}

		private void btn_nmaTest_Click(object sender, EventArgs e)
		{
			Notification.sendPushOver(tb_pushOverUserKey.Text, "Test Event", "Test message");
		}

		private void Options_FormClosed(object sender, FormClosedEventArgs e)
		{
			dt.optOpen = false;
		}

		private void btn_mailTest_Click(object sender, EventArgs e)
		{
			Notification.sendMail(tb_mailTo.Text, "Dungeon Teller Test", "This is just a tets.");
		}
	}
}
