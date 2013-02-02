using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Xml;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using DT;

namespace Dungeon_Teller
{
    public partial class DungeonTeller : Form
    {

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr thWnd, int msg, int wParam, IntPtr lParam);

        const int VK_CONTROL = 0xA2;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int VK_RETURN = 0x0D;
        const int VK_SPACE = 0x20;

        SoundPlayer ready = new SoundPlayer(Properties.Resources.Ready);
        Random rand = new Random();

        int pid_wow;
        IntPtr hWnd_wow;

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_RESTORE = 9;

        public DungeonTeller()
        {
            InitializeComponent();
        }

        private void DungeonTeller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.AntiAFK = cb_antiAfk.Checked;
            Properties.Settings.Default.AutoJoin = cb_autoJoin.Checked;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void DungeonTeller_Load(object sender, EventArgs e)
        {
            int TaskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height - this.Height - TaskbarHeight;
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width - this.Width;
            Point StartLoc = new Point(ScreenWidth, ScreenHeight);
            this.Location = StartLoc;
            this.TopMost = true;
        }

        private void DungeonTeller_LocationChanged(object sender, EventArgs e)
        {
            int TaskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height - this.Height - TaskbarHeight;
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width - this.Width;
            Point StartLoc = new Point(ScreenWidth, ScreenHeight);
            this.Location = StartLoc; 
        }

        public void dungeonReady()
        {

            if (cb_autoJoin.Checked)
            {
                Object saveClipboard = Clipboard.GetDataObject();
                Clipboard.SetText("/click LFGDungeonReadyDialogEnterDungeonButton");

                SendMessage(hWnd_wow, WM_KEYDOWN, VK_RETURN, IntPtr.Zero);
                SendMessage(hWnd_wow, WM_KEYUP, VK_RETURN, IntPtr.Zero);

                SendMessage(hWnd_wow, WM_KEYDOWN, VK_CONTROL, IntPtr.Zero);
                SendMessage(hWnd_wow, WM_KEYDOWN, 0x56, IntPtr.Zero);

                SendMessage(hWnd_wow, WM_KEYUP, 0x56, IntPtr.Zero);
                SendMessage(hWnd_wow, WM_KEYUP, VK_CONTROL, IntPtr.Zero);

                SendMessage(hWnd_wow, WM_KEYDOWN, VK_RETURN, IntPtr.Zero);
                SendMessage(hWnd_wow, WM_KEYUP, VK_RETURN, IntPtr.Zero);

                Clipboard.SetDataObject(saveClipboard);
            }

            Check.Stop();

            this.TopMost = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            DialogResult result = MessageBox.Show(this, "Your queue is ready!\n\n Do you want to switch to WoW and exit Dungeon Teller?", "Queue ready", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                SetForegroundWindow(hWnd_wow);
                ShowWindow(hWnd_wow, SW_RESTORE);
                this.Close();
            }
            else
            {
                Check.Start();
            }

        }

