using Dungeon_Teller.Classes;
using Dungeon_Teller.Forms.Dialogs;
using DungeonTellerXML;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
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

			OffsetXML remote = Offsets.getRemote<OffsetXML>(settings.OffSetXML);
			UpdateXML update = UpdateXML.getRemote<UpdateXML>(settings.UpdateXML);

			UpdaterDialog updater = new UpdaterDialog();

			DialogResult DownloadMissingXML = new DialogResult();
			DialogResult UpgradeTool = new DialogResult();
			DialogResult UpdateOffsets = new DialogResult();

			int timestamp = (int)((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds);

			if (update != null)
			{
				if (update.msg != "")
				{
					MessageBox.Show(update.msg, "Dungeon Teller - Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				
				if (!File.Exists(settings.OffSetXML))
				{
					DownloadMissingXML = updater.ShowDialog(UpdateState.OffsetsMissing);

					if (DownloadMissingXML == DialogResult.Yes)
					{
						Offsets.writeLocal(remote, settings.OffSetXML);
						Offsets.reinitialize();
						settings.WowVersion = update.wow_version;
						settings.OffsetsLastUpdated = timestamp;
						settings.Save();
					}
					else
					{
						Application.Exit();
					}
				}
				else
				{
					OffsetXML local = Offsets.getLocal<OffsetXML>(settings.OffSetXML);

					if (update.tool_version != Application.ProductVersion)
					{
						UpgradeTool = updater.ShowDialog(UpdateState.UpgradeTool, update.tool_version);

						if (UpgradeTool == DialogResult.Yes)
						{
							Process.Start(update.download_url);
							Application.Exit();
						}

					}
					else if (update.wow_version != settings.WowVersion || settings.OffsetsLastUpdated < update.force_offsets)
					{
						UpdateOffsets = updater.ShowDialog(UpdateState.UpdateOffsets, update.wow_version);

						if (UpdateOffsets == DialogResult.OK)
						{
							Offsets.writeLocal(remote, settings.OffSetXML);
							Offsets.reinitialize();
							settings.WowVersion = update.wow_version;
							settings.OffsetsLastUpdated = timestamp;
							settings.Save();
						}
					}
				}
			}
		}

		private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
