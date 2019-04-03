namespace Registration_System_Shelby
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
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.StudentInsert = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.major = new System.Windows.Forms.Label();
            this.majorTxt = new System.Windows.Forms.TextBox();
            this.degree = new System.Windows.Forms.Label();
            this.degreeTxt = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fnameTxt
            // 
            this.fnameTxt.Location = new System.Drawing.Point(194, 132);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(194, 20);
            this.fnameTxt.TabIndex = 0;
            // 
            // StudentInsert
            // 
            this.StudentInsert.AutoSize = true;
            this.StudentInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.StudentInsert.Location = new System.Drawing.Point(249, 42);
            this.StudentInsert.Name = "StudentInsert";
            this.StudentInsert.Size = new System.Drawing.Size(323, 39);
            this.StudentInsert.TabIndex = 1;
            this.StudentInsert.Text = "Student Insert Form";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fname.Location = new System.Drawing.Point(88, 131);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(49, 18);
            this.fname.TabIndex = 2;
            this.fname.Text = "fname";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lname.Location = new System.Drawing.Point(88, 181);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(48, 18);
            this.lname.TabIndex = 4;
            this.lname.Text = "lname";
            // 
            // lnameTxt
            // 
            this.lnameTxt.Location = new System.Drawing.Point(194, 182);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(194, 20);
            this.lnameTxt.TabIndex = 1;
            // 
            // major
            // 
            this.major.AutoSize = true;
            this.major.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.major.Location = new System.Drawing.Point(88, 231);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(46, 18);
            this.major.TabIndex = 6;
            this.major.Text = "major";
            // 
            // majorTxt
            // 
            this.majorTxt.Location = new System.Drawing.Point(194, 232);
            this.majorTxt.Name = "majorTxt";
            this.majorTxt.Size = new System.Drawing.Size(194, 20);
            this.majorTxt.TabIndex = 2;
            // 
            // degree
            // 
            this.degree.AutoSize = true;
            this.degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.degree.Location = new System.Drawing.Point(88, 281);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(53, 18);
            this.degree.TabIndex = 8;
            this.degree.Text = "degree";
            // 
            // degreeTxt
            // 
            this.degreeTxt.Location = new System.Drawing.Point(194, 282);
            this.degreeTxt.Name = "degreeTxt";
            this.degreeTxt.Size = new System.Drawing.Size(194, 20);
            this.degreeTxt.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.degreeTxt);
            this.Controls.Add(this.major);
            this.Controls.Add(this.majorTxt);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.lnameTxt);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.StudentInsert);
            this.Controls.Add(this.fnameTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.Label StudentInsert;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.Label major;
        private System.Windows.Forms.TextBox majorTxt;
        private System.Windows.Forms.Label degree;
        private System.Windows.Forms.TextBox degreeTxt;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
    }
}

