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
        Properties.Settings settings = Properties.Settings.Default;
        Options opt = null;

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
            settings.Save();
            Application.Exit();
        }

        public void lockToBottomRight()
        {
            int TaskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height - this.Height - TaskbarHeight;
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width - this.Width;
            Point StartLoc = new Point(ScreenWidth, ScreenHeight);
            this.Location = StartLoc;
        }

        private void DungeonTeller_Load(object sender, EventArgs e)
        {
            lockToBottomRight();
            pid_wow = Memory.ProcessId;
            hWnd_wow = Process.GetProcessById(pid_wow).MainWindowHandle;

            this.Text = this.Text + " (attaced to PID " + pid_wow + ")";
            Check.Start();
        }

        private void DungeonTeller_LocationChanged(object sender, EventArgs e)
        {
            if (settings.LockWindow)
            {
                lockToBottomRight();
            }
        }

        private byte isQueueReady = 0;
        public byte IsQueueReady
        {
            get { return isQueueReady; }
            set
            {
                if (isQueueReady != value)
                {
                    isQueueReady = value;
                    IsQueueReady_Changed();
                }
            }
        }

        private uint inQueueLFD = 0;
        public uint InQueueLFD
        {
            get { return inQueueLFD; }
            set
            {
                if (inQueueLFD != value)
                {
                    inQueueLFD = value;
                    InQueueLFD_Changed();
                }
            }
        }

        private uint inQueueLFR = 0;
        public uint InQueueLFR
        {
            get { return inQueueLFR; }
            set
            {
                if (inQueueLFR != value)
                {
                    inQueueLFR = value;
                    InQueueLFR_Changed();
                }
            }
        }


        private void InQueueLFD_Changed()
        {
            if (InQueueLFD != 0)
            {
                if(settings.AntiAFK)
                    if (!timer_antiAFK.Enabled) timer_antiAFK.Start();

                pictureBox1.Image = Properties.Resources.InQueue;

                lbl_LFDStatus.ForeColor = System.Drawing.Color.Blue;
                lbl_LFDStatus.Text = "queued";
                notifyIcon1.Text = "Dungeon Teller - 1 active queue";
                notifyIcon1.BalloonTipText = "Dungeon Finder queue is now active.";

                if (settings.BalloonTips) notifyIcon1.ShowBalloonTip(500);

                if (InQueueLFR != 0) notifyIcon1.Text = "Dungeon Teller - 2 active queues";
            }
            else
            {
                lbl_LFDStatus.ForeColor = System.Drawing.Color.Red;
                lbl_LFDStatus.Text = "not queued";
                if (InQueueLFR != 0)
                    notifyIcon1.Text = "Dungeon Teller - 1 active queue";
                else
                    resetAll();
            }
        }

        private void InQueueLFR_Changed()
        {
            if (InQueueLFR != 0)
            {
                if (settings.AntiAFK)
                    if (!timer_antiAFK.Enabled) timer_antiAFK.Start();

                pictureBox1.Image = Properties.Resources.InQueue;

                lbl_LFRStatus.ForeColor = System.Drawing.Color.Blue;
                lbl_LFRStatus.Text = "queued";
                notifyIcon1.Text = "Dungeon Teller - 1 active queue";
                notifyIcon1.BalloonTipText = "Raid Finder queue is now active.";

                if (settings.BalloonTips) notifyIcon1.ShowBalloonTip(500);

                if (InQueueLFD != 0) notifyIcon1.Text = "Dungeon Teller - 2 active queues";
            }
            else
            {
                lbl_LFRStatus.ForeColor = System.Drawing.Color.Red;
                lbl_LFRStatus.Text = "not queued";
                if (InQueueLFD != 0)
                    notifyIcon1.Text = "Dungeon Teller - 1 active queue";
                else
                    resetAll();
            }
        }

        string notifyMessage;
        bool resetLFD = false;
        bool resetLFR = false;

        private void IsQueueReady_Changed()
        {
            if (IsQueueReady != 0)
            {
                if (IsQueueReady == 1)
                {
                    resetLFD = true;
                    lbl_LFDStatus.ForeColor = System.Drawing.Color.Green;
                    lbl_LFDStatus.Text = "ready";
                    notifyIcon1.BalloonTipText = "Dungeon Finder queue is ready!";
                    notifyMessage = "Your Dungeon Finder queue is now ready!";
                }

                if (IsQueueReady == 2)
                {
                    resetLFR = true;
                    lbl_LFRStatus.ForeColor = System.Drawing.Color.Green;
                    lbl_LFRStatus.Text = "ready";
                    notifyIcon1.BalloonTipText = "Raid Finder queue is ready!";
                    notifyMessage = "Your Raid Finder queue is now ready!";
                }

                timer_antiAFK.Stop();

                if (settings.BalloonTips) notifyIcon1.ShowBalloonTip(500);

                if (settings.Sound) ready.Play();

                if (settings.AutoJoin)
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

                    DialogResult result = MessageBox.Show(this, "Your queue is ready!\n\n Do you want to quit Dungeon Teller?", "Queue ready", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes) this.Close();
                }

                if (settings.NmaNotification)
                {
                    Notification.pushNMA(settings.NmaAPIKey, "Queue ready", notifyMessage);
                }

                if (settings.ProwlNotification)
                {
                    Notification.pushProwl(settings.ProwlAPIKey, "Queue ready", notifyMessage);
                }

            }
            else
            {
                if (resetLFD)
                {
                    lbl_LFDStatus.ForeColor = System.Drawing.Color.Red;
                    lbl_LFDStatus.Text = "not queued";
                }
                if (resetLFR)
                {
                    lbl_LFRStatus.ForeColor = System.Drawing.Color.Red;
                    lbl_LFRStatus.Text = "not queued";
                }
            }
        }

        private void resetAll()
        {
            pictureBox1.Image = Properties.Resources.NotInQueue;
            notifyIcon1.Text = "Dungeon Teller";
            if (timer_antiAFK.Enabled) timer_antiAFK.Stop();
        }

        private void Check_Tick(object sender, EventArgs e)
        {
            try
            {
                InQueueLFD = Convert.ToUInt32(Memory.Read<uint>(Memory.BaseAddress + Offset.inQueueLFD));
                InQueueLFR = Convert.ToUInt32(Memory.Read<uint>(Memory.BaseAddress + Offset.inQueueLFR));
                IsQueueReady = Convert.ToByte(Memory.Read<byte>(Memory.BaseAddress + Offset.isQueueReady));


            }
            catch
            {
                Check.Stop();
                MessageBox.Show("World of Warcraft has quit!\nThe program will now quit!", "DT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
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

        public bool optOpen = false;

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

    }
}
