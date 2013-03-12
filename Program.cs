using Dungeon_Teller.Classes;
using Dungeon_Teller.Classes.Config;
using Dungeon_Teller.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Dungeon_Teller
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		[STAThread]
		static void Main()
		{
			Properties.Settings.Default.TimesRun++;

			if (File.Exists(Offsets.filename))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				if (Properties.Settings.Default.CheckForUpdates)
				{
					Application.Run(new Updater());
				}

				Application.Run(new ProcessSelector());
			}
			else
				MessageBox.Show("Error: '" + Offsets.filename + "' not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

	}
}
