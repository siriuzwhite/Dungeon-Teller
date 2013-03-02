using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dungeon_Teller
{
    class Offset
    {
        public static UInt32 inQueueLFD = 0xD6EA58;
        public static UInt32 inQueueLFR = 0xD6EA90;
        public static UInt32 isQueueReady = 0xD6EAF1;
        public static UInt32 playerName = 0xE28468;
        public static UInt32 playerRealm = 0xE285F6;
        public static UInt32 bgStatusBase = 0xACCAE8;
        public const UInt32 bgStatusNext = 0x4;
        public const UInt32 bgStatus = 0x34;
        public static UInt32 LFGQueueStats = 0xD6EA40;
        public static UInt32 bgTimeBase = 0xACCAE8;
        public const UInt32 bgTimeNext = 0x4;
        public const UInt32 bgTime = 0x22;
        public static UInt32 LfgDungeons = 0xFFCA6C - 0x400000; // g_LfgDungeons from Script_GetLFGQueueStats()

        static Offset()
        {
            /*
            var fields = typeof(Offset).GetFields(BindingFlags.Static | BindingFlags.Public);

            foreach (FieldInfo field in fields)
            {
                var val = field.GetValue(typeof(Offset));
                MessageBox.Show(val.ToString());
                //var rebased = (uint)val - 0x400000;
                //field.SetValue(typeof(Offset), rebased);
            }
             */
        }
    }
}
