using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Dungeon_Teller
{
	public partial class ProcessSelector : Form
	{
		List<ListBoxObject> pList = new List<ListBoxObject> { };
		Properties.Settings settings = Properties.Settings.Default;
		private const int SW_RESTORE = 9;

		public ProcessSelector()
		{
			InitializeComponent();

			if (Properties.Settings.Default.SettingsUpgradeRequired)
			{
				Properties.Settings.Default.Upgrade();
				Properties.Settings.Default.SettingsUpgradeRequired = false;
			}

		}

		[DllImport("user32.dll")]
		static extern bool SetForegroundWindow(IntPtr hWnd);
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		private void updateProcessList()
		{
			pList.Clear();
			lbx_WoWIds.DataSource = null;
			pList.Clear();
			Process[] pr = Process.GetProcessesByName("WoW");

			int pCount = 0;

			foreach (Process p in pr)
			{
				Memory.OpenProcess(p.Id);

				string playerName = Memory.Read<string>(Memory.BaseAddress + Offset.playerName.val);
				string playerRealm = Memory.Read<string>(Memory.BaseAddress + Offset.playerRealm.val);

				if (playerName.Length != 0 && playerRealm.Length != 0)
				{
					pCount++;
					string wow = p.Id + ": " + p.ProcessName + ".exe @" + playerName + " (" + playerRealm + ")";
					pList.Add(new ListBoxObject(p.Id, wow));
				}

			}

			if (pCount == 0)
			{
				timerBlink.Start();
				lbl_processCount.ForeColor = System.Drawing.Color.Red;
				lbl_processInfo.Text = "Are you logged in? Try to refresh!";
			}
			else
			{
				timerBlink.Stop();
				lbl_processInfo.Text = "Please select your wow process";
				lbl_processCount.Visible = true;
				lbl_processCount.ForeColor = System.Drawing.SystemColors.ControlText;
			}

			lbl_processCount.Text = pCount + " WoW instance(s) found";

			lbx_WoWIds.DataSource = pList;
			lbx_WoWIds.DisplayMember = "Text";
			lbx_WoWIds.ValueMember = "Value";
		}

		private void openDungeonTeller(int pid)
		{
			Memory.OpenProcess(pid);
			string playerName = Memory.Read<string>(Memory.BaseAddress + Offset.playerName.val);
			string playerRealm = Memory.Read<string>(Memory.BaseAddress + Offset.playerRealm.val);
			if (playerName.Length != 0 && playerRealm.Length != 0)
			{
				DungeonTeller dt = new DungeonTeller();
				dt.Show();
				this.Hide();
			}
		}

		private void btn_Attach_Click(object sender, EventArgs e)
		{
			if (lbx_WoWIds.SelectedItem != null)
			{
				int pid = (int)lbx_WoWIds.SelectedValue;
				openDungeonTeller(pid);
			}
			else
			{
				MessageBox.Show("Nothing selected!", "Dungeon Teller", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void ProcessSelector_Load(object sender, EventArgs e)
		{
			updateProcessList();
		}

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			updateProcessList();
		}

		private void timerBlink_Tick(object sender, EventArgs e)
		{
			this.lbl_processCount.Visible = !this.lbl_processCount.Visible;
		}

		private void lbx_WoWIds_DoubleClick(object sender, EventArgs e)
		{
			if (lbx_WoWIds.SelectedItem != null)
			{
				try
				{
					int pid = (int)lbx_WoWIds.SelectedValue;
					IntPtr handle = Process.GetProcessById(pid).MainWindowHandle;
					SetForegroundWindow(handle);
					ShowWindow(handle, SW_RESTORE);
				}
				catch
				{
					MessageBox.Show("The process has quit!");
					lbx_WoWIds.Items.Clear();
					Process[] pr = Process.GetProcessesByName("WoW");
					foreach (Process p in pr)
					{
						lbx_WoWIds.Items.Add(p.Id);
					}
				}
			}
		}

		private void ProcessSelector_Shown(object sender, EventArgs e)
		{
			if (settings.AutoSelect)
			{
				Process[] pr = Process.GetProcessesByName("WoW");

				if (pr.Length == 1)
				{
					openDungeonTeller(pr[0].Id);
				}
			}
		}

		public class ListBoxObject
		{
			readonly int value;
			readonly string text;

			public ListBoxObject(int value, string text)
			{
				this.value = value;
				this.text = text;
			}

			public string Text
			{
				get { return text; }
			}

			public int Value
			{
				get { return value; }
			}
		}

	}
}