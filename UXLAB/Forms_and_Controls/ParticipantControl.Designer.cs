namespace UXLAB
{
	partial class ParticipantControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.status1 = new System.Windows.Forms.PictureBox();
			this.notFinished1 = new System.Windows.Forms.Button();
			this.finish1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Label();
			this.start1 = new System.Windows.Forms.Button();
			this.timer_1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.status1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.status1);
			this.groupBox1.Controls.Add(this.notFinished1);
			this.groupBox1.Controls.Add(this.finish1);
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Controls.Add(this.timer1);
			this.groupBox1.Controls.Add(this.start1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1180, 96);
			this.groupBox1.TabIndex = 71;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "NAME_##";
			// 
			// status1
			// 
			this.status1.BackColor = System.Drawing.Color.YellowGreen;
			this.status1.Location = new System.Drawing.Point(7, 38);
			this.status1.Margin = new System.Windows.Forms.Padding(4);
			this.status1.Name = "status1";
			this.status1.Size = new System.Drawing.Size(65, 47);
			this.status1.TabIndex = 41;
			this.status1.TabStop = false;
			// 
			// notFinished1
			// 
			this.notFinished1.AccessibleDescription = "1";
			this.notFinished1.Enabled = false;
			this.notFinished1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.notFinished1.Location = new System.Drawing.Point(980, 38);
			this.notFinished1.Margin = new System.Windows.Forms.Padding(4);
			this.notFinished1.Name = "notFinished1";
			this.notFinished1.Size = new System.Drawing.Size(193, 47);
			this.notFinished1.TabIndex = 25;
			this.notFinished1.Text = "Not Finished";
			this.notFinished1.UseVisualStyleBackColor = true;
			this.notFinished1.Click += new System.EventHandler(this.notfinished_Click);
			// 
			// finish1
			// 
			this.finish1.AccessibleDescription = "1";
			this.finish1.Enabled = false;
			this.finish1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.finish1.Location = new System.Drawing.Point(779, 38);
			this.finish1.Margin = new System.Windows.Forms.Padding(4);
			this.finish1.Name = "finish1";
			this.finish1.Size = new System.Drawing.Size(193, 47);
			this.finish1.TabIndex = 25;
			this.finish1.Text = "Next";
			this.finish1.UseVisualStyleBackColor = true;
			this.finish1.Click += new System.EventHandler(this.finish_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(80, 38);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(352, 47);
			this.progressBar1.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.AutoSize = true;
			this.timer1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timer1.Location = new System.Drawing.Point(440, 38);
			this.timer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.timer1.Name = "timer1";
			this.timer1.Size = new System.Drawing.Size(130, 47);
			this.timer1.TabIndex = 8;
			this.timer1.Text = "00:00";
			// 
			// start1
			// 
			this.start1.AccessibleDescription = "1";
			this.start1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.start1.Location = new System.Drawing.Point(578, 38);
			this.start1.Margin = new System.Windows.Forms.Padding(4);
			this.start1.Name = "start1";
			this.start1.Size = new System.Drawing.Size(193, 47);
			this.start1.TabIndex = 24;
			this.start1.Text = "Start";
			this.start1.UseVisualStyleBackColor = true;
			this.start1.Click += new System.EventHandler(this.start_Click);
			// 
			// timer_1
			// 
			this.timer_1.Interval = 1000;
			this.timer_1.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// ParticipantControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "ParticipantControl";
			this.Size = new System.Drawing.Size(1188, 107);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.status1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox status1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label timer1;
		private System.Windows.Forms.Button start1;
		private System.Windows.Forms.Button finish1;
		private System.Windows.Forms.Timer timer_1;
		private System.Windows.Forms.Button notFinished1;
	}
}
