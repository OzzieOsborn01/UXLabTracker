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
	public class StudyComponents
	{
		public StudyComponents()
		{
			Name = "NAME";
			Duration = new TimeSpan(0,60,0);
			Now = DateTime.Now;
			Total = 0;
			Completed = 0;
			Desired = 64;
		}
		public StudyComponents(StudyComponents that)
		{
			Name = that.Name;
			Duration = that.Duration;
			Now = that.Now;
			Total = that.Total;
			Completed = that.Completed;
			Desired = that.Desired;
		}

		public static bool operator ==(StudyComponents sc1, StudyComponents sc2)
		{
			bool equal = true;

			equal = (sc1.Name == sc2.Name && equal)? true : false;
			equal = (sc1.Duration == sc2.Duration && equal)? true : false;
			equal = (sc1.Now == sc2.Now && equal)? true : false;
			equal = (sc1.Total == sc2.Total && equal)? true : false;
			equal = (sc1.Completed == sc2.Completed && equal)? true : false;
			equal = (sc1.Desired == sc2.Desired && equal)? true : false;
			
			return equal;
		}
		public static bool operator !=(StudyComponents sc1, StudyComponents sc2)
		{ 
			bool equal = true;
			
			equal = (sc1.Name != sc2.Name && equal)? true : false;
			equal = (sc1.Duration != sc2.Duration && equal)? true : false;
			equal = (sc1.Now != sc2.Now && equal)? true : false;
			equal = (sc1.Total != sc2.Total && equal)? true : false;
			equal = (sc1.Completed != sc2.Completed && equal)? true : false;
			equal = (sc1.Desired != sc2.Desired && equal)? true : false;
	
			return equal;
		}

		public string Name;
		public TimeSpan Duration;
		public DateTime Now;
		public int Total;
		public int Completed;
		public int Desired;
	}
	public class Study
	{
		Timer timer;
		public Study(ref GoogleInteractions Interaction)
		{
			currComponents = new StudyComponents();
			prevComponents = new StudyComponents();
			participants = new List<Participant>();
			completedParticipant = new List<Participant>();
			notFinishedParticipant = new List<Participant>();

			communityNow = new DateTime(1,1,1,0,0,0);
			interaction = Interaction;
			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += timer_Tick;
			timer.Start();

			systemNow = DateTime.Now;
			prevSystemNow = DateTime.Now;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			UpdateStudy(false);
		}

		private void UpdateStudy(bool usingGoogle)
		{
			if(usingGoogle)
			{
				string tempString;
				tempString = interaction.ReadStudyCell(Form1.Cell.Now);
				currComponents.Now = DateTime.Parse(tempString);
				tempString = interaction.ReadStudyCell(Form1.Cell.Name);
				currComponents.Name = tempString;
				tempString = interaction.ReadStudyCell(Form1.Cell.Total);
				currComponents.Total = Int32.Parse(tempString);
				tempString = interaction.ReadStudyCell(Form1.Cell.Desired);
				currComponents.Desired = Int32.Parse(tempString);
				tempString = interaction.ReadStudyCell(Form1.Cell.Completed);
				currComponents.Completed = Int32.Parse(tempString);
				tempString = interaction.ReadStudyCell(Form1.Cell.Duration);
				currComponents.Duration = TimeSpan.Parse(tempString);
	
			}
			else
			{
				if(currComponents != prevComponents)
				{
					prevComponents = new StudyComponents(currComponents);
				}
			
				prevSystemNow = systemNow;
				systemNow = DateTime.Now;
				TimeSpan tempDelta = systemNow - prevSystemNow;
				currComponents.Now += tempDelta;
				prevComponents.Now += tempDelta;
			}
		}

		#region Study Wide
		public int AddParticipant(ref ParticipantControl control)
		{
			int participantNum = currComponents.Total++;
			Participant part = new Participant(participantNum, currComponents.Duration, ref interaction, ref control);
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
			TimeSpan tempDelta = GetDelta();
			foreach (Participant participant in participants)
			{
				if (participant.ParticipantNumber == participantNumber)
				{
					participant.Update(delta);
					break;
				}
			}
		}		
		
		//public void UpdateStudyTimer()
		//{
		//	string sNow = interaction.ReadStudyCell(Form1.Cell.Now);
		//
		//	DateTime vNow = DateTime.Parse(sNow);
		//	
		//	if(vNow != communityNow)
		//	{
		//
		//	}
		//	
		//}
		
		//public void SetStudyTime (string dateTime)
		//{
		//	DateTime sDateString = DateTime.Parse(dateTime);
		//	try
		//	{
		//		
		//	}
		//	catch(Exception ex)
		//	{
		//		MessageBox.Show(ex.Message);
		//	}
		//}
		#endregion

		#region Participant Specific
		public Participant GetActiveParticipant(int participantNumber)
		{
			foreach (Participant participant in participants)
			{
				if (participant.ParticipantNumber == participantNumber)
				{
					return participant;
				}
			}
			return null;
		}
		
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

		#endregion

		#region Helper Functions
		public DateTime AddHourToTime()
		{
			DateTime date = communityNow;

			date += TimeSpan.FromMinutes(60);

			return date;
		}	
		public TimeSpan GetDelta ()
		{
			prevSystemNow = systemNow;
			systemNow = DateTime.Now;
			TimeSpan tempDelta = systemNow - prevSystemNow;
			if(tempDelta.TotalSeconds >= 0.001)
			{
				return delta;
			}
			return tempDelta;
		}
		#endregion

		#region Variables and Accessors

		StudyComponents currComponents;
		StudyComponents prevComponents;
		private List<Participant> participants;
		private List<Participant> completedParticipant;
		private List<Participant> notFinishedParticipant;
		Form1 form;
		GoogleInteractions interaction;
		DateTime communityNow;
		DateTime systemNow;
		DateTime prevSystemNow;
		TimeSpan delta;


		public DateTime CommunityNow
		{
			get { return communityNow; }
			set { communityNow = value; }
		}

		public StudyComponents CurrComponents
		{
			get { return currComponents; }
			set { currComponents = value; }
		}
		#endregion

	}
}
