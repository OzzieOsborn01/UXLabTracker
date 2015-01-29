using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UXLAB
{
	public partial class PermissionsForm : Form
	{
		public PermissionsForm(ref GoogleInteractions Interaction)
		{
			InitializeComponent();

			linkLabel1.Text = "Click on this link\nAccept the permissions and copy the text into the text box below.";

			interaction = Interaction;
		}

		private void LinkedClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel1.LinkVisited = true;			

			System.Diagnostics.Process.Start(interaction.CPGetAuthorizationURL());
		}

		GoogleInteractions interaction;

		private void LoadPrev(object sender, EventArgs e)
		{
			interaction.CPReadAuthorization();
			this.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			TextBox tBox = (TextBox)sender;
			if(tBox.Text.Length > 0)
			{
				button2.Enabled = true;
			}
			else
			{
				button2.Enabled = false;
			}

		}

		private void ConfirmAuthorization(object sender, EventArgs e)
		{
			interaction.CPGetAuthorization(textBox1.Text);

			this.Close();
		}
	}
}
