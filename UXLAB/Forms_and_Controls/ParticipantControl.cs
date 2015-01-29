using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UXLAB
{
	public partial class ParticipantControl : UserControl
	{
		public ParticipantControl()
		{
			InitializeComponent();
		}

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
		public Form1 Form
		{
			get { return form; }
			set { form = value; }
		}

		private Form1 form;


		private void timer_Tick(object sender, EventArgs e)
		{
			Form.UpdateParticipant(ParticipantNumber);
		}

		private void start_Click(object sender, EventArgs e)
		{
			ParticipantControl outControl;
			Form.GetParticipantControl(this.Index, out outControl);
			ParticipantNumber = Form.StartParticipant(ref outControl);

			Start.Enabled = false;
			Finish.Enabled = false;
			NotFinish.Enabled = true;
			Timer.Start();
			Name = Form.GetName() + ParticipantNumber.ToString();
		}
		//ADD CANCELATION CONDITIONS
		private void finish_Click(object sender, EventArgs e)
		{
			Form.CurrParticipant++;
			Form.FinishedParticipant++;
			Timer_Text.Text = "00:00";
			Start.Enabled = true;
			Finish.Enabled = false;
			NotFinish.Enabled = false;
			Status.BackColor = Color.YellowGreen;
			ProgressBar.Value = 0;
			ParticipantName = Form.Acronym + "_" + Form.CurrParticipant.ToString();
		}
		private void notfinished_Click(object sender, EventArgs e)
		{
			Form.ParticipantNotFinished(ParticipantNumber);
			//Form.CountDowns[Index].timerRef.Stop();
			//notfinishedList.Items.Add(participantControls[Index].ParticipantName);
			Timer.Stop();
			Timer_Text.Text = "00:00";
			Start.Enabled = true;
			Finish.Enabled = false;
			NotFinish.Enabled = false;
			Status.BackColor = Color.YellowGreen;
			ProgressBar.Value = 0;
			ParticipantName = Form.Acronym + "_" + Form.CurrParticipant.ToString();
		}

	}
}
