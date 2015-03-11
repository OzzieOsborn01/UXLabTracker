using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UXLAB.Classes;
using System.Xml.Linq;

namespace UXLAB
{
	//This is the primary form that the user will see.
	public partial class Form1 : Form
	{
		public enum Cell { Min = 0, Name = 0, Duration = 1, Completed = 2, Desired = 3, Total = 4, Now = 5, Max = 6 };
		public enum FormComponents { Workbook, StudySheet, ParticipantSheet, Name, Duration, Completed, Desired,
			Total, Now, TestTimes, Offsets, UseColumns, EnumTotals};

		#region General Functions
		public Form1(ref GoogleInteractions Interaction, ref Study Study, ref SaveLoadManager SaveLoad)
		{
			InitializeComponent();

			//Attach Participant Controls to form in array form
			participantControls = new ParticipantControl[] { participantControl1, participantControl2, participantControl3, participantControl4, participantControl5, 
				participantControl6, participantControl7, participantControl8, participantControl9};
			interaction = Interaction;
			int index = 0;
			spreadsheetForm = null;
			study = Study;
			saveLoad = SaveLoad;
			studyComponents = new ComponentsLocations();

			//For each control attach Form method to event
			//May need to be removed or not needed
			foreach(ParticipantControl control in participantControls)
			{
				control.Start.Click += start_Click;
				control.Finish.Click += finish_Click;
				control.NotFinish.Click += notfinished_Click;
				control.Timer.Tick += timer_Tick;
				control.Index = index++;
				control.MainForm = this;
			}


			resetParticipants_Click(this, EventArgs.Empty);
		}
		internal string GetName()
		{
			return acronymText.Text;
		}		
		#endregion


		#region Previous Version Code
		//Every time a participant timer ticks
		//- partially legacy code but may be necessary for future features 
		private void timer_Tick(object sender, EventArgs e)
		{
			//int index = int.Parse((string)((System.Windows.Forms.Timer)sender).Tag) - 1;//int.Parse(((Button)sender).AccessibleDescription) - 1;
			//
			//if (countdowns[index].timeLeft > 0)
			//{
			//	countdowns[index].timeLeft = countdowns[index].timeLeft - 1;
			//
			//	participantControls[index].Status.BackColor = Color.OrangeRed;
			//	timespan = TimeSpan.FromSeconds(countdowns[index].timeLeft);
			//	string time = string.Format("{0:D2}:{1:D2}",
			//	timespan.Minutes,
			//	timespan.Seconds);
			//	participantControls[index].Timer_Text.Text = time;
			//	participantControls[index].ProgressBar.Value = countdowns[index].duration - countdowns[index].timeLeft;
			//}
			//else if (countdowns[index].timeLeft == 0)
			//{
			//	countdowns[index].timeLeft = countdowns[index].timeLeft - 1;
			//
			//	participantControls[index].Status.BackColor = Color.Yellow;
			//	countdowns[index].timerRef.Stop();
			//	participantControls[index].Timer_Text.Text = "SURV.";
			//	participantControls[index].Finish.Enabled = true;
			//	participantControls[index].NotFinish.Enabled = false;
			//}
		}

		private void start_Click(object sender, EventArgs e)
		{
			//int index = int.Parse(((Button)sender).AccessibleDescription) - 1;
			//
			//participantControls[index].ProgressBar.Maximum = (int)playtestDuration.Value * 60;
			//countdowns[index].duration = (int)playtestDuration.Value * 60;
			//countdowns[index].timeLeft = (int)playtestDuration.Value * 60;
			//participantControls[index].Start.Enabled = false;
			//participantControls[index].Finish.Enabled = false;
			//participantControls[index].NotFinish.Enabled = true;
			//countdowns[index].timerRef.Start();

		}
		
