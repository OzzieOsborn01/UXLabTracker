using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.GData.Spreadsheets;
using Google.GData.Client;

namespace UXLAB.Classes
{
	public class Study
	{
		Timer timer;

		public Study(ref GoogleInteractions Interaction)
		{
			name = "NAME";
			completedParticipants = 0;
			desiredParticipants = 0;
			totalParticipants = 0;
			playTestDuration = 60;
			currentParticipants = 0;
			participants = new List<Participant>();
			completedParticipant = new List<Participant>();
			notFinishedParticipant = new List<Participant>();

			communityNow = new DateTime(1,1,1,0,0,0);
			interaction = Interaction;
			//timer = new Timer();
			//timer.Interval = 5000;
		}

		public int AddParticipant(ref ParticipantControl control)
		{
			int participantNum = totalParticipants++;
			Participant part = new Participant(participantNum, new TimeSpan(0, playTestDuration, 0), ref interaction, ref control);
			participants.Add(part);

			CellEntry outEntry;
			if (!interaction.FindCell(part.ParticipantNumber, out outEntry))
			{
				//TODO: Error Check
				MessageBox.Show("Failure", "Cell not found", MessageBoxButtons.OK);
			}
			
			part.TimeCell = outEntry;

			interaction.WriteCell(outEntry, GoogleInteractions.CellType.InputValue, AddHourToTime().ToString());
			
			return participantNum;
		}

		public void UpdateParticipants(int participantNumber)
		{
			foreach(Participant participant in participants)
			{
				if(participant.ParticipantNumber == participantNumber)
				{
					participant.Update(communityNow);
					break;
				}
			}
		}
		//public void UpdateStudyTimer()
		//{
		//	string sNow = interaction.ReadStudyCell(GoogleInteractions.Cell.Now);

		//	DateTime vNow = DateTime.Parse(sNow);
			
		//	if(vNow != communityNow)
		//	{

		//	}
			
		//}
		public Participant GetActiveParticipant(int participantNumber)
		{
			foreach(Participant participant in participants)
			{
				if(participant.ParticipantNumber == participantNumber)
				{
					return participant;
				}
			}
			return null;
		}

		public DateTime AddHourToTime()
		{
			DateTime date = communityNow;

			date += TimeSpan.FromMinutes(60);

			return date;
		}

		//public void SetStudyTime (string dateTime)
		//{
		//	DateTime sDateString = DateTime.Parse(dateTime);
		//	try
		//	{
				
		//	}
		//	catch(Exception ex)
		//	{
		//		MessageBox.Show(ex.Message);
		//	}
		//}

#region Variables and Accessors
		private string name;
		private int completedParticipants;
		private int desiredParticipants;
		private int totalParticipants;
		private int playTestDuration;
		private int currentParticipants;
		private List<Participant> participants;
		private List<Participant> completedParticipant;
		private List<Participant> notFinishedParticipant;
		Form1 form;
		GoogleInteractions interaction;
		DateTime communityNow;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int CompletedParticipants
		{
			get { return completedParticipants; }
			set { completedParticipants = value; }
		}
		public int DesiredParticipants
		{
			get { return desiredParticipants; }
			set { desiredParticipants = value; }
		}
		public int TotalParticipants
		{
			get { return totalParticipants; }
			set { totalParticipants = value; }
		}
		public int PlayTestDuration
		{
			get { return playTestDuration; }
			set { playTestDuration = value; }
		}
 
	#endregion

		public void ParticipantNotFinished(int participantNumber)
		{
			foreach (Participant participant in participants)
			{
				if (participant.ParticipantNumber == participantNumber)
				{
					participant.NotFinished();
					notFinishedParticipant.Add(participant);
					participants.Remove(participant);
					break;
				}
			}
		}
	}
}
