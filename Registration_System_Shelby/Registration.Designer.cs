namespace Registration_System_Shelby
{
    partial class Registration
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
            this.SectionInsert = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.Label();
            this.section_id = new System.Windows.Forms.Label();
            this.daysTxt = new System.Windows.Forms.TextBox();
            this.days = new System.Windows.Forms.Label();
            this.startTxt = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.Label();
            this.endTxt = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.studentCombo = new System.Windows.Forms.ComboBox();
            this.endTime = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.gradeTxt = new System.Windows.Forms.TextBox();
            this.sectionCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SectionInsert
            // 
            this.SectionInsert.AutoSize = true;
            this.SectionInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.SectionInsert.Location = new System.Drawing.Point(167, 26);
            this.SectionInsert.Name = "SectionInsert";
            this.SectionInsert.Size = new System.Drawing.Size(390, 39);
            this.SectionInsert.TabIndex = 1;
            this.SectionInsert.Text = "Registration Insert Form";
            // 
            // student_id
            // 
            this.student_id.AutoSize = true;
            this.student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.student_id.Location = new System.Drawing.Point(88, 92);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(56, 18);
            this.student_id.TabIndex = 2;
            this.student_id.Text = "student";
            this.student_id.Click += new System.EventHandler(this.fname_Click);
            // 
            // section_id
            // 
            this.section_id.AutoSize = true;
            this.section_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.section_id.Location = new System.Drawing.Point(88, 138);
            this.section_id.Name = "section_id";
            this.section_id.Size = new System.Drawing.Size(56, 18);
            this.section_id.TabIndex = 4;
            this.section_id.Text = "section";
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
            // studentCombo
            // 
            this.studentCombo.FormattingEnabled = true;
            this.studentCombo.Location = new System.Drawing.Point(194, 93);
            this.studentCombo.Name = "studentCombo";
            this.studentCombo.Size = new System.Drawing.Size(194, 21);
            this.studentCombo.TabIndex = 9;
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
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grade.Location = new System.Drawing.Point(88, 182);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(97, 18);
            this.grade.TabIndex = 12;
            this.grade.Text = "section name";
            // 
            // gradeTxt
            // 
            this.gradeTxt.Location = new System.Drawing.Point(194, 183);
            this.gradeTxt.Name = "gradeTxt";
            this.gradeTxt.Size = new System.Drawing.Size(194, 20);
            this.gradeTxt.TabIndex = 11;
            // 
            // sectionCombo
            // 
            this.sectionCombo.FormattingEnabled = true;
            this.sectionCombo.Location = new System.Drawing.Point(194, 135);
            this.sectionCombo.Name = "sectionCombo";
            this.sectionCombo.Size = new System.Drawing.Size(194, 21);
            this.sectionCombo.TabIndex = 13;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sectionCombo);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.gradeTxt);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.studentCombo);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.endTxt);
            this.Controls.Add(this.days);
            this.Controls.Add(this.startTxt);
            this.Controls.Add(this.section_id);
            this.Controls.Add(this.daysTxt);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.SectionInsert);
            this.Name = "Registration";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SectionInsert;
        private System.Windows.Forms.Label student_id;
        private System.Windows.Forms.Label section_id;
        private System.Windows.Forms.TextBox daysTxt;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.TextBox startTxt;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.TextBox endTxt;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox studentCombo;
        private System.Windows.Forms.Label endTime;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.TextBox gradeTxt;
        private System.Windows.Forms.ComboBox sectionCombo;
    }
}