        bool trayInfoLFRShowed = false;
        bool trayInfoLFDShowed = false;
        bool readySoundPlayed = false;
        string playerName;
        private void Check_Tick(object sender, EventArgs e)
        {
            try
            {
                playerName = Memory.Read<string>(Memory.BaseAddress + offset.playerName);

                int inQueueLFD = Convert.ToInt32(Memory.Read<uint>(Memory.BaseAddress + offset.inQueueLFD));
                int inQueueLFR = Convert.ToInt32(Memory.Read<uint>(Memory.BaseAddress + offset.inQueueLFR));
                byte isQueueReady = Convert.ToByte(Memory.Read<byte>(Memory.BaseAddress + offset.isQueueReady));

                if (isQueueReady == 1)
                {
                    pictureBox1.Image = Properties.Resources.QueueReady;
                    lbl_LFDStatus.ForeColor = System.Drawing.Color.Green;
                    lbl_LFDStatus.Text = "ready";

                    if (readySoundPlayed == false)
                    {
                        readySoundPlayed = true;
                        ready.Play();
                        timer_antiAFK.Stop();
                        dungeonReady();
                    }
                }
                else if (isQueueReady == 2)
                {
                    pictureBox1.Image = Properties.Resources.QueueReady;
                    lbl_LFRStatus.ForeColor = System.Drawing.Color.Green;
                    lbl_LFRStatus.Text = "ready";

                    if (readySoundPlayed == false)
                    {
                        readySoundPlayed = true;
                        ready.Play();
                        timer_antiAFK.Stop();
                        dungeonReady();
                    }

                }
                else
                {
                    readySoundPlayed = false;

                    if (inQueueLFD != 0 || inQueueLFR != 0)
                    {
                        pictureBox1.Image = Properties.Resources.InQueue;

                        if (cb_antiAfk.Checked)
                        {
                            if (!timer_antiAFK.Enabled) timer_antiAFK.Start();
                        }
                        else
                        {
                            if (timer_antiAFK.Enabled) timer_antiAFK.Stop();
                        }

                        if (inQueueLFD != 0 && inQueueLFR != 0)
                        {
                            notifyIcon1.Text = "Dungeon Teller - 2 active queues";
                        }
                        else
                        {
                            notifyIcon1.Text = "Dungeon Teller - 1 active queue";
                        }

                        //LFD active tooltip
                        if (inQueueLFD != 0)
                        {
                            if (!trayInfoLFDShowed)
                            {
                                notifyIcon1.BalloonTipText = "LFD queue is now active.";
                                notifyIcon1.ShowBalloonTip(500);
                                trayInfoLFDShowed = true;
                            }

                            if (inQueueLFR == 0) trayInfoLFRShowed = false;
                        }

                        //LFR active tooltip
                        if (inQueueLFR != 0)
                        {
                            if (!trayInfoLFRShowed)
                            {
                                notifyIcon1.BalloonTipText = "LFR queue is now active.";
                                notifyIcon1.ShowBalloonTip(500);
                                trayInfoLFRShowed = true;
                            }

                            if (inQueueLFD == 0) trayInfoLFDShowed = false;
                        }

                        lbl_LFDStatus.ForeColor = (inQueueLFD != 0) ? System.Drawing.Color.Blue : System.Drawing.Color.Red;
                        lbl_LFRStatus.ForeColor = (inQueueLFR != 0) ? System.Drawing.Color.Blue : System.Drawing.Color.Red;
                        lbl_LFDStatus.Text = (inQueueLFD != 0) ? "queued" : "not queued";
                        lbl_LFRStatus.Text = (inQueueLFR != 0) ? "queued" : "not queued";
                    }
                    else
                    {
                        trayInfoLFDShowed = false;
                        trayInfoLFRShowed = false;
                        pictureBox1.Image = Properties.Resources.NotInQueue;
                        lbl_LFDStatus.ForeColor = System.Drawing.Color.Red;
                        lbl_LFRStatus.ForeColor = System.Drawing.Color.Red;
                        lbl_LFDStatus.Text = "not queued";
                        lbl_LFRStatus.Text = "not queued";
                        notifyIcon1.Text = "Dungeon Teller";
                        if (timer_antiAFK.Enabled) timer_antiAFK.Stop();
                    }
                }
            }
            catch
            {
                Check.Stop();
                MessageBox.Show("World of Warcraft has quit!\nThe program will now quit!", "DT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void DungeonTeller_VisibleChanged(object sender, EventArgs e)
        {
            pid_wow = Memory.ProcessId;
            hWnd_wow = Process.GetProcessById(pid_wow).MainWindowHandle;

            cb_antiAfk.Checked = Properties.Settings.Default.AntiAFK;
            cb_autoJoin.Checked = Properties.Settings.Default.AutoJoin;

            this.Text = this.Text + " (attaced to PID " + pid_wow + ")";
            Check.Start();
        }

        private void timer_antiAFK_Tick(object sender, EventArgs e)
        {
            timer_antiAFK.Interval = rand.Next(30000, 90000);

            SendMessage(hWnd_wow, WM_KEYDOWN, VK_SPACE, IntPtr.Zero);
            SendMessage(hWnd_wow, WM_KEYUP, VK_SPACE, IntPtr.Zero);
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
                this.Show();
                this.WindowState = FormWindowState.Normal;
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

    }
}
