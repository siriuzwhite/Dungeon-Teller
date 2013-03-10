﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;

namespace Dungeon_Teller
{
	public partial class DungeonTeller : Form
	{
		private const int SW_RESTORE = 9;

		Properties.Settings settings = Properties.Settings.Default;
		SoundPlayer ready = new SoundPlayer(Properties.Resources.Ready);
		Random rand = new Random();
		private Options opt = null;
		private int pid_wow;
		private IntPtr hWnd_wow;

		DesktopNotification notification = new DesktopNotification();

		dtModule lfdModule;
		dtModule lfrModule;
		dtModule bg1Module;
		dtModule bg2Module;

		QueueStats.LFGDataStruct lfdQueue;
		QueueStats.LFGDataStruct lfrQueue;
		QueueStats.BGDataStruct bg1Queue;
		QueueStats.BGDataStruct bg2Queue;

		private int pveQueueReadyStatus = 0;
		private int lfdQueueStatus = 0;
		private int lfrQueueStatus = 0;
		private int pvp1QeueStatus = 0;
		private int pvp2QueueStatus = 0;
		private int numActiveQueues = 0;

		private bool resetLFD = false;
		private bool resetLFR = false;
		public bool queueReady = false;

		public bool optOpen = false;
		public bool paused = false;

		public int LfdQueueStatus
		{
			get { return lfdQueueStatus; }
			set
			{
				if (lfdQueueStatus != value)
				{
					lfdQueueStatus = value;
					LFDQueueStatus_Changed();
				}
			}
		}

		public int LfrQueueStatus
		{
			get { return lfrQueueStatus; }
			set
			{
				if ((lfrQueueStatus == 0 && value != 0) || (lfrQueueStatus != 0 && value == 0))
				{
					lfrQueueStatus = value;
					LfrQueueStatus_Changed();
				}
			}
		}

		public int PveQueueReadyStatus
		{
			get { return pveQueueReadyStatus; }
			set
			{
				if (pveQueueReadyStatus != value)
				{
					pveQueueReadyStatus = value;
					PveQueueReadyStatus_Changed();
				}
			}
		}

		public int Pvp1QueueStatus
		{
			get { return pvp1QeueStatus; }
			set
			{
				if ((pvp1QeueStatus != value))
				{
					pvp1QeueStatus = value;
					Pvp1QueueStatus_Changed();
				}
			}
		}

		public int Pvp2QueueStatus
		{
			get { return pvp2QueueStatus; }
			set
			{
				if ((pvp2QueueStatus != value))
				{
					pvp2QueueStatus = value;
					Pvp2QueueStatus_Changed();
				}
			}
		}

		public int NumActiveQueues
		{
			get { return numActiveQueues; }
			set
			{
				if ((numActiveQueues != value))
				{
					numActiveQueues = value;
					NumActiveQueues_Changed();
				}
			}
		}

		public DungeonTeller()
		{
			InitializeComponent();

			this.pic_LfdTank.Image = Helper.ConvertToGrayScale(Helper.bmpTank);
			this.pic_LfdHeal.Image = Helper.ConvertToGrayScale(Helper.bmpHeal);
			this.pic_LfdDps.Image = Helper.ConvertToGrayScale(Helper.bmpDps);

			this.pic_LfrTank.Image = Helper.ConvertToGrayScale(Helper.bmpTank);
			this.pic_LfrHeal.Image = Helper.ConvertToGrayScale(Helper.bmpHeal);
			this.pic_LfrDps.Image = Helper.ConvertToGrayScale(Helper.bmpDps);

			lfdModule = new dtModule(
				lbl_LfdStatus,
				lbl_LfdWait,
				lbl_LfdQueueTime,
				lbl_LfdTank,
				lbl_LfdHealer,
				lbl_LfdDps,
				pic_LfdTank,
				pic_LfdHeal,
				pic_LfdDps
			);

			lfrModule = new dtModule(
				lbl_LfrStatus,
				lbl_LfrWait,
				lbl_LfrQueueTime,
				lbl_LfrTank,
				lbl_LfrHealer,
				lbl_LfrDps,
				pic_LfrTank,
				pic_LfrHeal,
				pic_LfrDps
			);

			bg1Module = new dtModule(
				lbl_BG1Status,
				lbl_Bg1Wait,
				lbl_Bg1QueuedTime
			);

			bg2Module = new dtModule(
				lbl_BG2Status,
				lbl_Bg2Wait,
				lbl_Bg2QueuedTime
			);
		}

