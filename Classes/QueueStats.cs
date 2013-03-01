using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Dungeon_Teller
{
    class QueueStats
    {
        static QueueStats()
        {
            LfgDungeons = new DBC<LfgDungeonsRec>(new IntPtr(Offset.LfgDungeons));
        }

        public static DBC<LfgDungeonsRec> LfgDungeons;

        public struct LFGDataStruct
        {
            public int LfgDungeonsId;
            public int myWait;
            public int averageWait;
            public int tankWait;
            public int healerWait;
            public int damageWait;
            public byte tankNeeds;
            public byte healerNeeds;
            public byte dpsNeeds;
            public byte pad0;
            public uint time;
            public int queuedTime;
        }

        public struct BGDataStruct
        {
            public int estimatedWait;
            public int queuedTime;
        }

        public struct LfgDungeonsRec
        {
            public uint m_ID;
            public uint m_name_lang;
            public int m_minLevel;
            public int m_maxLevel;
            public int m_target_level;
            public int m_target_level_min;
            public int m_target_level_max;
            public int m_mapID;
            public int m_randomGroup;
            public int m_flags;
            public int m_typeID;
            public int m_faction;
            public int m_textureFilename;
            public int m_expansionLevel;
            public int m_order_index;
            public int m_group_id;
            public int m_description_lang;
            public int field17;
            public int totalTanks;
            public int totalHealers;
            public int totalDPS;
            public int field21;
            public int m_category; //1=Dungeon;2=Raid;3=Scenario

            public string DungeonName
            {
                get
                {
                    byte[] bytes = Encoding.GetEncoding(0).GetBytes(Memory.Read<string>(m_name_lang));
                    return Encoding.UTF8.GetString(bytes);
                }
            }
        } 

        public static BGDataStruct getBgQeueStats(uint id)
        {
            BGDataStruct bgQueue = new BGDataStruct();
            uint bgTimeCur;
            int i=1;

            bgTimeCur = Convert.ToUInt32(Memory.Read<uint>(Memory.BaseAddress + Offset.bgTimeBase));

            while (i < id)
            {
                bgTimeCur = Convert.ToUInt32(Memory.Read<uint>(bgTimeCur + Offset.bgTimeNext));
                i++;
            }

            if ((bgTimeCur & 1) == 1 || bgTimeCur == 0)
            {
                bgQueue.estimatedWait = 0;
                bgQueue.queuedTime = 0;
            }
            else
            {
                bgQueue.estimatedWait = Convert.ToInt32(Memory.Read<uint>(bgTimeCur + 72));
                bgQueue.queuedTime = Convert.ToInt32(Memory.Read<uint>(bgTimeCur + 76));
            }

            return bgQueue;
        }

        public static LFGDataStruct getLfgQueueStats(uint LE_LFG_CATEGORY)
        {
            LFGDataStruct lfgQueue = new LFGDataStruct();
            uint structSize = (uint)Marshal.SizeOf(lfgQueue);
            lfgQueue = Memory.ReadStruct<LFGDataStruct>( Memory.BaseAddress + Offset.LFGQueueStats + ( structSize * (LE_LFG_CATEGORY - 1) ) );

            return lfgQueue;
        }

    }
}
