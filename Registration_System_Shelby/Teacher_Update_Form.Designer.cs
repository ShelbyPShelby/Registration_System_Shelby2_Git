namespace Registration_System_Shelby
{
    partial class Teacher_Update_Form
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
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.TeacherUpdate = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.rank = new System.Windows.Forms.Label();
            this.rankTxt = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.TeacherCombo = new System.Windows.Forms.ComboBox();
            this.Teacher_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fnameTxt
            // 
            this.fnameTxt.Location = new System.Drawing.Point(194, 151);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(194, 20);
            this.fnameTxt.TabIndex = 0;
            // 
            // TeacherUpdate
            // 
            this.TeacherUpdate.AutoSize = true;
            this.TeacherUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.TeacherUpdate.Location = new System.Drawing.Point(249, 42);
            this.TeacherUpdate.Name = "TeacherUpdate";
            this.TeacherUpdate.Size = new System.Drawing.Size(355, 39);
            this.TeacherUpdate.TabIndex = 1;
            this.TeacherUpdate.Text = "Teacher Update Form";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fname.Location = new System.Drawing.Point(88, 150);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(49, 18);
            this.fname.TabIndex = 2;
            this.fname.Text = "fname";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lname.Location = new System.Drawing.Point(88, 200);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(48, 18);
            this.lname.TabIndex = 4;
            this.lname.Text = "lname";
            // 
            // lnameTxt
            // 
            this.lnameTxt.Location = new System.Drawing.Point(194, 201);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(194, 20);
            this.lnameTxt.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.title.Location = new System.Drawing.Point(88, 250);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(30, 18);
            this.title.TabIndex = 6;
            this.title.Text = "title";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(194, 251);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(194, 20);
            this.titleTxt.TabIndex = 2;
            // 
            // rank
            // 
            this.rank.AutoSize = true;
            this.rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rank.Location = new System.Drawing.Point(88, 300);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(37, 18);
            this.rank.TabIndex = 8;
            this.rank.Text = "rank";
            // 
            // rankTxt
            // 
            this.rankTxt.Location = new System.Drawing.Point(194, 301);
            this.rankTxt.Name = "rankTxt";
            this.rankTxt.Size = new System.Drawing.Size(194, 20);
            this.rankTxt.TabIndex = 3;
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
            // TeacherCombo
            // 
            this.TeacherCombo.FormattingEnabled = true;
            this.TeacherCombo.Location = new System.Drawing.Point(194, 105);
            this.TeacherCombo.Name = "TeacherCombo";
            this.TeacherCombo.Size = new System.Drawing.Size(194, 21);
            this.TeacherCombo.TabIndex = 9;
            this.TeacherCombo.SelectedIndexChanged += new System.EventHandler(this.teacherCombo_SelectedIndexChanged);
            // 
            // Teacher_ID
            // 
            this.Teacher_ID.AutoSize = true;
            this.Teacher_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Teacher_ID.Location = new System.Drawing.Point(88, 108);
            this.Teacher_ID.Name = "Teacher_ID";
            this.Teacher_ID.Size = new System.Drawing.Size(62, 18);
            this.Teacher_ID.TabIndex = 10;
            this.Teacher_ID.Text = "Teacher";
            // 
            // Teacher_Update_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Teacher_ID);
            this.Controls.Add(this.TeacherCombo);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.rankTxt);
            this.Controls.Add(this.title);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.lnameTxt);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.TeacherUpdate);
            this.Controls.Add(this.fnameTxt);
            this.Name = "Teacher_Update_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.Label TeacherUpdate;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.TextBox rankTxt;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox TeacherCombo;
        private System.Windows.Forms.Label Teacher_ID;
    }
}