		[DllImport("user32.dll")]
		static extern bool SetForegroundWindow(IntPtr hWnd);
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		private void LFDQueueStatus_Changed()
		{
			if (LfdQueueStatus != 0)
			{
				QueueStatus_IsQueued("Dungeon Finder");
				panel_lfgEye.Hide();
				gb_lfd.Show();
				timerLfdRefresh.Start();
			}
			else
			{
				gb_lfd.Hide();
				timerLfdRefresh.Stop();
				Helper.setNotQueued(lfdModule);
			}
		}

		private void LfrQueueStatus_Changed()
		{
			if (LfrQueueStatus != 0)
			{
				QueueStatus_IsQueued("Raid Finder");
				panel_lfgEye.Hide();
				gb_lfr.Show();
				timerLfrRefresh.Start();
			}
			else
			{
				gb_lfr.Hide();
				timerLfrRefresh.Stop();
				Helper.setNotQueued(lfrModule);
			}
		}

		public void PveQueueReadyStatus_Changed()
		{
			int category = QueueStats.LfgDungeons[PveQueueReadyStatus].m_category;
			string name = QueueStats.LfgDungeons[PveQueueReadyStatus].DungeonName;

			if (category == 1)
			{
				QueueStatus_IsReady("Dungeon Finder", name);
			}
			else if (category == 2)
			{
				QueueStatus_IsReady("Raid Finder", name);
			}
			else
			{
				queueReady = false;

				if (resetLFD)
				{
					Helper.setNotQueued(lfdModule);
				}
				if (resetLFR)
				{
					Helper.setNotQueued(lfrModule);
				}
			}
		}

		private void Pvp1QueueStatus_Changed()
		{
			string name = bg1Queue.battlefieldName;

			if (Pvp1QueueStatus < 1)
			{
				gb_bg1.Hide();
				timerBg1Refresh.Stop();
				Helper.setNotQueued(bg1Module);
			}
			else if (Pvp1QueueStatus == 1)
			{
				QueueStatus_IsQueued("Battleground 1");
				panel_lfgEye.Hide();
				gb_bg1.Show();
				timerBg1Refresh.Start();
			}
			else if (Pvp1QueueStatus == 2)
			{
				QueueStatus_IsReady("Battleground 1", name);
			}

			if (Pvp1QueueStatus != 2) queueReady = false;
		}

		private void Pvp2QueueStatus_Changed()
		{
			string name = bg2Queue.battlefieldName;

			if (Pvp2QueueStatus == 0)
			{
				gb_bg2.Hide();
				timerBg2Refresh.Stop();
				Helper.setNotQueued(bg2Module);
			}
			else if (Pvp2QueueStatus == 1)
			{
				QueueStatus_IsQueued("Battleground 2");
				panel_lfgEye.Hide();
				gb_bg2.Show();
				timerBg2Refresh.Start();
			}
			else if (Pvp2QueueStatus == 2)
			{
				QueueStatus_IsReady("Battleground 2", name);
			}

			if (Pvp2QueueStatus != 2) queueReady = false;

		}

		private void QueueStatus_IsQueued(string queueQueuedName)
		{
			Label label = new Label();

			switch (queueQueuedName)
			{
				case "Dungeon Finder":
					label = lbl_LfdStatus;
					break;
				case "Raid Finder":
					label = lbl_LfrStatus;
					break;
				case "Battleground 1":
					label = lbl_BG1Status;
					break;
				case "Battleground 2":
					label = lbl_BG2Status;
					break;
			}

			Helper.setQueued(label);

			if (settings.AntiAFK)
				if (!timerAntiAFK.Enabled) timerAntiAFK.Start();

			if (settings.BalloonTips)
			{
				notifyIcon1.BalloonTipText = queueQueuedName + " queue is now active.";
				notifyIcon1.ShowBalloonTip(500);
			}
		}

