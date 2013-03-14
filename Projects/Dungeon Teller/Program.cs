using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Dungeon_Teller.Classes;
using Dungeon_Teller.Forms;

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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new DungeonTellerMain());
		}
	}
}