		private void notfinished_Click(object sender, EventArgs e)
		{
			//current_participant++;
			//int index = int.Parse(((Button)sender).AccessibleDescription) - 1;
			//countdowns[index].timerRef.Stop();
			//notfinishedList.Items.Add(participantControls[index].ParticipantName);
			//participantControls[index].Timer_Text.Text = "00:00";
			//participantControls[index].Start.Enabled = true;
			//participantControls[index].Finish.Enabled = false;
			//participantControls[index].NotFinish.Enabled = false;
			//participantControls[index].Status.BackColor = Color.YellowGreen;
			//participantControls[index].ProgressBar.Value = 0;
			//participantControls[index].ParticipantName = acronym + "_" + current_participant.ToString();
		}
		#endregion


		#region Communication with SpreadsheetForms
		//When the participant finishes
		private void finish_Click(object sender, EventArgs e)
		{
			participantProgress.Text = "Participant Progress: " + finishedParticipants.ToString() + "/" + numOfParticipants.Value.ToString();
			participantProgressBar.Maximum = (int)numOfParticipants.Value;
			participantProgressBar.Value = finishedParticipants;

		}		
		private void OpenSpreadsheetOptions(object sender, EventArgs e)
		{
			if (spreadsheetForm == null)
			{
				Form1 temp = this;
				spreadsheetForm = new SpreadsheetForm(ref interaction, ref temp);
				spreadsheetForm.Show();
				spreadsheetForm.LoadSettingsFromForm();
				spreadsheetForm.FormClosed += SpreadsheetClose;
			}
		}

		public void SpreadsheetClose(object sender, EventArgs e)
		{
			spreadsheetForm = null;
		}
		#endregion

		#region Communication with Study
		public void UpdateParticipant(int participantNum)
		{
			study.UpdateParticipants(participantNum);
		}

		public void ParticipantNotFinished(int participantNumber)
		{
			CurrParticipant++;
			study.ParticipantNotFinished(participantNumber);
		}

		private void resetParticipants_Click(object sender, EventArgs e)
		{
			notfinishedList.Items.Clear();
			finishedParticipants = 0;
			current_participant = 8;
			for (int i = 0; i < 8; ++i)
			{
				acronym = acronymText.Text;
				participantControls[i].ParticipantName = acronym + "_" + (i+1).ToString();
				
			}
		}
		
		public int StartParticipant(ref ParticipantControl control)
		{
			return study.AddParticipant(ref control);
		}
		#endregion

		#region Communication with Participant Controls
		
		public void GetParticipantControl(int index, out ParticipantControl control)
		{
			control = participantControls[index];
		}
		#endregion


		#region Future Functions
		public Participant GetParticipant(int participantNum)
		{
		 return null;
		}
		#endregion


		#region Variables and Accessors
		SpreadsheetForm spreadsheetForm;
		
		string acronym = "NAME"; //Name of the Study
		int current_participant = 9; // Number of current participants
		ParticipantControl[] participantControls; // array of participant controls
		Study study;
		GoogleInteractions interaction; // Interface to interact with Google spreadsheets 
		//Legacy Variables
		//PictureBox[] status;
		//ProgressBar[] progress;
		//Label[] timers;
		//Label[] participants;
		//Button[] starts;
		//Button[] finishes;
		//Button[] notfinishes;
		int finishedParticipants = 35; // Participants that have finished

		string[] componentsValues;
		bool[] componentsValid;
		private ComponentsLocations studyComponents;
		private SaveLoadManager saveLoad;

		public ComponentsLocations StudyComponents
		{
			get { return studyComponents; }
			set { studyComponents = value; }
		}
		

		//Accessors and Mutators
		public int CurrParticipant
		{
			get { return current_participant; }
			set { current_participant = value; }
		}
		public int FinishedParticipant
		{
			get { return finishedParticipants; }
			set { finishedParticipants = value; }
		}
		public string Acronym
		{
			get { return acronym; }
		}
		public decimal Duration
		{
			get
			{
				return playtestDuration.Value;
			}
		}

