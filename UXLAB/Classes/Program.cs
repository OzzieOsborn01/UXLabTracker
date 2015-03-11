using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UXLAB.Classes;

namespace UXLAB
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			SaveLoadManager saveLoad = new SaveLoadManager();
			GoogleInteractions interaction = new GoogleInteractions(ref saveLoad);
			Study study = new Study(ref interaction);
			Form1 mainForm = new Form1(ref interaction, ref study, ref saveLoad);

			Application.Run(new PermissionsForm(ref interaction));
			mainForm.LoadSettings();
			Application.Run(mainForm);
		}
	}
}
