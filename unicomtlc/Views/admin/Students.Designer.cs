namespace unicomtlc.Views
{
    partial class Students
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Studentview = new System.Windows.Forms.DataGridView();
            this.courseid = new System.Windows.Forms.ComboBox();
            this.course = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Studentview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(244, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 1;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(244, 91);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(121, 20);
            this.address.TabIndex = 1;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(244, 139);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(121, 20);
            this.age.TabIndex = 1;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(432, 84);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(432, 48);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Studentview
            // 
            this.Studentview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Studentview.Location = new System.Drawing.Point(145, 234);
            this.Studentview.Name = "Studentview";
            this.Studentview.Size = new System.Drawing.Size(484, 204);
            this.Studentview.TabIndex = 3;
            this.Studentview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Studentview_CellContentClick);
            this.Studentview.SelectionChanged += new System.EventHandler(this.Studentview_SelectionChanged);
            // 
            // courseid
            // 
            this.courseid.FormattingEnabled = true;
            this.courseid.Location = new System.Drawing.Point(244, 176);
            this.courseid.Name = "courseid";
            this.courseid.Size = new System.Drawing.Size(121, 21);
            this.courseid.TabIndex = 4;
            this.courseid.SelectedIndexChanged += new System.EventHandler(this.courseid_SelectedIndexChanged);
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(170, 179);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(68, 13);
            this.course.TabIndex = 0;
            this.course.Text = "CourseName";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(432, 136);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseid);
            this.Controls.Add(this.Studentview);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.age);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.course);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Students";
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.Studentview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView Studentview;
        private System.Windows.Forms.ComboBox courseid;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Button delete;
    }
}