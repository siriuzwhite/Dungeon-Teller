using Dungeon_Teller.Classes;
using Dungeon_Teller.Classes.Config;
using Dungeon_Teller.Forms.Dialogs;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Dungeon_Teller.Forms
{
	public partial class Updater : Form
	{
		Properties.Settings settings = Properties.Settings.Default;

		public Updater()
		{
			InitializeComponent();
		}

		private void Updater_Shown(object sender, EventArgs e)
		{
			worker.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			OffsetXML local = Offsets.getLocal<OffsetXML>(Offsets.filename);
			OffsetXML remote = Offsets.getRemote<OffsetXML>(Offsets.filename);
			UpdateXML update = UpdateXML.getRemote<UpdateXML>(UpdateXML.filename);

			int timestamp = (int)((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds);


			if (update != null)
			{
				UpdaterDialog updater = new UpdaterDialog();
				DialogResult result_wow = new DialogResult();
				DialogResult result_tool = new DialogResult();

				if (update.msg != "")
				{
					MessageBox.Show(update.msg, "Dungeon Teller - Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (update.tool_version != Application.ProductVersion)
				{
					result_tool = updater.ShowDialog(update.tool_version, "");

					if (result_tool == DialogResult.OK)
					{
						Process.Start(update.download_url);
						Application.Exit();
					}

				}
				else if (update.wow_version != settings.WowVersion || settings.ForceOffsets < update.force_offsets)
				{
					result_wow = updater.ShowDialog("", update.wow_version);

					if (result_wow == DialogResult.OK)
					{
						Offsets.writeLocal(remote, Offsets.filename);
						Offsets.reinitialize();
						settings.WowVersion = update.wow_version;
						settings.ForceOffsets = timestamp;
						settings.Save();
					}
				}
			}
		}

		private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Close();
		}
	}
}
