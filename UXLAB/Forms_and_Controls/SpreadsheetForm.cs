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
	public partial class SpreadsheetForm : Form
	{
		Form1 rootForm;
		public SpreadsheetForm(ref GoogleInteractions Interaction, ref Form1 mainForm)
		{
			InitializeComponent();
			interaction = Interaction;
			rootForm = mainForm;
		}

		public void LoadSettingsFromForm()
		{

		}
		public void SaveSettingsToForm()
		{

		}

		private void FindWorkbook(object sender, EventArgs e)
		{
			FindWorkbookCheck();
		}
		private void FindWorkbookCheck()
		{
			if (workbook1.Text.Length < 0)
			{
				WBNotFound1.Visible = true;
				WBNotFound1.Text = "Workbook not found.";
				WBNotFound1.ForeColor = Color.DarkOrange;
			}
			else if (!interaction.FindWorkbook(workbook1.Text))
			{
				WBNotFound1.Visible = true;
				WBNotFound1.Text = "Workbook not found.";
				WBNotFound1.ForeColor = Color.DarkOrange;
			}
			else
			{
				WBNotFound1.Visible = true;
				WBNotFound1.Text = "Workbook found.";
				WBNotFound1.ForeColor = Color.LimeGreen;
			}
		}

		GoogleInteractions interaction;

		#region Worksheets
		private void FindStudyWorksheet(object sender, EventArgs e)
		{
			FindWorksheetCheck(worksheet1, WSNotFoundS, GoogleInteractions.Worksheet.Study);
		}
		private void FindParticipantWorksheet(object sender, EventArgs e)
		{
			FindWorksheetCheck(worksheet2, WSNotFoundP, GoogleInteractions.Worksheet.Participant);
		}
		private void FindWorksheetCheck(TextBox wsTextBox, Label wsNotFound, GoogleInteractions.Worksheet type)
		{
			if (wsTextBox.Text.Length < 0)
			{
				wsNotFound.Visible = true;
				wsNotFound.Text = "Worksheet not found.";
				wsNotFound.ForeColor = Color.DarkOrange;
			}
			else if (!interaction.FindWorksheet(wsTextBox.Text, type))
			{
				wsNotFound.Visible = true;
				wsNotFound.Text = "Worksheet not found.";
				wsNotFound.ForeColor = Color.DarkOrange;
			}
			else
			{
				wsNotFound.Visible = true;
				wsNotFound.Text = "Worksheet found.";
				wsNotFound.ForeColor = Color.LimeGreen;
			}
		}
	
		#endregion
		#region Cells
		private void FindStudyCellsCheck(TextBox cellTextBox, Label cellNotFound, GoogleInteractions.Cell type)
		{
			if (cellTextBox.Text.Length < 0 || type == GoogleInteractions.Cell.Max)
			{
				cellNotFound.Visible = true;
				cellNotFound.Text = "Cell not found.";
				cellNotFound.ForeColor = Color.DarkOrange;
			}
			else if (!interaction.FindCell(cellTextBox.Text, GoogleInteractions.Worksheet.Study, type))
			{
				cellNotFound.Visible = true;
				cellNotFound.Text = "Cell not found.";
				cellNotFound.ForeColor = Color.DarkOrange;
			}
			else
			{
				cellNotFound.Visible = true;
				cellNotFound.Text = "Cell found.";
				cellNotFound.ForeColor = Color.LimeGreen;
			}
		}

		#endregion
		private void EnterPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				Type senderType = sender.GetType();
				if (senderType.Name == "NumericUpDown")
				{
					NumericUpDown upDown = (NumericUpDown)sender;
					if (upDown.Name == "cellOffset")
					{
						return;
					}
				}
				else if (senderType.Name == "TextBox")
				{
					TextBox textBox = (TextBox)sender;
					string textBoxName = textBox.Name;

					if (textBoxName == "workbook1")
					{
						FindWorkbookCheck();
					}
					else if (textBoxName == "worksheet1")
					{
						FindWorksheetCheck(worksheet1, WSNotFoundS, GoogleInteractions.Worksheet.Study);
					}
					else if (textBoxName == "worksheet2")
					{
						FindWorksheetCheck(worksheet2, WSNotFoundP, GoogleInteractions.Worksheet.Participant);
					}
					else if (textBoxName == "nameCell")
					{
						FindStudyCellsCheck(nameCell, CellNotFoundN, GoogleInteractions.Cell.Name);
						nameResults.Text = interaction.ReadStudyCell(GoogleInteractions.Cell.Name);
						//string test = ParentForm.GetType().ToString();
						//int count = test.Length;
						//count += 1;
					}
					else if (textBoxName == "durationCell")
					{
						FindStudyCellsCheck(durationCell, CellNotFoundDur, GoogleInteractions.Cell.Duration);
						durationResults.Text = interaction.ReadStudyCell(GoogleInteractions.Cell.Duration);
					}
					else if (textBoxName == "completedCell")
					{
						FindStudyCellsCheck(completedCell, CellNotFoundC, GoogleInteractions.Cell.Completed);
						completedResults.Text = interaction.ReadStudyCell(GoogleInteractions.Cell.Completed);
					}
					else if (textBoxName == "desiredCell")
					{
						FindStudyCellsCheck(desiredCell, CellNotFoundDes, GoogleInteractions.Cell.Desired);
						desiredResults.Text = interaction.ReadStudyCell(GoogleInteractions.Cell.Desired);
					}
					else if (textBoxName == "totalCell")
					{
						FindStudyCellsCheck(totalCell, CellNotFoundT, GoogleInteractions.Cell.Total);
						totalResults.Text = interaction.ReadStudyCell(GoogleInteractions.Cell.Total);
					}
					else if (textBoxName == "nowCell")
					{
						FindStudyCellsCheck(nowCell, CellNotFoundNw, GoogleInteractions.Cell.Now);
						nowResults.Text = interaction.ReadStudyCell(GoogleInteractions.Cell.Now);
					}
					else if (textBoxName == "participantCollection")
					{
						interaction.Dimension = participantCollection.Text;
						interaction.Offset = (int)cellOffset.Value;
						return;

					}
				}
				
			}
		}

		private void UseColumns(object sender, EventArgs e)
		{
			interaction.BUseColumns = checkBox1.Checked;
		}
	}
}
