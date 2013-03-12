using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Dungeon_Teller
{
	public partial class DesktopNotification : Form
	{
		public DesktopNotification()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(costumArguments arg)
		{
			lbl_heading.Text = arg.queueReadyName;
			lbl_desc.Text = String.Format("Your queue for '{0}' is now ready!", arg.mapName);
			pic_image.Image = arg.image;

			return this.ShowDialog();
		}

		public class costumArguments
		{

			public costumArguments(Image image, string queueReadyName, string mapName)
			{
				this.image = image;
				this.queueReadyName = queueReadyName;
				this.mapName = mapName;
			}

			public Image image;
			public string queueReadyName;
			public string mapName;
		}

		private void link_rep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.ownedcore.com/forums/reputation.php?do=addreputation&p=2657518");
			Properties.Settings.Default.HasContributed = true;
		}

	}
}