		private void QueueStatus_IsReady(string queueReadyName, string mapName)
		{

			dtModule module = new dtModule();
			bool pve = false, pvp = false;
			queueReady = true;
			Image img = null;

			switch (queueReadyName)
			{
				case "Dungeon Finder":
					pve = true;
					resetLFD = true;
					module = lfdModule;
					img = Properties.Resources.dungeon_finder_icon;
					break;
				case "Raid Finder":
					pve = true;
					resetLFR = true;
					module = lfrModule;
					img = Properties.Resources.raid_finder_icon;
					break;
				case "Battleground 1":
					pvp = true;
					module = bg1Module;
					img = Properties.Resources.pvp_finder_icon;
					break;
				case "Battleground 2":
					pvp = true;
					module = bg2Module;
					img = Properties.Resources.pvp_finder_icon;
					break;
			}

			Helper.setReady(module, mapName);

			timerAntiAFK.Stop();

			if (settings.BalloonTips)
			{
				notifyIcon1.BalloonTipText = queueReadyName + " queue is ready!";
				notifyIcon1.ShowBalloonTip(500);
			}

			if (settings.Sound) ready.Play();

			if (settings.AutoJoin)
			{
				if (pve)
					WoWCommand.sendSlashCommand(hWnd_wow, "/click LFGDungeonReadyDialogEnterDungeonButton");
				if (pvp)
					WoWCommand.sendSlashCommand(hWnd_wow, "/click StaticPopup1Button1");
			}

			if (!settings.TrayOnly)
			{
				this.Show();
				this.WindowState = FormWindowState.Normal;
			}

			if (settings.BringToFront)
			{
				SetForegroundWindow(hWnd_wow);
				ShowWindow(hWnd_wow, SW_RESTORE);
			}

			if (settings.DesktopNotification)
			{
				if (!notification.Visible)
				{
					DialogResult result = notification.ShowDialog(new costumArguments(img, queueReadyName, mapName));

					if (result == DialogResult.OK)
					{
						SetForegroundWindow(hWnd_wow);
						ShowWindow(hWnd_wow, SW_RESTORE);
					}
				}

			}

			if (settings.PushNotification)
			{
				Notification.sendPushOver(settings.PushOverUserKey, "Queue ready!", "Your " + queueReadyName + " queue is now ready!");
			}
			if (settings.MailNotification)
			{
				Notification.sendMail(settings.MailAddress, "Queue ready", "Your " + queueReadyName + " queue is now ready!");
			}

		}

		private void NumActiveQueues_Changed()
		{
			switch (NumActiveQueues)
			{
				case 0:
					notifyIcon1.Text = "Dungeon Teller";
					if (timerAntiAFK.Enabled) timerAntiAFK.Stop();
					break;
				case 1:
					notifyIcon1.Text = "Dungeon Teller - 1 active queue";
					break;
				default:
					notifyIcon1.Text = "Dungeon Teller - " + NumActiveQueues + " active queues";
					break;
			}

			if (numActiveQueues == 0)
				panel_lfgEye.Show();

		}

		private int getkNumActiveQueues()
		{
			int activeQueues = 0;

			if (LfdQueueStatus != 0) activeQueues++;
			if (LfrQueueStatus != 0) activeQueues++;
			if (Pvp1QueueStatus == 1) activeQueues++;
			if (Pvp2QueueStatus == 1) activeQueues++;
			if (queueReady) activeQueues++;

			return activeQueues;
		}

		public void lockToBottomRight()
		{
			int TaskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
			int ScreenHeight = Screen.PrimaryScreen.Bounds.Height - this.Height - TaskbarHeight;
			int ScreenWidth = Screen.PrimaryScreen.Bounds.Width - this.Width;
			Point StartLoc = new Point(ScreenWidth, ScreenHeight);
			this.Location = StartLoc;
		}

		private void showOptions()
		{
			if (optOpen == false)
			{
				opt = new Options(this);
				opt.Show();
				optOpen = true;
			}
			else
				opt.Focus();
		}

