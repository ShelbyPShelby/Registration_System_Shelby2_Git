namespace Registration_System_Shelby
{
    partial class Section
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
            this.courseTxt = new System.Windows.Forms.TextBox();
            this.SectionInsert = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.Label();
            this.daysTxt = new System.Windows.Forms.TextBox();
            this.days = new System.Windows.Forms.Label();
            this.startTxt = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.Label();
            this.endTxt = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.teacherCombo = new System.Windows.Forms.ComboBox();
            this.endTime = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.sectionTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // courseTxt
            // 
            this.courseTxt.Location = new System.Drawing.Point(194, 139);
            this.courseTxt.Name = "courseTxt";
            this.courseTxt.Size = new System.Drawing.Size(194, 20);
            this.courseTxt.TabIndex = 0;
            // 
            // SectionInsert
            // 
            this.SectionInsert.AutoSize = true;
            this.SectionInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.SectionInsert.Location = new System.Drawing.Point(167, 26);
            this.SectionInsert.Name = "SectionInsert";
            this.SectionInsert.Size = new System.Drawing.Size(320, 39);
            this.SectionInsert.TabIndex = 1;
            this.SectionInsert.Text = "Section Insert Form";
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teacher.Location = new System.Drawing.Point(88, 92);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(57, 18);
            this.teacher.TabIndex = 2;
            this.teacher.Text = "teacher";
            this.teacher.Click += new System.EventHandler(this.fname_Click);
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.courseName.Location = new System.Drawing.Point(88, 138);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(95, 18);
            this.courseName.TabIndex = 4;
            this.courseName.Text = "course name";
            // 
            // daysTxt
            // 
            this.daysTxt.Location = new System.Drawing.Point(194, 223);
            this.daysTxt.Name = "daysTxt";
            this.daysTxt.Size = new System.Drawing.Size(194, 20);
            this.daysTxt.TabIndex = 1;
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.days.Location = new System.Drawing.Point(88, 223);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(39, 18);
            this.days.TabIndex = 6;
            this.days.Text = "days";
            // 
            // startTxt
            // 
            this.startTxt.Location = new System.Drawing.Point(194, 268);
            this.startTxt.Name = "startTxt";
            this.startTxt.Size = new System.Drawing.Size(194, 20);
            this.startTxt.TabIndex = 2;
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.startTime.Location = new System.Drawing.Point(88, 269);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(69, 18);
            this.startTime.TabIndex = 8;
            this.startTime.Text = "start time";
            // 
            // endTxt
            // 
            this.endTxt.Location = new System.Drawing.Point(194, 313);
            this.endTxt.Name = "endTxt";
            this.endTxt.Size = new System.Drawing.Size(194, 20);
            this.endTxt.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(214, 369);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(371, 369);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // teacherCombo
            // 
            this.teacherCombo.FormattingEnabled = true;
            this.teacherCombo.Location = new System.Drawing.Point(194, 93);
            this.teacherCombo.Name = "teacherCombo";
            this.teacherCombo.Size = new System.Drawing.Size(194, 21);
            this.teacherCombo.TabIndex = 9;
            // 
            // endTime
            // 
            this.endTime.AutoSize = true;
            this.endTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.endTime.Location = new System.Drawing.Point(88, 315);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(64, 18);
            this.endTime.TabIndex = 10;
            this.endTime.Text = "end time";
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sectionLabel.Location = new System.Drawing.Point(88, 182);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(97, 18);
            this.sectionLabel.TabIndex = 12;
            this.sectionLabel.Text = "section name";
            // 
            // sectionTxt
            // 
            this.sectionTxt.Location = new System.Drawing.Point(194, 183);
            this.sectionTxt.Name = "sectionTxt";
            this.sectionTxt.Size = new System.Drawing.Size(194, 20);
            this.sectionTxt.TabIndex = 11;
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.sectionTxt);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.teacherCombo);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.endTxt);
            this.Controls.Add(this.days);
            this.Controls.Add(this.startTxt);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.daysTxt);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.SectionInsert);
            this.Controls.Add(this.courseTxt);
            this.Name = "Section";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseTxt;
        private System.Windows.Forms.Label SectionInsert;
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.TextBox daysTxt;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.TextBox startTxt;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.TextBox endTxt;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox teacherCombo;
        private System.Windows.Forms.Label endTime;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.TextBox sectionTxt;
    }
}

