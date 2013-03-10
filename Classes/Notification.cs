using System;
using System.Collections.Specialized;
using System.Net;
using EASendMail;
using System.Windows.Forms;

namespace Dungeon_Teller
{
	class Notification
	{
		public static void sendPushOver(string userKey, string title, string message)
		{
			WebClient client = new WebClient();
			NameValueCollection data = new NameValueCollection();

			var parameters = new NameValueCollection {
                { "token", "X52StO16VHy9Jho2mac2G0RNNJD6qP" },
                { "user", userKey },
                { "title", title },
                { "message", message }
            };

			client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
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
