using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace Dungeon_Teller
{
	[XmlRoot("offsets")]
	public class OffsetsXML
	{

		public BaseAddress playerName = new BaseAddress();
		public BaseAddress playerRealm = new BaseAddress();
		public BaseAddress lfgQueueStats = new BaseAddress();
		public BaseAddress lfgProposal = new BaseAddress();
		public BGQueueStats bgQueueStats = new BGQueueStats();
		public DBC dbc = new DBC();

		[Serializable]
		public class BaseAddress
		{
			[XmlIgnore]
			public uint val { get; set; }

			[XmlText]
			public string Value
			{
				get
				{
					return "0x" + val.ToString("x").ToUpper();
				}
				set
				{
					var cmp = value.Substring(0, 2);
					if (cmp == "0x")
					{
						value = value.TrimStart('0', 'x');
						val = uint.Parse(value,
							System.Globalization.NumberStyles.HexNumber);

						if (!rebased)
							val -= 0x400000;

					}
					else
					{
						val = uint.Parse(value);

						if (!rebased)
							val -= 0x400000;
					}
				}
			}

			[XmlAttribute]
			public bool rebased;
		}

		public class SingleOffset
		{
			[XmlIgnore]
			public uint val { get; set; }

			[XmlText]
			public string Value
			{
				get
				{
					return "0x" + val.ToString("x").ToUpper();
				}
				set
				{
					var cmp = value.Substring(0, 2);
					if (cmp == "0x")
					{
						value = value.TrimStart('0', 'x');
						val = uint.Parse(value,
							System.Globalization.NumberStyles.HexNumber);
					}
					else
					{
						val = uint.Parse(value);
					}
				}
			}
		}

		[Serializable]
		public class BGQueueStats
		{
			public BaseAddress BasePtr = new BaseAddress();
			public SingleOffset NextPtr = new SingleOffset();
			public SingleOffset BattleMasterListIdPtr = new SingleOffset();
			public SingleOffset MapId = new SingleOffset();
			public SingleOffset Status = new SingleOffset();
			public SingleOffset EstimatedWait = new SingleOffset();
			public SingleOffset TimeWaited = new SingleOffset();
		}

		[Serializable]
		public class DBC
		{
			public BaseAddress LfgDungeons = new BaseAddress();
			public BaseAddress BattleMasterList = new BaseAddress();
			public BaseAddress Map = new BaseAddress();
		}
	}

	class Offset : OffsetsXML
	{

		static Offset()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(OffsetsXML));
			TextReader reader = new StreamReader("offsets.xml");
			OffsetsXML xml = (OffsetsXML)serializer.Deserialize(reader);

			Offset.playerName = xml.playerName;
			Offset.playerRealm = xml.playerRealm;
			Offset.lfgQueueStats = xml.lfgQueueStats;
			Offset.lfgProposal = xml.lfgProposal;
			Offset.bgQueueStats = xml.bgQueueStats;
			Offset.dbc = xml.dbc;
		}

		new public static BaseAddress playerName;
		new public static BaseAddress playerRealm;
		new public static BaseAddress lfgQueueStats;
		new public static BaseAddress lfgProposal;
		new public static BGQueueStats bgQueueStats;
		new public static DBC dbc;
	}

}

/*
playerName				--> from CE ;)
playerRealm				--> from CE ;)

//LFG Offsets
lfgQueueStats;			--> from GetLFGQueueStats(category)
lfgProposal;			--> from GetLFGProposal()

//Battleground Offsets
BasePtr					--> from GetBattlefieldStatus(index)
NextPtr					--> from GetBattlefieldStatus(index)
BattleMasterListIdPtr	--> from GetBattlefieldStatus(index)
MapId					--> from GetBattlefieldStatus(index)
Status					--> from GetBattlefieldStatus(index)
EstimatedWait			--> from GetBattlefieldEstimatedWaitTime(index)
TimeWaited				--> from GetBattlefieldTimeWaited(index)

//DBC Offsets
lfgDungeons				--> LfgDungeons.dbc from GetLFGQueueStats(category)
battleMasterList		--> BattleMasterList.dbc from GetBattlefieldStatus(index)
map						--> Map.dbc from GetBattlefieldStatus(index)
*/