		//public countdown[] CountDowns
		//{
		//	get { return countdowns; }
		//}
		//public countdown[] CountDowns
		//{
		//	get { return countdowns; }
		//} 
		#endregion



		private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveLoad.WriteStudyComponents(studyComponents);
		}
		public void SaveSettings()
		{
			saveLoad.WriteStudyComponents(studyComponents);
		}

		public void LoadSettings()
		{
			saveLoad.ReadStudyComponents(ref studyComponents);

			interaction.FindWorkbook(studyComponents.Workbook);
			interaction.FindWorksheet(studyComponents.StudySheet,GoogleInteractions.Worksheet.Study);
			interaction.FindWorksheet(studyComponents.ParticipantSheet, GoogleInteractions.Worksheet.Participant);
			interaction.FindCell(studyComponents.Now,GoogleInteractions.Worksheet.Study, Cell.Now);
			interaction.FindCell(studyComponents.Name, GoogleInteractions.Worksheet.Study, Cell.Name);
			interaction.FindCell(studyComponents.Duration, GoogleInteractions.Worksheet.Study, Cell.Duration);
			interaction.FindCell(studyComponents.Total, GoogleInteractions.Worksheet.Study, Cell.Total);
			interaction.FindCell(studyComponents.Completed, GoogleInteractions.Worksheet.Study, Cell.Completed);
			interaction.FindCell(studyComponents.Desired, GoogleInteractions.Worksheet.Study, Cell.Desired);
			interaction.Dimension = studyComponents.TestTimes;
			interaction.Offset = Int32.Parse(studyComponents.Offsets);
			interaction.BUseColumns = Boolean.Parse(studyComponents.UseColumns);


			study.CommunityNow = DateTime.Parse(interaction.ReadStudyCell(Cell.Now));
			study.CurrComponents.Name = interaction.ReadStudyCell(Cell.Name);
			study.CurrComponents.Duration = new TimeSpan(0,Int32.Parse(interaction.ReadStudyCell(Cell.Duration)),0);
			study.CurrComponents.Total = Int32.Parse(interaction.ReadStudyCell(Cell.Total));
			study.CurrComponents.Completed = Int32.Parse(interaction.ReadStudyCell(Cell.Completed));
			study.CurrComponents.Desired = Int32.Parse(interaction.ReadStudyCell(Cell.Desired));
		}

	}

	public class ComponentsLocations
	{
		public ComponentsLocations()
		{
			Workbook = "";
			StudySheet = "";
			ParticipantSheet = "";
			Name = "A1";
			Duration = "A1";
			UseColumns = "True";
			Offsets = "1";
			TestTimes = "A";
			Now = "A1";
			Total = "A1";
			Completed = "A1";
		}

		public string GetComponent(Form1.FormComponents component)
		{
			switch (component)
			{
				case Form1.FormComponents.Workbook:
					return Workbook;
				case Form1.FormComponents.StudySheet:
					return StudySheet;
				case Form1.FormComponents.ParticipantSheet:
					return ParticipantSheet;
				case Form1.FormComponents.Name:
					return Name;
				case Form1.FormComponents.Duration:
					return Duration;
				case Form1.FormComponents.Completed:
					return Completed;
				case Form1.FormComponents.Desired:
					return Desired;
				case Form1.FormComponents.Total:
					return Total;
				case Form1.FormComponents.Now:
					return Now;
				case Form1.FormComponents.TestTimes:
					return TestTimes;
				case Form1.FormComponents.Offsets:
					return Offsets;
				case Form1.FormComponents.UseColumns:
					return UseColumns;
				default:
					return null;
			}
		}

		public string Workbook;
		public string StudySheet;
		public string ParticipantSheet;
		public string Name;
		public string Duration;
		public string UseColumns;
		public string Offsets;
		public string TestTimes;
		public string Now;
		public string Total;
		public string Completed;
		public string Desired;
	}
}
