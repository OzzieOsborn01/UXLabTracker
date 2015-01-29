using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Google.GData.Spreadsheets;

namespace UXLAB.Classes
{
	public class Participant
	{
		public Participant(int ParticipantNum, TimeSpan span, ref GoogleInteractions Interaction, ref ParticipantControl refControl)
		{
			control = refControl;
			participantNumber = ParticipantNum;
			timeLeft = span;
			control.ProgressBar.Maximum = (int)span.TotalSeconds;
			interaction = Interaction;
		}
		public void Update(DateTime delta)
		{
			string sNow = interaction.ReadStudyCell(GoogleInteractions.Cell.Now), sEnd;
			interaction.RefreshandReadCell(timeCell, GoogleInteractions.CellType.DisplayedValue,  out sEnd);
			timeLeft = DateTime.Parse(sEnd) - DateTime.Parse(sNow);

			if (timeLeft.TotalSeconds > 0)
			{
				control.Status.BackColor = Color.OrangeRed;
				string time = string.Format("{0:D2}:{1:D2}",
				timeLeft.Minutes,
				timeLeft.Seconds);
				control.Timer_Text.Text = time;
				control.ProgressBar.Value = control.ProgressBar.Maximum - (int)timeLeft.TotalSeconds;
			}
			else if (timeLeft.TotalSeconds <= 0.001)
			{
				control.Status.BackColor = Color.Yellow;
				control.Timer.Stop();
				control.Timer_Text.Text = "SURV.";
				control.Finish.Enabled = true;
				control.NotFinish.Enabled = false;
			}

		}

		private void DoubleCheckEnd()
		{
			string sEnd = "";
			interaction.RefreshandReadCell(timeCell, GoogleInteractions.CellType.DisplayedValue, out sEnd);
			DateTime end = DateTime.Parse(sEnd);

			if(end != endTime)
			{
				endTime = end;
			}
		}
		public void NotFinished()
		{
			control = null;
		}

#region Variables
		private TimeSpan timeLeft;
		private DateTime endTime;
		private ParticipantControl control;
		private GoogleInteractions interaction;
		private CellEntry timeCell;

		public CellEntry TimeCell
		{
			get { return timeCell; }
			set { timeCell = value; }
		}

		public ParticipantControl Control
		{
			get { return control; }
			set { control = value; }
		}
		private int participantNumber;

		public int ParticipantNumber
		{
			get { return participantNumber; }
			set { participantNumber = value; }
		}
 
	#endregion
	}
}
