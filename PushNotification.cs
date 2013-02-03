using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;

namespace Dungeon_Teller
{
    class PushNotification
    {

        public static void sendMessageProwl(string dtMessage, string dtAPIKey, string dtEvent)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["apikey"] = dtAPIKey;
                data["event"] = dtEvent;
                data["application"] = "Dungeon Teller";
                data["description"] = dtMessage;

                var response = wb.UploadValues("https://api.prowlapp.com/publicapi/add", "POST", data);
            }
        }

        public static void sendMessageNMA(string dtMessage, string dtAPIKey, string dtEvent)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["apikey"] = dtAPIKey;
                data["event"] = dtEvent;
                data["application"] = "Dungeon Teller";
                data["description"] = dtMessage; 

                var response = wb.UploadValues("https://www.notifymyandroid.com/publicapi/notify", "POST", data);
            }
        }
    }
}
