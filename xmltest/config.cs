using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteConfig
{
    public class Config
    {
        public Offsets offsets;
    }

    public class Offsets
    {
        public UInt32 inQueueLFD;
        public UInt32 inQueueLFR;
        public UInt32 isQueueReady;
        public UInt32 playerName;
        public UInt32 playerRealm;
    }
}
