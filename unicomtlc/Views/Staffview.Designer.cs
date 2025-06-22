namespace unicomtlc.Views
{
    partial class Staffview
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
            this.mark = new System.Windows.Forms.Button();
            this.room = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.staview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.staview)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Timetable View And Add Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(12, 120);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(264, 23);
            this.mark.TabIndex = 1;
            this.mark.Text = " Marks Add/Edit ";
            this.mark.UseVisualStyleBackColor = true;
            this.mark.Click += new System.EventHandler(this.mark_Click);
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(12, 204);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(264, 23);
            this.room.TabIndex = 2;
            this.room.Text = " Room Add/Delete";
            this.room.UseVisualStyleBackColor = true;
            this.room.Click += new System.EventHandler(this.room_Click);
            // 
            // Staff
            // 
            this.Staff.Location = new System.Drawing.Point(12, 247);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(264, 23);
            this.Staff.TabIndex = 3;
            this.Staff.Text = "Staff Details view";
            this.Staff.UseVisualStyleBackColor = true;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exam Add/Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // staview
            // 
            this.staview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staview.Location = new System.Drawing.Point(339, 29);
            this.staview.Name = "staview";
            this.staview.Size = new System.Drawing.Size(323, 393);
            this.staview.TabIndex = 6;
            // 
            // Staffview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.staview);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.room);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.button1);
            this.Name = "Staffview";
            this.Text = "Staffview";
            this.Load += new System.EventHandler(this.Staffview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mark;
        private System.Windows.Forms.Button room;
        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView staview;
    }
}