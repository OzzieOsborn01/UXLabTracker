using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UXLAB.Classes;

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
			nameCell.Text				= rootForm.StudyComponents.Name							;
			durationCell.Text			= rootForm.StudyComponents.Duration						;
			completedCell.Text			= rootForm.StudyComponents.Completed					;
			totalCell.Text				= rootForm.StudyComponents.Total						;
			nowCell.Text				= rootForm.StudyComponents.Now							;
			desiredCell.Text			= rootForm.StudyComponents.Desired						;
			workbook1.Text				= rootForm.StudyComponents.Workbook						;
			worksheet1.Text				= rootForm.StudyComponents.StudySheet					;
			worksheet2.Text				= rootForm.StudyComponents.ParticipantSheet				;
			participantCollection.Text	= rootForm.StudyComponents.TestTimes					;
			cellOffset.Value			= Decimal.Parse(rootForm.StudyComponents.Offsets)		;
			checkBox1.Checked			= Boolean.Parse(rootForm.StudyComponents.UseColumns)	;
		}
		public void SaveSettingsToForm()
		{
			rootForm.StudyComponents.Name				= nameCell.Text					;
			rootForm.StudyComponents.Duration			= durationCell.Text				;
			rootForm.StudyComponents.Completed			= completedCell.Text			;
			rootForm.StudyComponents.Total				= totalCell.Text				;
			rootForm.StudyComponents.Now				= nowCell.Text					;
			rootForm.StudyComponents.Desired			= desiredCell.Text				;
			rootForm.StudyComponents.Workbook			= workbook1.Text				;
			rootForm.StudyComponents.StudySheet			= worksheet1.Text				;
			rootForm.StudyComponents.ParticipantSheet	= worksheet2.Text				;
			rootForm.StudyComponents.TestTimes			= participantCollection.Text	;
			rootForm.StudyComponents.Offsets			= cellOffset.Value.ToString()	;
			rootForm.StudyComponents.UseColumns			= checkBox1.Checked.ToString()	;
			rootForm.SaveSettings();
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
		private void FindStudyCellsCheck(TextBox cellTextBox, Label cellNotFound, Form1.Cell type)
		{
			if (cellTextBox.Text.Length < 0 || type == Form1.Cell.Max)
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
						interaction.Offset = (int)upDown.Value;
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
						FindStudyCellsCheck(nameCell, CellNotFoundN, Form1.Cell.Name);
						nameResults.Text = interaction.ReadStudyCell(Form1.Cell.Name);
						//string test = ParentForm.GetType().ToString();
						//int count = test.Length;
						//count += 1;
					}
					else if (textBoxName == "durationCell")
					{
						FindStudyCellsCheck(durationCell, CellNotFoundDur, Form1.Cell.Duration);
						durationResults.Text = interaction.ReadStudyCell(Form1.Cell.Duration);
					}
					else if (textBoxName == "completedCell")
					{
						FindStudyCellsCheck(completedCell, CellNotFoundC, Form1.Cell.Completed);
						completedResults.Text = interaction.ReadStudyCell(Form1.Cell.Completed);
					}
					else if (textBoxName == "desiredCell")
					{
						FindStudyCellsCheck(desiredCell, CellNotFoundDes, Form1.Cell.Desired);
						desiredResults.Text = interaction.ReadStudyCell(Form1.Cell.Desired);
					}
					else if (textBoxName == "totalCell")
					{
						FindStudyCellsCheck(totalCell, CellNotFoundT, Form1.Cell.Total);
						totalResults.Text = interaction.ReadStudyCell(Form1.Cell.Total);
					}
					else if (textBoxName == "nowCell")
					{
						FindStudyCellsCheck(nowCell, CellNotFoundNw, Form1.Cell.Now);
						nowResults.Text = interaction.ReadStudyCell(Form1.Cell.Now);
					}
					else if (textBoxName == "participantCollection")
					{
						interaction.Dimension = participantCollection.Text;
						interaction.Offset = (int)cellOffset.Value;
						return;
					}
				}
				SaveSettingsToForm();
			}
		}

		private void UseColumns(object sender, EventArgs e)
		{
			interaction.BUseColumns = checkBox1.Checked;
		}
	}
}
