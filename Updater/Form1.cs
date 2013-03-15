using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{

			/*
			var url = "https://winauth.googlecode.com/files/WinAuth-2.0.8.zip";
			var client = new WebClient();
			var buffer = client.DownloadData(url);
			var stream = new MemoryStream(buffer);

			var zip = ZipFile.Read(stream);
			foreach (var entry in zip)
			{
				entry.Extract(".");
			}
			*/

			//Now prepare your message.
			MailMessage mail = new MailMessage();
			mail.To.Add("lore@lorus5123.org");
			mail.From = new MailAddress("lore@lorus.org");
			mail.Subject = "Send email without SMTP server";
			mail.Body = "Yep, its workin!!!!";

			try
			{
				//Send message
				string domain = mail.To[0].Address.Substring(mail.To[0].Address.IndexOf('@') + 1);
				//To Do :need to check for MX record existance before you send. Left intentionally for you.
				string mxRecord = SendSMTP.DnsLookUp.GetMXRecords(domain)[0];
				SmtpClient client = new SmtpClient(mxRecord);
				client.Send(mail);
			}
			catch (Exception ex)
			{
				MessageBox.Show(String.Format("Failed to send email with the following error:\n'{0}'", ex.Message),"Mail-Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
