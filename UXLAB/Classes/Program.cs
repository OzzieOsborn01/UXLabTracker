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

			GoogleInteractions interaction = new GoogleInteractions();
			Study study = new Study(ref interaction);
			Form1 mainForm = new Form1(ref interaction, ref study);

			Application.Run(new PermissionsForm(ref interaction));
			Application.Run(mainForm);
		}
	}
}
