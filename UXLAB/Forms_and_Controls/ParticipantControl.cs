using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UXLAB.Classes;

namespace UXLAB
{
	//Custom Control that represents the active participants' data
	public partial class ParticipantControl : UserControl
	{
		public ParticipantControl()
		{
			InitializeComponent();
		}
		
		#region Variables and Accessors
		private Form1 mainForm;
		public Form Form;

		public Button Start
		{
			get { return start1; }
		}
		public Button Finish
		{
			get { return finish1; }
		}
		public Button NotFinish
		{
			get { return notFinished1; }
		}
		public Timer Timer
		{
			get { return timer_1; }
		}
		public Label Timer_Text
		{
			get { return timer1; }
		}
		public ProgressBar ProgressBar
		{
			get { return progressBar1; }
		}
		public PictureBox Status
		{
			get { return status1; }
		}
		public string ParticipantName
		{
			get { return groupBox1.Text; }
			set { groupBox1.Text = value; }
		}
		public int ParticipantNumber
		{ get; set; }
		public int Index
		{ get; set; }
		public Form1 MainForm
		{
			get { return mainForm; }
			set { mainForm = value; }
		}		
		#endregion


		#region Control Functions
		private void timer_Tick(object sender, EventArgs e)
		{
			MainForm.UpdateParticipant(ParticipantNumber);
		}
		private void start_Click(object sender, EventArgs e)
		{
			ParticipantControl outControl;
			MainForm.GetParticipantControl(this.Index, out outControl);
			ParticipantNumber = MainForm.StartParticipant(ref outControl);

			Start.Enabled = false;
			Finish.Enabled = false;
			NotFinish.Enabled = true;
			Timer.Start();
			Name = MainForm.GetName() + ParticipantNumber.ToString();
		}
		//ADD CANCELATION CONDITIONS
		private void finish_Click(object sender, EventArgs e)
		{
			MainForm.CurrParticipant++;
			MainForm.FinishedParticipant++;
			Timer_Text.Text = "00:00";
			Start.Enabled = true;
			Finish.Enabled = false;
			NotFinish.Enabled = false;
			Status.BackColor = Color.YellowGreen;
			ProgressBar.Value = 0;
			ParticipantName = MainForm.Acronym + "_" + MainForm.CurrParticipant.ToString();
		}
		
		//If the participant leaves early
		private void notfinished_Click(object sender, EventArgs e)
		{
			MainForm.ParticipantNotFinished(ParticipantNumber);
			//MainForm.CountDowns[Index].timerRef.Stop();
			//notfinishedList.Items.Add(participantControls[Index].ParticipantName);
			Timer.Stop();
			Timer_Text.Text = "00:00";
			Start.Enabled = true;
			Finish.Enabled = false;
			NotFinish.Enabled = false;
			Status.BackColor = Color.YellowGreen;
			ProgressBar.Value = 0;
			ParticipantName = MainForm.Acronym + "_" + MainForm.CurrParticipant.ToString();
		}		
		#endregion
	}
}
