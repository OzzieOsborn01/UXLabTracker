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

namespace UXLAB
{
	public partial class Form1 : Form
	{
		public Form1(ref GoogleInteractions Interaction, ref Study Study)
		{
			InitializeComponent();
			participantControls = new ParticipantControl[] { participantControl1, participantControl2, participantControl3, participantControl4, participantControl5, 
				participantControl6, participantControl7, participantControl8, participantControl9};
			interaction = Interaction;
			int index = 0;
			spreadsheetForm = null;
			study = Study;
			foreach(ParticipantControl control in participantControls)
			{
				control.Start.Click += start_Click;
				control.Finish.Click += finish_Click;
				control.NotFinish.Click += notfinished_Click;
				control.Timer.Tick += timer_Tick;
				control.Index = index++;
				control.Form = this;
			}
			resetParticipants_Click(this, EventArgs.Empty);
		}

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
		//ADD CANCELATION CONDITIONS
		private void finish_Click(object sender, EventArgs e)
		{
			participantProgress.Text = "Participant Progress: " + finishedParticipants.ToString() + "/" + numOfParticipants.Value.ToString();
			participantProgressBar.Maximum = (int)numOfParticipants.Value;
			participantProgressBar.Value = finishedParticipants;

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
		public void GetParticipantControl(int index, out ParticipantControl control)
		{
			control = participantControls[index];
		}
		public Participant GetParticipant(int participantNum)
		{
		 return null;
		}
		public void UpdateParticipant(int participantNum)
		{
			study.UpdateParticipants(participantNum);
		}

		#region Variables and Accessing
		SpreadsheetForm spreadsheetForm;


		string acronym = "NAME";
		int current_participant = 9;
		ParticipantControl[] participantControls;
		Study study;
		GoogleInteractions interaction;
		//PictureBox[] status;
		//ProgressBar[] progress;
		//Label[] timers;
		//Label[] participants;
		//Button[] starts;
		//Button[] finishes;
		//Button[] notfinishes;
		int finishedParticipants = 35;

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

		private void OpenSpreadsheetOptions(object sender, EventArgs e)
		{
			if (spreadsheetForm == null)
			{
				Form1 temp = this;
				spreadsheetForm = new SpreadsheetForm(ref interaction, ref temp);
				spreadsheetForm.Show();
				spreadsheetForm.LoadSettingsFromForm();
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

		public void ParticipantNotFinished(int participantNumber)
		{
			CurrParticipant++;
			study.ParticipantNotFinished(participantNumber);
		}

		internal string GetName()
		{
			return acronymText.Text;
		}
	}
}
