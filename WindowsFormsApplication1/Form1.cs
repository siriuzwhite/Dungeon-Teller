using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using PostMessageFuncs;
using SendInputsFuncs;
using MessageHelperFunc;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr thWnd, int msg, int wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "MapVirtualKey")]
        private static extern int _MapVirtualKey(int uCode, int uMapType);

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] pr = Process.GetProcessesByName("wow");
            int pid = pr[0].Id;

            IntPtr wow = Process.GetProcessById(pid).MainWindowHandle;
            /*
            int result = 0;
            MessageHelper msg = new MessageHelper();

            int hWnd = msg.getWindowId(null, "Unbekannt - Edito");
            result = msg.sendWindowsStringMessage(hWnd, 0, "Test");

            result = msg.sendWindowsMessage(hWnd, MessageHelper.WM_USER, 123, 456);

            //SendMessage(wow, 97, 0, 0);
             */

            /*
            int ShiftVirtualKey = 1;
            ShiftVirtualKey = _MapVirtualKey(14, 0);
            MessageBox.Show(ShiftVirtualKey.ToString());
            int VR_a = 1;
            VR_a =_MapVirtualKey(97, 0);
            MessageBox.Show(VR_a.ToString());

            //SendInputs.ButtonDown(pr[0], ShiftVirtualKey);
            SendInputs.ButtonType(pr[0], 97);
            //SendInputs.ButtonUp(pr[0], ShiftVirtualKey);
            */

            //const uint WM_PASTE = 0x0302;

            const int VK_CONTROL = 0xA2;
            const int WM_KEYDOWN = 0x100;
            const int WM_KEYUP = 0x101;
            const int VK_RETURN = 0x0D;
            const int VK_SPACE = 0x20;


            SendMessage(wow, WM_KEYDOWN, VK_SPACE, IntPtr.Zero);
            SendMessage(wow, WM_KEYUP, VK_SPACE, IntPtr.Zero);




            //PostMessage pm = new PostMessage();
            //pm.SendKeys(wow, "{SPACE}");
            //pm.ArrowKey(wow, "left", 500);
            //pm.SendKeys(wow, "aBcDefgh");


        }
    }


}
