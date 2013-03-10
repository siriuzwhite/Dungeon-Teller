using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Dungeon_Teller
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (File.Exists("offsets.xml"))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new ProcessSelector());
			}
			else
				MessageBox.Show("Error: 'offsets.xml' not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

	}
}
