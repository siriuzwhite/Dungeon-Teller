// Shynd's PostMessage.cs

using System;
using System.Text;
using System.Threading;
using System.Collections;
using System.Runtime.InteropServices;

namespace PostMessageFuncs
{
    /// <summary>
    /// Sends keystrokes to the specified window
    /// </summary>
    /// 

    public class PostMessage
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr thWnd, int msg, int wParam, IntPtr lParam);

        /// <summary>
        /// Sends keystrokes to the specified window
        /// </summary>
        /// <param name="hWnd">Window's hWnd</param>
        /// <param name="keys">String of keys to send</param>
        /// <returns>Returns number of keystrokes sent, -1 if an error occurs</returns>
        public bool SendKeys(IntPtr hWnd, string str)
        {
            if (hWnd == null || str.Length == 0)
                return false;

            str.Replace("{SPACE}", Convert.ToChar(0x20).ToString());
            str.Replace("{TAB}", Convert.ToChar(0x9).ToString());
            str.Replace("{ENTER}", Convert.ToChar(0xD).ToString());
            str.Replace("{ESC}", Convert.ToChar(0x1B).ToString());
            str.Replace("{F5}", Convert.ToChar(0x74).ToString());
            str.Replace("{F12}", Convert.ToChar(0x7B).ToString());

            for (int i = 0; i < str.Length; i++)
            {
                SendMessage(hWnd, 0x0102, str[i], IntPtr.Zero);
            }

            return true;
        }
    }
}
