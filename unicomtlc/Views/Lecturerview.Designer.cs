namespace unicomtlc.Views
{
    partial class Lecturerview
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
            this.button1 = new System.Windows.Forms.Button();
            this.MarksButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lecturer = new System.Windows.Forms.Button();
            this.lecrviwe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lecrviwe)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Timetable View And Add Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MarksButton
            // 
            this.MarksButton.Location = new System.Drawing.Point(29, 123);
            this.MarksButton.Name = "MarksButton";
            this.MarksButton.Size = new System.Drawing.Size(284, 23);
            this.MarksButton.TabIndex = 0;
            this.MarksButton.Text = "Marks and Add/Edit ";
            this.MarksButton.UseVisualStyleBackColor = true;
            this.MarksButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Exam Add/Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // lecturer
            // 
            this.lecturer.Location = new System.Drawing.Point(29, 193);
            this.lecturer.Name = "lecturer";
            this.lecturer.Size = new System.Drawing.Size(284, 23);
            this.lecturer.TabIndex = 1;
            this.lecturer.Text = "Lecturer Details";
            this.lecturer.UseVisualStyleBackColor = true;
            this.lecturer.Click += new System.EventHandler(this.Button4_Click);
            // 
            // lecrviwe
            // 
            this.lecrviwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecrviwe.Location = new System.Drawing.Point(334, 36);
            this.lecrviwe.Name = "lecrviwe";
            this.lecrviwe.Size = new System.Drawing.Size(467, 411);
            this.lecrviwe.TabIndex = 2;
            this.lecrviwe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lecrviwe_CellContentClick);
            // 
            // Lecturerview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lecrviwe);
            this.Controls.Add(this.lecturer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.MarksButton);
            this.Controls.Add(this.button1);
            this.Name = "Lecturerview";
            this.Text = "Lecturerview";
            ((System.ComponentModel.ISupportInitialize)(this.lecrviwe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MarksButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button lecturer;
        private System.Windows.Forms.DataGridView lecrviwe;
    }
}