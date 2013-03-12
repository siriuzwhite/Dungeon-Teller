using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Dungeon_Teller.Forms.Dialogs
{
	public partial class UpdaterDialog : Form
	{
		public UpdaterDialog()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(string tool_version, string wow_version)
		{
			if (tool_version != "")
			{
				lbl_desc.Text = String.Format("Dungeon Teller v{0} is available. Do you want to open the download site?", tool_version);
			}
			else if (wow_version != "")
			{
				lbl_desc.Text = String.Format("New offsets for WoW {0} are available. Do you want to update them?", wow_version);
			}

			return this.ShowDialog();
		}

		private void link_rep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.ownedcore.com/forums/reputation.php?do=addreputation&p=2657518");
			Properties.Settings.Default.HasContributed = true;
		}
	}
}
