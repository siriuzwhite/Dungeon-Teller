using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SendInputsFuncs
{
    class SendInputs
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, Int32 lParam);
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        public class VK
        {
            public const Int32 ENTER = 0x0D;
            public const Int32 LEFT = 0x25;
            public const Int32 UP = 0x26;
            public const Int32 RIGHT = 0x27;
            public const Int32 DOWN = 0x28;
            public const Int32 F2 = 0x71;
        }
        public class WM
        {
            public const UInt32 BUTTONDOWN = 0x0100;
            public const UInt32 BUTTONUP = 0x0101;
        }
        public static void ButtonDown(Process Process, Int32 Key)
        {
            SendMessage(Process.MainWindowHandle, WM.BUTTONDOWN, Key, IntPtr.Zero);
        }
        public static void ButtonUp(Process Process, Int32 Key)
        {
            SendMessage(Process.MainWindowHandle, WM.BUTTONUP, Key, IntPtr.Zero);
        }
        public static void ButtonType(Process Process, Int32 Key)
        {
            SendMessage(Process.MainWindowHandle, WM.BUTTONDOWN, Key, IntPtr.Zero);
            SendMessage(Process.MainWindowHandle, WM.BUTTONUP, Key, IntPtr.Zero);
        }
    }
}
