namespace UXLAB
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.notfinishedList = new System.Windows.Forms.ListBox();
			this.label17 = new System.Windows.Forms.Label();
			this.settings = new System.Windows.Forms.GroupBox();
			this.playtestDuration = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.numOfParticipants = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.resetParticipants = new System.Windows.Forms.Button();
			this.acronymText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.Data = new System.Windows.Forms.TabPage();
			this.participantProgressBar = new System.Windows.Forms.ProgressBar();
			this.participantProgress = new System.Windows.Forms.Label();
			this.timer_1 = new System.Windows.Forms.Timer(this.components);
			this.participantControl8 = new UXLAB.ParticipantControl();
			this.participantControl7 = new UXLAB.ParticipantControl();
			this.participantControl6 = new UXLAB.ParticipantControl();
			this.participantControl5 = new UXLAB.ParticipantControl();
			this.participantControl4 = new UXLAB.ParticipantControl();
			this.participantControl3 = new UXLAB.ParticipantControl();
			this.participantControl2 = new UXLAB.ParticipantControl();
			this.participantControl1 = new UXLAB.ParticipantControl();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.participantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.participantControl9 = new UXLAB.ParticipantControl();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.playtestDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numOfParticipants)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.Data.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notfinishedList
			// 
			this.notfinishedList.FormattingEnabled = true;
			this.notfinishedList.ItemHeight = 16;
			this.notfinishedList.Location = new System.Drawing.Point(2217, 70);
			this.notfinishedList.Margin = new System.Windows.Forms.Padding(4);
			this.notfinishedList.Name = "notfinishedList";
			this.notfinishedList.Size = new System.Drawing.Size(279, 788);
			this.notfinishedList.TabIndex = 40;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(2212, 31);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(156, 29);
			this.label17.TabIndex = 57;
			this.label17.Text = "Not Finished:";
			// 
			// settings
			// 
			this.settings.Controls.Add(this.playtestDuration);
			this.settings.Controls.Add(this.label5);
			this.settings.Controls.Add(this.numOfParticipants);
			this.settings.Controls.Add(this.label2);
			this.settings.Controls.Add(this.resetParticipants);
			this.settings.Controls.Add(this.acronymText);
			this.settings.Controls.Add(this.label1);
			this.settings.Location = new System.Drawing.Point(8, 7);
			this.settings.Margin = new System.Windows.Forms.Padding(4);
			this.settings.Name = "settings";
			this.settings.Padding = new System.Windows.Forms.Padding(4);
			this.settings.Size = new System.Drawing.Size(348, 153);
			this.settings.TabIndex = 68;
			this.settings.TabStop = false;
			this.settings.Text = "Settings";
			// 
			// playtestDuration
			// 
			this.playtestDuration.Location = new System.Drawing.Point(247, 85);
			this.playtestDuration.Margin = new System.Windows.Forms.Padding(4);
			this.playtestDuration.Name = "playtestDuration";
			this.playtestDuration.Size = new System.Drawing.Size(85, 22);
			this.playtestDuration.TabIndex = 6;
			this.playtestDuration.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 87);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(179, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "Playtest Duration (minutes)";
			// 
			// numOfParticipants
			// 
			this.numOfParticipants.Location = new System.Drawing.Point(247, 53);
			this.numOfParticipants.Margin = new System.Windows.Forms.Padding(4);
			this.numOfParticipants.Name = "numOfParticipants";
			this.numOfParticipants.Size = new System.Drawing.Size(85, 22);
			this.numOfParticipants.TabIndex = 4;
			this.numOfParticipants.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 55);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Number of Participants";
			// 
			// resetParticipants
			// 
			this.resetParticipants.Location = new System.Drawing.Point(13, 117);
			this.resetParticipants.Margin = new System.Windows.Forms.Padding(4);
			this.resetParticipants.Name = "resetParticipants";
			this.resetParticipants.Size = new System.Drawing.Size(319, 28);
			this.resetParticipants.TabIndex = 2;
			this.resetParticipants.Text = "Reset Tracker";
			this.resetParticipants.UseVisualStyleBackColor = true;
			this.resetParticipants.Click += new System.EventHandler(this.resetParticipants_Click);
			// 
			// acronymText
			// 
			this.acronymText.Location = new System.Drawing.Point(247, 21);
			this.acronymText.Margin = new System.Windows.Forms.Padding(4);
			this.acronymText.Name = "acronymText";
			this.acronymText.Size = new System.Drawing.Size(84, 22);
			this.acronymText.TabIndex = 1;
			this.acronymText.Text = "NAME";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Participant Acronym (MAX: 4 Chars)";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.Data);
			this.tabControl1.Location = new System.Drawing.Point(1208, 51);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(380, 200);
			this.tabControl1.TabIndex = 69;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.settings);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(372, 171);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Settings";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// Data
			// 
			this.Data.Controls.Add(this.participantProgressBar);
			this.Data.Controls.Add(this.participantProgress);
			this.Data.Location = new System.Drawing.Point(4, 25);
			this.Data.Margin = new System.Windows.Forms.Padding(4);
			this.Data.Name = "Data";
			this.Data.Padding = new System.Windows.Forms.Padding(4);
			this.Data.Size = new System.Drawing.Size(372, 171);
			this.Data.TabIndex = 1;
			this.Data.Text = "Data";
			this.Data.UseVisualStyleBackColor = true;
			// 
			// participantProgressBar
			// 
			this.participantProgressBar.Location = new System.Drawing.Point(19, 74);
			this.participantProgressBar.Margin = new System.Windows.Forms.Padding(4);
			this.participantProgressBar.Name = "participantProgressBar";
			this.participantProgressBar.Size = new System.Drawing.Size(304, 38);
			this.participantProgressBar.TabIndex = 2;
			// 
			// participantProgress
			// 
			this.participantProgress.AutoSize = true;
			this.participantProgress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.participantProgress.Location = new System.Drawing.Point(16, 42);
			this.participantProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.participantProgress.Name = "participantProgress";
			this.participantProgress.Size = new System.Drawing.Size(307, 23);
			this.participantProgress.TabIndex = 1;
			this.participantProgress.Text = "Participant Progress: 64/64";
			this.participantProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer_1
			// 
			this.timer_1.Interval = 1000;
			this.timer_1.Tag = "1";
			this.timer_1.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// participantControl8
			// 
			this.participantControl8.Form = null;
			this.participantControl8.Index = 0;
			this.participantControl8.Location = new System.Drawing.Point(12, 822);
			this.participantControl8.Name = "participantControl8";
			this.participantControl8.ParticipantName = "NAME_##";
			this.participantControl8.ParticipantNumber = 0;
			this.participantControl8.Size = new System.Drawing.Size(1188, 107);
			this.participantControl8.TabIndex = 77;
			// 
			// participantControl7
			// 
			this.participantControl7.Form = null;
			this.participantControl7.Index = 0;
			this.participantControl7.Location = new System.Drawing.Point(12, 709);
			this.participantControl7.Name = "participantControl7";
			this.participantControl7.ParticipantName = "NAME_##";
			this.participantControl7.ParticipantNumber = 0;
			this.participantControl7.Size = new System.Drawing.Size(1188, 107);
			this.participantControl7.TabIndex = 76;
			// 
			// participantControl6
			// 
			this.participantControl6.Form = null;
			this.participantControl6.Index = 0;
			this.participantControl6.Location = new System.Drawing.Point(12, 596);
			this.participantControl6.Name = "participantControl6";
			this.participantControl6.ParticipantName = "NAME_##";
			this.participantControl6.ParticipantNumber = 0;
			this.participantControl6.Size = new System.Drawing.Size(1188, 107);
			this.participantControl6.TabIndex = 75;
			// 
			// participantControl5
			// 
			this.participantControl5.Form = null;
			this.participantControl5.Index = 0;
			this.participantControl5.Location = new System.Drawing.Point(12, 483);
			this.participantControl5.Name = "participantControl5";
			this.participantControl5.ParticipantName = "NAME_##";
			this.participantControl5.ParticipantNumber = 0;
			this.participantControl5.Size = new System.Drawing.Size(1188, 107);
			this.participantControl5.TabIndex = 74;
			// 
			// participantControl4
			// 
			this.participantControl4.Form = null;
			this.participantControl4.Index = 0;
			this.participantControl4.Location = new System.Drawing.Point(12, 370);
			this.participantControl4.Name = "participantControl4";
			this.participantControl4.ParticipantName = "NAME_##";
			this.participantControl4.ParticipantNumber = 0;
			this.participantControl4.Size = new System.Drawing.Size(1188, 107);
			this.participantControl4.TabIndex = 73;
			// 
			// participantControl3
			// 
			this.participantControl3.Form = null;
			this.participantControl3.Index = 0;
			this.participantControl3.Location = new System.Drawing.Point(12, 257);
			this.participantControl3.Name = "participantControl3";
			this.participantControl3.ParticipantName = "NAME_##";
			this.participantControl3.ParticipantNumber = 0;
			this.participantControl3.Size = new System.Drawing.Size(1188, 107);
			this.participantControl3.TabIndex = 72;
			// 
			// participantControl2
			// 
			this.participantControl2.Form = null;
			this.participantControl2.Index = 0;
			this.participantControl2.Location = new System.Drawing.Point(12, 144);
			this.participantControl2.Name = "participantControl2";
			this.participantControl2.ParticipantName = "NAME_##";
			this.participantControl2.ParticipantNumber = 0;
			this.participantControl2.Size = new System.Drawing.Size(1188, 107);
			this.participantControl2.TabIndex = 71;
			// 
			// participantControl1
			// 
			this.participantControl1.Form = null;
			this.participantControl1.Index = 0;
			this.participantControl1.Location = new System.Drawing.Point(12, 31);
			this.participantControl1.Name = "participantControl1";
			this.participantControl1.ParticipantName = "NAME_##";
			this.participantControl1.ParticipantNumber = 0;
			this.participantControl1.Size = new System.Drawing.Size(1188, 107);
			this.participantControl1.TabIndex = 70;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(1208, 264);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 84);
			this.listBox1.TabIndex = 78;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 16;
			this.listBox2.Location = new System.Drawing.Point(1468, 264);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(120, 84);
			this.listBox2.TabIndex = 78;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.spreadsheetToolStripMenuItem,
            this.participantToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1684, 28);
			this.menuStrip1.TabIndex = 79;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// spreadsheetToolStripMenuItem
			// 
			this.spreadsheetToolStripMenuItem.Name = "spreadsheetToolStripMenuItem";
			this.spreadsheetToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
			this.spreadsheetToolStripMenuItem.Text = "Spreadsheet";
			this.spreadsheetToolStripMenuItem.Click += new System.EventHandler(this.OpenSpreadsheetOptions);
			// 
			// participantToolStripMenuItem
			// 
			this.participantToolStripMenuItem.Name = "participantToolStripMenuItem";
			this.participantToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.participantToolStripMenuItem.Text = "Study";
			// 
			// participantControl9
			// 
			this.participantControl9.Form = null;
			this.participantControl9.Index = 0;
			this.participantControl9.Location = new System.Drawing.Point(12, 935);
			this.participantControl9.Name = "participantControl9";
			this.participantControl9.ParticipantName = "NAME_##";
			this.participantControl9.ParticipantNumber = 0;
			this.participantControl9.Size = new System.Drawing.Size(1188, 107);
			this.participantControl9.TabIndex = 77;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(487, 136);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 80;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1684, 1047);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.participantControl9);
			this.Controls.Add(this.participantControl8);
			this.Controls.Add(this.participantControl7);
			this.Controls.Add(this.participantControl6);
			this.Controls.Add(this.participantControl5);
			this.Controls.Add(this.participantControl4);
			this.Controls.Add(this.participantControl3);
			this.Controls.Add(this.participantControl2);
			this.Controls.Add(this.participantControl1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.notfinishedList);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "UX Lab";
			this.settings.ResumeLayout(false);
			this.settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.playtestDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numOfParticipants)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.Data.ResumeLayout(false);
			this.Data.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.ListBox notfinishedList;
		private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.NumericUpDown numOfParticipants;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetParticipants;
        private System.Windows.Forms.TextBox acronymText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Data;
        private System.Windows.Forms.ProgressBar participantProgressBar;
        private System.Windows.Forms.Label participantProgress;
        private System.Windows.Forms.NumericUpDown playtestDuration;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Timer timer_1;
		private ParticipantControl participantControl1;
		private ParticipantControl participantControl2;
		private ParticipantControl participantControl3;
		private ParticipantControl participantControl4;
		private ParticipantControl participantControl5;
		private ParticipantControl participantControl6;
		private ParticipantControl participantControl7;
		private ParticipantControl participantControl8;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem spreadsheetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem participantToolStripMenuItem;
		private ParticipantControl participantControl9;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;

    }
}

