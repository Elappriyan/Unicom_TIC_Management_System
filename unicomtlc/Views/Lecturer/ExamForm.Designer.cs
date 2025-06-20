namespace unicomtlc.Views
{
    partial class ExamForm
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
            this.exam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.nexam = new System.Windows.Forms.TextBox();
            this.examdate = new System.Windows.Forms.Label();
            this.examview = new System.Windows.Forms.DataGridView();
            this.subject = new System.Windows.Forms.Label();
            this.subjectbox = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.examview)).BeginInit();
            this.SuspendLayout();
            // 
            // exam
            // 
            this.exam.AutoSize = true;
            this.exam.Location = new System.Drawing.Point(223, 114);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(64, 13);
            this.exam.TabIndex = 0;
            this.exam.Text = "Exam Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Managent";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(411, 213);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(330, 213);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(240, 213);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // nexam
            // 
            this.nexam.Location = new System.Drawing.Point(306, 111);
            this.nexam.Name = "nexam";
            this.nexam.Size = new System.Drawing.Size(200, 20);
            this.nexam.TabIndex = 1;
            // 
            // examdate
            // 
            this.examdate.AutoSize = true;
            this.examdate.Location = new System.Drawing.Point(223, 148);
            this.examdate.Name = "examdate";
            this.examdate.Size = new System.Drawing.Size(59, 13);
            this.examdate.TabIndex = 0;
            this.examdate.Text = "Exam Date";
            this.examdate.Click += new System.EventHandler(this.examdate_Click);
            // 
            // examview
            // 
            this.examview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examview.Location = new System.Drawing.Point(158, 242);
            this.examview.Name = "examview";
            this.examview.Size = new System.Drawing.Size(438, 206);
            this.examview.TabIndex = 3;
            this.examview.SelectionChanged += new System.EventHandler(this.examview_SelectionChanged);
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(223, 189);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(43, 13);
            this.subject.TabIndex = 0;
            this.subject.Text = "Subject";
            this.subject.Click += new System.EventHandler(this.examdate_Click);
            // 
            // subjectbox
            // 
            this.subjectbox.FormattingEnabled = true;
            this.subjectbox.Location = new System.Drawing.Point(306, 181);
            this.subjectbox.Name = "subjectbox";
            this.subjectbox.Size = new System.Drawing.Size(200, 21);
            this.subjectbox.TabIndex = 4;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(306, 148);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 5;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date);
            this.Controls.Add(this.subjectbox);
            this.Controls.Add(this.examview);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.nexam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.examdate);
            this.Controls.Add(this.exam);
            this.Name = "ExamForm";
            this.Text = "ExamDate";
            ((System.ComponentModel.ISupportInitialize)(this.examview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox nexam;
        private System.Windows.Forms.Label examdate;
        private System.Windows.Forms.DataGridView examview;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.ComboBox subjectbox;
        private System.Windows.Forms.DateTimePicker date;
    }
}