		private void DungeonTeller_FormClosing(object sender, FormClosingEventArgs e)
		{
			settings.Save();
			Application.Exit();
		}

		private void DungeonTeller_Load(object sender, EventArgs e)
		{
			lockToBottomRight();
			pid_wow = Memory.ProcessId;
			hWnd_wow = Process.GetProcessById(pid_wow).MainWindowHandle;

			lbl_attachedTo.Text = "(attached to PID: " + pid_wow + ")";
			timerMemoryRead.Start();
		}

		private void DungeonTeller_LocationChanged(object sender, EventArgs e)
		{
			if (settings.LockWindow)
			{
				lockToBottomRight();
			}
		}

		private void timerMemoryRead_Tick(object sender, EventArgs e)
		{
			try
			{
				if (settings.PauseFocus)
				{
					if (GetForegroundWindow() == hWnd_wow)
					{
						paused = true;
						this.panel_inner.Enabled = false;
					}
					else
					{
						paused = false;
						this.panel_inner.Enabled = true;
					}
				}

				if (!paused)
				{
					NumActiveQueues = getkNumActiveQueues();

					PveQueueReadyStatus = QueueStats.getLfgProposal();

					lfdQueue = QueueStats.getLfgQueueStats(1);
					lfrQueue = QueueStats.getLfgQueueStats(3);
					bg1Queue = QueueStats.getBgQeueStats(1);
					bg2Queue = QueueStats.getBgQeueStats(2);

					LfdQueueStatus = lfdQueue.LfgDungeonsId;
					LfrQueueStatus = lfrQueue.LfgDungeonsId;
					Pvp1QueueStatus = bg1Queue.status;
					Pvp2QueueStatus = bg2Queue.status;
				}
			}
			catch (Exception ep)
			{
				timerMemoryRead.Stop();
				MessageBox.Show("Unexpected Error: " + ep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}

		private void timer_antiAFK_Tick(object sender, EventArgs e)
		{
			timerAntiAFK.Interval = rand.Next(30000, 90000);

			if (settings.PauseFocus)
			{
				if (GetForegroundWindow() != hWnd_wow)
				{
					WoWCommand.sendAntiAFK(hWnd_wow);
				}
			}
			else
			{
				WoWCommand.sendAntiAFK(hWnd_wow);
			}
		}


		private void DungeonTeller_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				this.Hide();
			}
		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (!settings.TrayOnly)
				{
					this.Show();
					this.WindowState = FormWindowState.Normal;
				}
			}
		}

		private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			ToolStripItem item = e.ClickedItem;

			if (item.Name == "Restore")
			{
				this.Show();
				this.WindowState = FormWindowState.Normal;
			}

			if (item.Name == "Exit")
			{
				Application.Exit();
			}
		}

		private void lnk_options_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			showOptions();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			showOptions();
		}

		private void contextMenuStrip1_Opened(object sender, EventArgs e)
		{
			Restore.Visible = !settings.TrayOnly;
		}

		private void DungeonTeller_Shown(object sender, EventArgs e)
		{
			if (settings.TrayOnly)
			{
				notifyIcon1.BalloonTipText = "Dungeon Teller is now active!";
				notifyIcon1.ShowBalloonTip(500);
				this.Hide();
			}
		}

		private void DungeonTeller_SizeChanged(object sender, EventArgs e)
		{
			if (settings.LockWindow)
			{
				lockToBottomRight();
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			gb_lfd.Hide();
		}

		private void timerLFDRefresh_Tick(object sender, EventArgs e)
		{
			Helper.LfgRefresh(lfdModule, lfdQueue);
		}

		private void timerLfrRefresh_Tick(object sender, EventArgs e)
		{
			Helper.LfgRefresh(lfrModule, lfrQueue);
		}

		private void timerBg1Refresh_Tick(object sender, EventArgs e)
		{
			Helper.BgRefresh(bg1Module, bg1Queue);
		}

		private void timerBg2Refresh_Tick(object sender, EventArgs e)
		{
			Helper.BgRefresh(bg2Module, bg2Queue);
		}

	}
}
