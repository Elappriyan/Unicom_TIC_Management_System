namespace unicomtlc.Views
{
    partial class MainForm
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
            this.course_subject = new System.Windows.Forms.Button();
            this.exam_marksM = new System.Windows.Forms.Button();
            this.studentM = new System.Windows.Forms.Button();
            this.lecturerM = new System.Windows.Forms.Button();
            this.timetableM = new System.Windows.Forms.Button();
            this.staffM = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // course_subject
            // 
            this.course_subject.Location = new System.Drawing.Point(205, 155);
            this.course_subject.Name = "course_subject";
            this.course_subject.Size = new System.Drawing.Size(165, 78);
            this.course_subject.TabIndex = 0;
            this.course_subject.Text = "Course & Subject Management ";
            this.course_subject.UseVisualStyleBackColor = true;
            this.course_subject.Click += new System.EventHandler(this.course_subject_Click);
            // 
            // exam_marksM
            // 
            this.exam_marksM.Location = new System.Drawing.Point(205, 270);
            this.exam_marksM.Name = "exam_marksM";
            this.exam_marksM.Size = new System.Drawing.Size(165, 78);
            this.exam_marksM.TabIndex = 0;
            this.exam_marksM.Text = " Exam & Marks Management";
            this.exam_marksM.UseVisualStyleBackColor = true;
            this.exam_marksM.Click += new System.EventHandler(this.exam_marksM_Click);
            // 
            // studentM
            // 
            this.studentM.Location = new System.Drawing.Point(426, 155);
            this.studentM.Name = "studentM";
            this.studentM.Size = new System.Drawing.Size(165, 78);
            this.studentM.TabIndex = 0;
            this.studentM.Text = "Student Management ";
            this.studentM.UseVisualStyleBackColor = true;
            this.studentM.Click += new System.EventHandler(this.studentM_Click);
            // 
            // lecturerM
            // 
            this.lecturerM.Location = new System.Drawing.Point(630, 270);
            this.lecturerM.Name = "lecturerM";
            this.lecturerM.Size = new System.Drawing.Size(165, 78);
            this.lecturerM.TabIndex = 0;
            this.lecturerM.Text = "Lecturer Management";
            this.lecturerM.UseVisualStyleBackColor = true;
            this.lecturerM.Click += new System.EventHandler(this.lecturerM_Click);
            // 
            // timetableM
            // 
            this.timetableM.Location = new System.Drawing.Point(426, 270);
            this.timetableM.Name = "timetableM";
            this.timetableM.Size = new System.Drawing.Size(165, 78);
            this.timetableM.TabIndex = 0;
            this.timetableM.Text = " Timetable Management";
            this.timetableM.UseVisualStyleBackColor = true;
            this.timetableM.Click += new System.EventHandler(this.timetableM_Click);
            // 
            // staffM
            // 
            this.staffM.Location = new System.Drawing.Point(630, 155);
            this.staffM.Name = "staffM";
            this.staffM.Size = new System.Drawing.Size(165, 78);
            this.staffM.TabIndex = 0;
            this.staffM.Text = "Staff Management";
            this.staffM.UseVisualStyleBackColor = true;
            this.staffM.Click += new System.EventHandler(this.staffM_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(962, 1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(107, 26);
            this.logout.TabIndex = 0;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(445, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Admin";
            // 
            // addM
            // 
            this.addM.Location = new System.Drawing.Point(426, 390);
            this.addM.Name = "addM";
            this.addM.Size = new System.Drawing.Size(165, 78);
            this.addM.TabIndex = 0;
            this.addM.Text = " Add User/Admin";
            this.addM.UseVisualStyleBackColor = true;
            this.addM.Click += new System.EventHandler(this.addM_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.timetableM);
            this.Controls.Add(this.staffM);
            this.Controls.Add(this.addM);
            this.Controls.Add(this.lecturerM);
            this.Controls.Add(this.studentM);
            this.Controls.Add(this.exam_marksM);
            this.Controls.Add(this.course_subject);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button course_subject;
        private System.Windows.Forms.Button exam_marksM;
        private System.Windows.Forms.Button studentM;
        private System.Windows.Forms.Button lecturerM;
        private System.Windows.Forms.Button timetableM;
        private System.Windows.Forms.Button staffM;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addM;
    }
}