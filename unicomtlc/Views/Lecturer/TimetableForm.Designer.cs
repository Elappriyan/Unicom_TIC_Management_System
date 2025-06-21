namespace unicomtlc.Views
{
    partial class TimetableForm
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
            this.Lecturerbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.SelectLecturer = new System.Windows.Forms.Label();
            this.Selectsubject = new System.Windows.Forms.Label();
            this.subjectbox = new System.Windows.Forms.ComboBox();
            this.daybox = new System.Windows.Forms.ComboBox();
            this.timebox = new System.Windows.Forms.ComboBox();
            this.selectday = new System.Windows.Forms.Label();
            this.Selecttime = new System.Windows.Forms.Label();
            this.roombox = new System.Windows.Forms.ComboBox();
            this.Selectroom = new System.Windows.Forms.Label();
            this.timetableview = new System.Windows.Forms.DataGridView();
            this.dele = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timetableview)).BeginInit();
            this.SuspendLayout();
            // 
            // Lecturerbox
            // 
            this.Lecturerbox.FormattingEnabled = true;
            this.Lecturerbox.Location = new System.Drawing.Point(61, 129);
            this.Lecturerbox.Name = "Lecturerbox";
            this.Lecturerbox.Size = new System.Drawing.Size(148, 21);
            this.Lecturerbox.TabIndex = 0;
            this.Lecturerbox.SelectedIndexChanged += new System.EventHandler(this.selectComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timetable Scheduler";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(61, 438);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(146, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add to Timetable";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // SelectLecturer
            // 
            this.SelectLecturer.AutoSize = true;
            this.SelectLecturer.Location = new System.Drawing.Point(58, 113);
            this.SelectLecturer.Name = "SelectLecturer";
            this.SelectLecturer.Size = new System.Drawing.Size(79, 13);
            this.SelectLecturer.TabIndex = 1;
            this.SelectLecturer.Text = "Select Lecturer";
            // 
            // Selectsubject
            // 
            this.Selectsubject.AutoSize = true;
            this.Selectsubject.Location = new System.Drawing.Point(58, 167);
            this.Selectsubject.Name = "Selectsubject";
            this.Selectsubject.Size = new System.Drawing.Size(76, 13);
            this.Selectsubject.TabIndex = 1;
            this.Selectsubject.Text = "Select Subject";
            // 
            // subjectbox
            // 
            this.subjectbox.FormattingEnabled = true;
            this.subjectbox.Location = new System.Drawing.Point(61, 183);
            this.subjectbox.Name = "subjectbox";
            this.subjectbox.Size = new System.Drawing.Size(148, 21);
            this.subjectbox.TabIndex = 0;
            // 
            // daybox
            // 
            this.daybox.FormattingEnabled = true;
            this.daybox.Location = new System.Drawing.Point(61, 236);
            this.daybox.Name = "daybox";
            this.daybox.Size = new System.Drawing.Size(148, 21);
            this.daybox.TabIndex = 0;
            // 
            // timebox
            // 
            this.timebox.FormattingEnabled = true;
            this.timebox.Location = new System.Drawing.Point(61, 293);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(148, 21);
            this.timebox.TabIndex = 0;
            // 
            // selectday
            // 
            this.selectday.AutoSize = true;
            this.selectday.Location = new System.Drawing.Point(58, 220);
            this.selectday.Name = "selectday";
            this.selectday.Size = new System.Drawing.Size(59, 13);
            this.selectday.TabIndex = 1;
            this.selectday.Text = "Select Day";
            // 
            // Selecttime
            // 
            this.Selecttime.AutoSize = true;
            this.Selecttime.Location = new System.Drawing.Point(58, 277);
            this.Selecttime.Name = "Selecttime";
            this.Selecttime.Size = new System.Drawing.Size(63, 13);
            this.Selecttime.TabIndex = 1;
            this.Selecttime.Text = "Select Time";
            // 
            // roombox
            // 
            this.roombox.FormattingEnabled = true;
            this.roombox.Location = new System.Drawing.Point(61, 345);
            this.roombox.Name = "roombox";
            this.roombox.Size = new System.Drawing.Size(148, 21);
            this.roombox.TabIndex = 0;
            // 
            // Selectroom
            // 
            this.Selectroom.AutoSize = true;
            this.Selectroom.Location = new System.Drawing.Point(58, 329);
            this.Selectroom.Name = "Selectroom";
            this.Selectroom.Size = new System.Drawing.Size(68, 13);
            this.Selectroom.TabIndex = 1;
            this.Selectroom.Text = "Select Room";
            // 
            // timetableview
            // 
            this.timetableview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableview.Location = new System.Drawing.Point(298, 129);
            this.timetableview.Name = "timetableview";
            this.timetableview.Size = new System.Drawing.Size(520, 237);
            this.timetableview.TabIndex = 3;
            this.timetableview.SelectionChanged += new System.EventHandler(this.timetableview_SelectionChanged);
            // 
            // dele
            // 
            this.dele.Location = new System.Drawing.Point(61, 483);
            this.dele.Name = "dele";
            this.dele.Size = new System.Drawing.Size(146, 23);
            this.dele.TabIndex = 4;
            this.dele.Text = "Delete";
            this.dele.UseVisualStyleBackColor = true;
            this.dele.Click += new System.EventHandler(this.dele_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(61, 533);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(146, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // black
            // 
            this.black.Location = new System.Drawing.Point(713, 533);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(148, 39);
            this.black.TabIndex = 6;
            this.black.Text = "Back";
            this.black.UseVisualStyleBackColor = true;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 639);
            this.Controls.Add(this.black);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dele);
            this.Controls.Add(this.timetableview);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Selectroom);
            this.Controls.Add(this.Selecttime);
            this.Controls.Add(this.selectday);
            this.Controls.Add(this.Selectsubject);
            this.Controls.Add(this.SelectLecturer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roombox);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.daybox);
            this.Controls.Add(this.subjectbox);
            this.Controls.Add(this.Lecturerbox);
            this.Name = "TimetableForm";
            this.Text = "Timetable Scheduler";
            this.Load += new System.EventHandler(this.TimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timetableview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Lecturerbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label SelectLecturer;
        private System.Windows.Forms.Label Selectsubject;
        private System.Windows.Forms.ComboBox subjectbox;
        private System.Windows.Forms.ComboBox daybox;
        private System.Windows.Forms.ComboBox timebox;
        private System.Windows.Forms.Label selectday;
        private System.Windows.Forms.Label Selecttime;
        private System.Windows.Forms.ComboBox roombox;
        private System.Windows.Forms.Label Selectroom;
        private System.Windows.Forms.DataGridView timetableview;
        private System.Windows.Forms.Button dele;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button black;
    }
}