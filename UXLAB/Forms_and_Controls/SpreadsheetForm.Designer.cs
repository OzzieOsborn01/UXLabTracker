namespace UXLAB
{
	partial class SpreadsheetForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.workbook1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Find1 = new System.Windows.Forms.Button();
			this.WBNotFound1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.Find2 = new System.Windows.Forms.Button();
			this.worksheet1 = new System.Windows.Forms.TextBox();
			this.WSNotFoundS = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.Find3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.worksheet2 = new System.Windows.Forms.TextBox();
			this.WSNotFoundP = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.nameResults = new System.Windows.Forms.TextBox();
			this.nowResults = new System.Windows.Forms.TextBox();
			this.totalResults = new System.Windows.Forms.TextBox();
			this.durationResults = new System.Windows.Forms.TextBox();
			this.desiredResults = new System.Windows.Forms.TextBox();
			this.completedResults = new System.Windows.Forms.TextBox();
			this.CellNotFoundNw = new System.Windows.Forms.Label();
			this.CellNotFoundT = new System.Windows.Forms.Label();
			this.CellNotFoundDes = new System.Windows.Forms.Label();
			this.CellNotFoundC = new System.Windows.Forms.Label();
			this.CellNotFoundDur = new System.Windows.Forms.Label();
			this.nowCell = new System.Windows.Forms.TextBox();
			this.CellNotFoundN = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.totalCell = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.nameCell = new System.Windows.Forms.TextBox();
			this.completedCell = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.desiredCell = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.durationCell = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.cellOffset = new System.Windows.Forms.NumericUpDown();
			this.participantCollection = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cellOffset)).BeginInit();
			this.SuspendLayout();
			// 
			// workbook1
			// 
			this.workbook1.Location = new System.Drawing.Point(149, 21);
			this.workbook1.Name = "workbook1";
			this.workbook1.Size = new System.Drawing.Size(168, 22);
			this.workbook1.TabIndex = 0;
			this.workbook1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Workbook to use:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Find1);
			this.groupBox1.Controls.Add(this.WBNotFound1);
			this.groupBox1.Controls.Add(this.workbook1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(356, 80);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Workbook";
			// 
			// Find1
			// 
			this.Find1.Location = new System.Drawing.Point(32, 49);
			this.Find1.Name = "Find1";
			this.Find1.Size = new System.Drawing.Size(94, 24);
			this.Find1.TabIndex = 3;
			this.Find1.Text = "Find Workbook";
			this.Find1.UseVisualStyleBackColor = true;
			this.Find1.Click += new System.EventHandler(this.FindWorkbook);
			// 
			// WBNotFound1
			// 
			this.WBNotFound1.AutoSize = true;
			this.WBNotFound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WBNotFound1.ForeColor = System.Drawing.Color.LimeGreen;
			this.WBNotFound1.Location = new System.Drawing.Point(158, 46);
			this.WBNotFound1.Name = "WBNotFound1";
			this.WBNotFound1.Size = new System.Drawing.Size(159, 17);
			this.WBNotFound1.TabIndex = 2;
			this.WBNotFound1.Text = "Workbook not found.";
			this.WBNotFound1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.WBNotFound1.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.groupBox5);
			this.groupBox2.Location = new System.Drawing.Point(12, 98);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(356, 260);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Worksheet";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.Find2);
			this.groupBox4.Controls.Add(this.worksheet1);
			this.groupBox4.Controls.Add(this.WSNotFoundS);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Location = new System.Drawing.Point(6, 21);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(332, 88);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Study";
			// 
			// Find2
			// 
			this.Find2.Location = new System.Drawing.Point(31, 43);
			this.Find2.Name = "Find2";
			this.Find2.Size = new System.Drawing.Size(94, 24);
			this.Find2.TabIndex = 3;
			this.Find2.Text = "Find Workbook";
			this.Find2.UseVisualStyleBackColor = true;
			this.Find2.Click += new System.EventHandler(this.FindStudyWorksheet);
			// 
			// worksheet1
			// 
			this.worksheet1.Location = new System.Drawing.Point(148, 15);
			this.worksheet1.Name = "worksheet1";
			this.worksheet1.Size = new System.Drawing.Size(168, 22);
			this.worksheet1.TabIndex = 0;
			this.worksheet1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// WSNotFoundS
			// 
			this.WSNotFoundS.AutoSize = true;
			this.WSNotFoundS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WSNotFoundS.ForeColor = System.Drawing.Color.LimeGreen;
			this.WSNotFoundS.Location = new System.Drawing.Point(157, 43);
			this.WSNotFoundS.Name = "WSNotFoundS";
			this.WSNotFoundS.Size = new System.Drawing.Size(164, 17);
			this.WSNotFoundS.TabIndex = 2;
			this.WSNotFoundS.Text = "Worksheet not found.";
			this.WSNotFoundS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.WSNotFoundS.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Worksheet to use:";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.Find3);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.worksheet2);
			this.groupBox5.Controls.Add(this.WSNotFoundP);
			this.groupBox5.Location = new System.Drawing.Point(10, 115);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(328, 82);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Participants";
			// 
			// Find3
			// 
			this.Find3.Location = new System.Drawing.Point(31, 43);
			this.Find3.Name = "Find3";
			this.Find3.Size = new System.Drawing.Size(94, 24);
			this.Find3.TabIndex = 3;
			this.Find3.Text = "Find Workbook";
			this.Find3.UseVisualStyleBackColor = true;
			this.Find3.Click += new System.EventHandler(this.FindParticipantWorksheet);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Worksheet to use:";
			// 
			// worksheet2
			// 
			this.worksheet2.Location = new System.Drawing.Point(148, 15);
			this.worksheet2.Name = "worksheet2";
			this.worksheet2.Size = new System.Drawing.Size(168, 22);
			this.worksheet2.TabIndex = 0;
			this.worksheet2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// WSNotFoundP
			// 
			this.WSNotFoundP.AutoSize = true;
			this.WSNotFoundP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WSNotFoundP.ForeColor = System.Drawing.Color.LimeGreen;
			this.WSNotFoundP.Location = new System.Drawing.Point(152, 47);
			this.WSNotFoundP.Name = "WSNotFoundP";
			this.WSNotFoundP.Size = new System.Drawing.Size(164, 17);
			this.WSNotFoundP.TabIndex = 2;
			this.WSNotFoundP.Text = "Worksheet not found.";
			this.WSNotFoundP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.WSNotFoundP.Visible = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.groupBox7);
			this.groupBox3.Controls.Add(this.groupBox6);
			this.groupBox3.Location = new System.Drawing.Point(374, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(714, 346);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Cells";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.groupBox8);
			this.groupBox7.Controls.Add(this.CellNotFoundNw);
			this.groupBox7.Controls.Add(this.CellNotFoundT);
			this.groupBox7.Controls.Add(this.CellNotFoundDes);
			this.groupBox7.Controls.Add(this.CellNotFoundC);
			this.groupBox7.Controls.Add(this.CellNotFoundDur);
			this.groupBox7.Controls.Add(this.nowCell);
			this.groupBox7.Controls.Add(this.CellNotFoundN);
			this.groupBox7.Controls.Add(this.label11);
			this.groupBox7.Controls.Add(this.totalCell);
			this.groupBox7.Controls.Add(this.label9);
			this.groupBox7.Controls.Add(this.nameCell);
			this.groupBox7.Controls.Add(this.completedCell);
			this.groupBox7.Controls.Add(this.label6);
			this.groupBox7.Controls.Add(this.desiredCell);
			this.groupBox7.Controls.Add(this.label5);
			this.groupBox7.Controls.Add(this.label8);
			this.groupBox7.Controls.Add(this.durationCell);
			this.groupBox7.Controls.Add(this.label7);
			this.groupBox7.Location = new System.Drawing.Point(6, 21);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(700, 207);
			this.groupBox7.TabIndex = 2;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Study";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.nameResults);
			this.groupBox8.Controls.Add(this.nowResults);
			this.groupBox8.Controls.Add(this.totalResults);
			this.groupBox8.Controls.Add(this.durationResults);
			this.groupBox8.Controls.Add(this.desiredResults);
			this.groupBox8.Controls.Add(this.completedResults);
			this.groupBox8.Location = new System.Drawing.Point(507, 3);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(184, 198);
			this.groupBox8.TabIndex = 2;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Results ";
			// 
			// nameResults
			// 
			this.nameResults.Location = new System.Drawing.Point(6, 18);
			this.nameResults.Name = "nameResults";
			this.nameResults.Size = new System.Drawing.Size(168, 22);
			this.nameResults.TabIndex = 0;
			// 
			// nowResults
			// 
			this.nowResults.Location = new System.Drawing.Point(6, 158);
			this.nowResults.Name = "nowResults";
			this.nowResults.Size = new System.Drawing.Size(168, 22);
			this.nowResults.TabIndex = 0;
			// 
			// totalResults
			// 
			this.totalResults.Location = new System.Drawing.Point(6, 130);
			this.totalResults.Name = "totalResults";
			this.totalResults.Size = new System.Drawing.Size(168, 22);
			this.totalResults.TabIndex = 0;
			// 
			// durationResults
			// 
			this.durationResults.Location = new System.Drawing.Point(6, 46);
			this.durationResults.Name = "durationResults";
			this.durationResults.Size = new System.Drawing.Size(168, 22);
			this.durationResults.TabIndex = 0;
			// 
			// desiredResults
			// 
			this.desiredResults.Location = new System.Drawing.Point(6, 102);
			this.desiredResults.Name = "desiredResults";
			this.desiredResults.Size = new System.Drawing.Size(168, 22);
			this.desiredResults.TabIndex = 0;
			// 
			// completedResults
			// 
			this.completedResults.Location = new System.Drawing.Point(6, 74);
			this.completedResults.Name = "completedResults";
			this.completedResults.Size = new System.Drawing.Size(168, 22);
			this.completedResults.TabIndex = 0;
			// 
			// CellNotFoundNw
			// 
			this.CellNotFoundNw.AutoSize = true;
			this.CellNotFoundNw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CellNotFoundNw.ForeColor = System.Drawing.Color.LimeGreen;
			this.CellNotFoundNw.Location = new System.Drawing.Point(342, 164);
			this.CellNotFoundNw.Name = "CellNotFoundNw";
			this.CellNotFoundNw.Size = new System.Drawing.Size(159, 17);
			this.CellNotFoundNw.TabIndex = 2;
			this.CellNotFoundNw.Text = "Workbook not found.";
			this.CellNotFoundNw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CellNotFoundNw.Visible = false;
			// 
			// CellNotFoundT
			// 
			this.CellNotFoundT.AutoSize = true;
			this.CellNotFoundT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CellNotFoundT.ForeColor = System.Drawing.Color.LimeGreen;
			this.CellNotFoundT.Location = new System.Drawing.Point(342, 136);
			this.CellNotFoundT.Name = "CellNotFoundT";
			this.CellNotFoundT.Size = new System.Drawing.Size(159, 17);
			this.CellNotFoundT.TabIndex = 2;
			this.CellNotFoundT.Text = "Workbook not found.";
			this.CellNotFoundT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CellNotFoundT.Visible = false;
			// 
			// CellNotFoundDes
			// 
			this.CellNotFoundDes.AutoSize = true;
			this.CellNotFoundDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CellNotFoundDes.ForeColor = System.Drawing.Color.LimeGreen;
			this.CellNotFoundDes.Location = new System.Drawing.Point(342, 108);
			this.CellNotFoundDes.Name = "CellNotFoundDes";
			this.CellNotFoundDes.Size = new System.Drawing.Size(159, 17);
			this.CellNotFoundDes.TabIndex = 2;
			this.CellNotFoundDes.Text = "Workbook not found.";
			this.CellNotFoundDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CellNotFoundDes.Visible = false;
			// 
			// CellNotFoundC
			// 
			this.CellNotFoundC.AutoSize = true;
			this.CellNotFoundC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CellNotFoundC.ForeColor = System.Drawing.Color.LimeGreen;
			this.CellNotFoundC.Location = new System.Drawing.Point(342, 80);
			this.CellNotFoundC.Name = "CellNotFoundC";
			this.CellNotFoundC.Size = new System.Drawing.Size(159, 17);
			this.CellNotFoundC.TabIndex = 2;
			this.CellNotFoundC.Text = "Workbook not found.";
			this.CellNotFoundC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CellNotFoundC.Visible = false;
			// 
			// CellNotFoundDur
			// 
			this.CellNotFoundDur.AutoSize = true;
			this.CellNotFoundDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CellNotFoundDur.ForeColor = System.Drawing.Color.LimeGreen;
			this.CellNotFoundDur.Location = new System.Drawing.Point(342, 52);
			this.CellNotFoundDur.Name = "CellNotFoundDur";
			this.CellNotFoundDur.Size = new System.Drawing.Size(159, 17);
			this.CellNotFoundDur.TabIndex = 2;
			this.CellNotFoundDur.Text = "Workbook not found.";
			this.CellNotFoundDur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CellNotFoundDur.Visible = false;
			// 
			// nowCell
			// 
			this.nowCell.Location = new System.Drawing.Point(171, 161);
			this.nowCell.Name = "nowCell";
			this.nowCell.Size = new System.Drawing.Size(168, 22);
			this.nowCell.TabIndex = 0;
			this.nowCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// CellNotFoundN
			// 
			this.CellNotFoundN.AutoSize = true;
			this.CellNotFoundN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CellNotFoundN.ForeColor = System.Drawing.Color.LimeGreen;
			this.CellNotFoundN.Location = new System.Drawing.Point(342, 24);
			this.CellNotFoundN.Name = "CellNotFoundN";
			this.CellNotFoundN.Size = new System.Drawing.Size(159, 17);
			this.CellNotFoundN.TabIndex = 2;
			this.CellNotFoundN.Text = "Workbook not found.";
			this.CellNotFoundN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CellNotFoundN.Visible = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(47, 164);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 17);
			this.label11.TabIndex = 1;
			this.label11.Text = "Now";
			// 
			// totalCell
			// 
			this.totalCell.Location = new System.Drawing.Point(171, 133);
			this.totalCell.Name = "totalCell";
			this.totalCell.Size = new System.Drawing.Size(168, 22);
			this.totalCell.TabIndex = 0;
			this.totalCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(47, 136);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 17);
			this.label9.TabIndex = 1;
			this.label9.Text = "Total Participants";
			// 
			// nameCell
			// 
			this.nameCell.Location = new System.Drawing.Point(171, 21);
			this.nameCell.Name = "nameCell";
			this.nameCell.Size = new System.Drawing.Size(168, 22);
			this.nameCell.TabIndex = 0;
			this.nameCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// completedCell
			// 
			this.completedCell.Location = new System.Drawing.Point(171, 77);
			this.completedCell.Name = "completedCell";
			this.completedCell.Size = new System.Drawing.Size(168, 22);
			this.completedCell.TabIndex = 0;
			this.completedCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Completed Participants";
			// 
			// desiredCell
			// 
			this.desiredCell.Location = new System.Drawing.Point(171, 105);
			this.desiredCell.Name = "desiredCell";
			this.desiredCell.Size = new System.Drawing.Size(168, 22);
			this.desiredCell.TabIndex = 0;
			this.desiredCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(135, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "Desired Participants";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(80, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 17);
			this.label8.TabIndex = 1;
			this.label8.Text = "Study Name";
			// 
			// durationCell
			// 
			this.durationCell.Location = new System.Drawing.Point(171, 49);
			this.durationCell.Name = "durationCell";
			this.durationCell.Size = new System.Drawing.Size(168, 22);
			this.durationCell.TabIndex = 0;
			this.durationCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(125, 17);
			this.label7.TabIndex = 1;
			this.label7.Text = "Play Test Duration";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.checkBox1);
			this.groupBox6.Controls.Add(this.cellOffset);
			this.groupBox6.Controls.Add(this.participantCollection);
			this.groupBox6.Controls.Add(this.label10);
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Location = new System.Drawing.Point(6, 234);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(501, 104);
			this.groupBox6.TabIndex = 2;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Participants";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(171, 77);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(113, 21);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Use Columns";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.UseColumns);
			// 
			// cellOffset
			// 
			this.cellOffset.Location = new System.Drawing.Point(179, 48);
			this.cellOffset.Name = "cellOffset";
			this.cellOffset.Size = new System.Drawing.Size(168, 22);
			this.cellOffset.TabIndex = 3;
			this.cellOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.cellOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// participantCollection
			// 
			this.participantCollection.Location = new System.Drawing.Point(179, 20);
			this.participantCollection.Name = "participantCollection";
			this.participantCollection.Size = new System.Drawing.Size(168, 22);
			this.participantCollection.TabIndex = 0;
			this.participantCollection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(100, 50);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 17);
			this.label10.TabIndex = 1;
			this.label10.Text = "Cell Offset";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Player End Test Columns";
			// 
			// SpreadsheetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1131, 429);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "SpreadsheetForm";
			this.Text = "SpreadsheetForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cellOffset)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox workbook1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button Find1;
		private System.Windows.Forms.Label WBNotFound1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button Find2;
		private System.Windows.Forms.TextBox worksheet1;
		private System.Windows.Forms.Label WSNotFoundS;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button Find3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox worksheet2;
		private System.Windows.Forms.Label WSNotFoundP;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox participantCollection;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox durationCell;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox completedCell;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox desiredCell;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox nameCell;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox totalCell;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.TextBox nameResults;
		private System.Windows.Forms.TextBox totalResults;
		private System.Windows.Forms.TextBox durationResults;
		private System.Windows.Forms.TextBox desiredResults;
		private System.Windows.Forms.TextBox completedResults;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.NumericUpDown cellOffset;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label CellNotFoundT;
		private System.Windows.Forms.Label CellNotFoundDes;
		private System.Windows.Forms.Label CellNotFoundC;
		private System.Windows.Forms.Label CellNotFoundDur;
		private System.Windows.Forms.Label CellNotFoundN;
		private System.Windows.Forms.TextBox nowResults;
		private System.Windows.Forms.Label CellNotFoundNw;
		private System.Windows.Forms.TextBox nowCell;
		private System.Windows.Forms.Label label11;
	}
}