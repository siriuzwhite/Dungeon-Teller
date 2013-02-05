using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
using EASendMail;
using System.Messaging;
using System.Windows.Forms;

namespace Dungeon_Teller
{
    class Notification
    {
        public static void pushProwl(string prowlApiKey, string prowlEvent, string prowlMessage)
        {
            WebClient wb = new WebClient();
            NameValueCollection data = new NameValueCollection();

            data["apikey"] = prowlApiKey;
            data["application"] = "Dungeon Teller";
            data["event"] = prowlEvent;
            data["description"] = prowlMessage;

            Byte[] response = wb.UploadValues("https://api.prowlapp.com/publicapi/add", "POST", data);
        }

        public static void pushNMA(string nmaApiKey, string nmaEvent, string nmaMessage)
        {
            WebClient wb = new WebClient();
            NameValueCollection data = new NameValueCollection();

            data["apikey"] = nmaApiKey;
            data["application"] = "Dungeon Teller";
            data["event"] = nmaEvent;
            data["description"] = nmaMessage; 

            Byte[] response = wb.UploadValues("https://www.notifymyandroid.com/publicapi/notify", "POST", data);
        }

        public static void sendMail(string toAddress, string subject, string message)
        {
            SmtpMail mail = new SmtpMail("TryIt"); 
            SmtpClient smtp = new SmtpClient(); 

            mail.From = "Dungeon Teller <dungeon-teller@localhost>"; 
            mail.To = toAddress;
            mail.Subject = subject;
            mail.TextBody = message;

            SmtpServer server = new SmtpServer(""); 
            try 
            { 
                smtp.SendMail(server, mail); 
            } 
            catch (Exception ep) 
            {
                MessageBox.Show("Failed to send email with the following error:" + ep.Message); 
            }        
        }
    }
}
