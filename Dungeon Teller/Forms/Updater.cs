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

			UpdateXML update = UpdateXML.getRemote<UpdateXML>();
			OffsetXML remote;

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
						remote = Offsets.getRemote<OffsetXML>( String.Format("offset={0}", update.wow_version) );
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
							invokeUpdate(update);
						}

					}
					else if (update.wow_version != settings.WowVersion || settings.OffsetsLastUpdated < update.force_offsets)
					{
						UpdateOffsets = updater.ShowDialog(UpdateState.UpdateOffsets, update.wow_version);

						if (UpdateOffsets == DialogResult.OK)
						{
							remote = Offsets.getRemote<OffsetXML>(String.Format("offset={0}", update.wow_version));
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

		public void invokeUpdate(UpdateXML update)
		{
			Directory.CreateDirectory("temp");
			ConfigXML.writeLocal<UpdateXML>(update, "temp\\update.xml");
			foreach (string newPath in Directory.GetFiles("libs", "*.*"))
				File.Copy(newPath, newPath.Replace("libs", "temp"), true);

			UpdateStarter.start("update");
			Application.Exit();
		}

		private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
