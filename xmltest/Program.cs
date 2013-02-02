using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using RemoteConfig;
using System.Net;

namespace xmltest
{
    class Program
    {
        static void Main(string[] args)
        {


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dungeonteller.ohost.de/RemoteConfig.xml");
            request.Proxy = null;

            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            XmlSerializer serializer = new XmlSerializer(typeof(Config));

            Config config = (Config)serializer.Deserialize(reader);

            UInt32 test = config.offsets.inQueueLFD;

            Console.WriteLine(test);
            Console.Read();

            /*

            TextWriter writer = new StreamWriter("remoteconfig.xml");

            Config config = new Config();
            Offsets offsets = new Offsets();

            offsets.inQueueLFD = 0xD6EA58;
            offsets.inQueueLFR = 0xD6EA90;
            offsets.isQueueReady = 0xD6EAF1;
            offsets.playerName = 0xE28468;
            offsets.playerRealm = 0xE285F6;

            config.offsets = offsets;

            XmlSerializer serialize = new XmlSerializer(typeof(Config));
            serialize.Serialize(writer, config);
            writer.Close();
            Console.Read();
             */


        }
    }

}
