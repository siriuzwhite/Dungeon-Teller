using System.Xml.Serialization;

namespace DungeonTellerXML
{
	[XmlRoot("update")]
	public class UpdateXML : ConfigXML
	{
		public string wow_version;
		public string tool_version;
		public int force_offsets;
		public string download_url;
		public string msg;
	}
}
