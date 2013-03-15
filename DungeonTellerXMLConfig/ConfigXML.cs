using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DungeonTellerXML
{
	public class ConfigXML
	{
		public static T getRemote<T>(string filename)
		{
			string url = Dungeon_Teller.Properties.Settings.Default.UpdateBaseUrl + filename;
			T remote = default(T);
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.152 Safari/537.22";
			request.Proxy = null;

			try
			{
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				if (response.StatusCode == HttpStatusCode.OK)
				{
					Stream dataStream = response.GetResponseStream();
					StreamReader reader = new StreamReader(dataStream);
					remote = (T)serializer.Deserialize(reader);
					reader.Dispose();
					return remote;
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse response = (HttpWebResponse)ex.Response;
				string msg = String.Format("{0}: {1}", response.StatusDescription, url);
				MessageBox.Show(msg, "Update failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return remote;

		}

		public static T getLocal<T>(string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			TextReader reader = new StreamReader(filename);
			T local = (T)serializer.Deserialize(reader);
			reader.Dispose();

			return local;
		}

		public static void writeLocal<T>(T config, string filename)
		{
			TextWriter writer = new StreamWriter(filename);

			XmlSerializer serializer = new XmlSerializer(typeof(T));
			serializer.Serialize(writer, config);
			writer.Dispose();
		}

	}
}
