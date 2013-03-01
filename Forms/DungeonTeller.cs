using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        dtModule lfdModule;
        dtModule lfrModule;
        dtModule bg1Module;
        dtModule bg2Module;

        private byte pveQueueReadyStatus = 0;
        private uint lfdQueueStatus = 0;
        private uint lfrQueueStatus = 0;
        private short pvp1QeueStatus = 0;
        private short pvp2QueueStatus = 0;
        private int numActiveQueues = 0;

        private bool resetLFD = false;
        private bool resetLFR = false;
        public bool queueReady = false;

        public bool optOpen = false;
        public bool paused = false;

        public uint LfdQueueStatus
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

        public uint LfrQueueStatus
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

        public byte PveQueueReadyStatus
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

        public short Pvp1QueueStatus
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

        public short Pvp2QueueStatus
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
            loadModules();

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

        public void loadModules()
        {
            gb_lfd.Visible = (settings.LFDModule) ? true : false;
            cgb_lfr.Visible = (settings.LFRModule) ? true : false;
            cgb_bg.Visible = (settings.BGModule) ? true : false;
        }

        private void LFDQueueStatus_Changed()
        {
            if (LfdQueueStatus != 0)
            {
                QueueStatus_IsQueued("Dungeon Finder");
                timerLfdRefresh.Start();
            }
            else
            {
                timerLfdRefresh.Stop();
                Helper.setNotQueued(lfdModule);
            }
        }

        private void LfrQueueStatus_Changed()
        {
            if (LfrQueueStatus != 0)
            {
                QueueStatus_IsQueued("Raid Finder");
                timerLfrRefresh.Start();
            }
            else
            {
                timerLfrRefresh.Stop();
                Helper.setNotQueued(lfrModule);
            }
        }

        public void PveQueueReadyStatus_Changed()
        {
            if (PveQueueReadyStatus == 1)
            {
                QueueStatus_IsReady("Dungeon Finder");
            }
            else if (PveQueueReadyStatus == 2)
            {
                QueueStatus_IsReady("Raid Finder");
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
            if (Pvp1QueueStatus == 0)
            {
                timerBg1Refresh.Stop();
                Helper.setNotQueued(bg1Module);
            }
            else if (Pvp1QueueStatus == 1)
            {
                QueueStatus_IsQueued("Battleground 1");
                timerBg1Refresh.Start();
            }
            else if (Pvp1QueueStatus == 2)
            {
                QueueStatus_IsReady("Battleground 1");
            }

            if (Pvp1QueueStatus != 2) queueReady = false;
        }

        private void Pvp2QueueStatus_Changed()
        {
            if (Pvp2QueueStatus == 0)
            {
                timerBg2Refresh.Stop();
                Helper.setNotQueued(bg2Module);
            }
            else if (Pvp2QueueStatus == 1)
            {
                QueueStatus_IsQueued("Battleground 2");
                timerBg2Refresh.Start();
            }
            else if (Pvp2QueueStatus == 2)
            {
                QueueStatus_IsReady("Battleground 2");
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

            setQueued(label);

            if (settings.AntiAFK)
                if (!timerAntiAFK.Enabled) timerAntiAFK.Start();

            if (settings.BalloonTips)
            {
                notifyIcon1.BalloonTipText = queueQueuedName + " queue is now active.";
                notifyIcon1.ShowBalloonTip(500);
            }
        }

        private void QueueStatus_IsReady(string queueReadyName)
        {

            Label label = new Label();
            bool pve = false, pvp=false;
            queueReady = true;

            switch (queueReadyName)
            {
                case "Dungeon Finder":
                    pve = true;
                    resetLFD = true;
                    label = lbl_LfdStatus;
                    break;
                case "Raid Finder":
                    pve = true;
                    resetLFR = true;
                    label = lbl_LfrStatus;
                    break;
                case "Battleground 1":
                    pvp = true;
                    label = lbl_BG1Status;
                    break;
                case "Battleground 2":
                    pvp = true;
                    label = lbl_BG2Status;
                    break;
            }

            setReady(label);

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
                MessageBox.Show(this, "Your " + queueReadyName + " queue is ready!", "Queue ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void setReady(Label lbl)
        {
            lbl.Text = "ready";
            lbl.ForeColor = System.Drawing.Color.Green;
        }

        private void setQueued(Label lbl)
        {
            lbl.Text = "queued";
            lbl.ForeColor = System.Drawing.Color.Blue;
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

            this.Text = this.Text + " (attaced to PID " + pid_wow + ")";
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
                        this.Enabled = false;
                    }
                    else
                    {
                        paused = false;
                        this.Enabled = true;
                    }
                }

                if (!paused)
                {
                    NumActiveQueues = getkNumActiveQueues();

                    LfdQueueStatus = Convert.ToUInt32(Memory.Read<uint>(Memory.BaseAddress + Offset.inQueueLFD));
                    LfrQueueStatus = Convert.ToUInt32(Memory.Read<uint>(Memory.BaseAddress + Offset.inQueueLFR));
                    PveQueueReadyStatus = Convert.ToByte(Memory.Read<byte>(Memory.BaseAddress + Offset.isQueueReady));

                    uint bgStatusBase = Convert.ToUInt32(Memory.Read<uint>(Memory.BaseAddress + Offset.bgStatusBase));
                    uint bgStatusNext = Convert.ToUInt32(Memory.Read<uint>(bgStatusBase + Offset.bgStatusNext));
                    Pvp1QueueStatus = Convert.ToInt16(Memory.Read<short>(bgStatusBase + Offset.bgStatus));
                    Pvp2QueueStatus = Convert.ToInt16(Memory.Read<short>(bgStatusNext + Offset.bgStatus));
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
            WoWCommand.sendAntiAFK(hWnd_wow);
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
            Helper.LfgRefresh(lfdModule, 1);
        }

        private void timerLfrRefresh_Tick(object sender, EventArgs e)
        {
            Helper.LfgRefresh(lfrModule, 3);
        }

        private void timerBg1Refresh_Tick(object sender, EventArgs e)
        {
            var bg1 = QueueStats.getBgQeueStats(1);
            int estimatedWait = bg1.estimatedWait / 1000;
            int queuedTime = (System.Environment.TickCount - bg1.queuedTime) / 1000;

            if (estimatedWait != 0)
                lbl_Bg1Wait.Text = Helper.getFormatedTimeString(estimatedWait);
            else
                lbl_Bg1Wait.Text = "n/a";

            lbl_Bg1QueuedTime.Text = Helper.getFormatedTimeString(queuedTime);
        }

        private void timerBg2Refresh_Tick(object sender, EventArgs e)
        {
            var bg2 = QueueStats.getBgQeueStats(2);
            int estimatedWait = bg2.estimatedWait / 1000;
            int queuedTime = (System.Environment.TickCount - bg2.queuedTime) / 1000;

            if (estimatedWait != 0)
                lbl_Bg2Wait.Text = Helper.getFormatedTimeString(estimatedWait);
            else
                lbl_Bg2Wait.Text = "n/a";

            lbl_Bg2QueuedTime.Text = Helper.getFormatedTimeString(queuedTime);
        }
    }
}
