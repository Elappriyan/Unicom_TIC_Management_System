namespace unicomtlc.Views
{
    partial class LecturerDetails
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
            this.name = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.Label();
            this.departmentT = new System.Windows.Forms.Label();
            this.gmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.lecturerview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer Details ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(167, 83);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(170, 20);
            this.name.TabIndex = 1;
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.Location = new System.Drawing.Point(91, 86);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(54, 13);
            this.fullname.TabIndex = 0;
            this.fullname.Text = "Full Name";
            // 
            // departmentT
            // 
            this.departmentT.AutoSize = true;
            this.departmentT.Location = new System.Drawing.Point(91, 208);
            this.departmentT.Name = "departmentT";
            this.departmentT.Size = new System.Drawing.Size(62, 13);
            this.departmentT.TabIndex = 0;
            this.departmentT.Text = "Department";
            this.departmentT.Click += new System.EventHandler(this.departmentT_Click);
            // 
            // gmail
            // 
            this.gmail.Location = new System.Drawing.Point(167, 118);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(170, 20);
            this.gmail.TabIndex = 1;
            this.gmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(91, 125);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 0;
            this.email.Text = "Email";
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(167, 161);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(170, 20);
            this.phonenumber.TabIndex = 1;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(83, 168);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(78, 13);
            this.phone.TabIndex = 0;
            this.phone.Text = "Phone Number";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(262, 270);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(167, 270);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(5, 270);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(86, 270);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // lecturerview
            // 
            this.lecturerview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturerview.Location = new System.Drawing.Point(346, 37);
            this.lecturerview.Name = "lecturerview";
            this.lecturerview.Size = new System.Drawing.Size(450, 377);
            this.lecturerview.TabIndex = 4;
            this.lecturerview.SelectionChanged += new System.EventHandler(this.lecturerview_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lecturer list";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(167, 205);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(170, 20);
            this.department.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(713, 414);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 37);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LecturerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.lecturerview);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.department);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.name);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.departmentT);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LecturerDetails";
            this.Text = "LecturerDetails";
            this.Load += new System.EventHandler(this.LecturerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Label departmentT;
        private System.Windows.Forms.TextBox gmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView lecturerview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Button Back;
    }
}