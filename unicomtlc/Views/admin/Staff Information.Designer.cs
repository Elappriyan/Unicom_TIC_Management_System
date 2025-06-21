namespace unicomtlc.Views
{
    partial class Staff_Information
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
            this.emailT = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.staffview = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.xbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(207, 162);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(164, 20);
            this.emailT.TabIndex = 1;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(207, 323);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(204, 90);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Full Name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(204, 146);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 0;
            this.email.Text = "Email";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(204, 198);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(78, 13);
            this.phone.TabIndex = 0;
            this.phone.Text = "Phone Number";
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(207, 214);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(164, 20);
            this.phonenumber.TabIndex = 1;
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(207, 106);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(164, 20);
            this.fullname.TabIndex = 1;
            this.fullname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(296, 323);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // staffview
            // 
            this.staffview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffview.Location = new System.Drawing.Point(488, 84);
            this.staffview.Name = "staffview";
            this.staffview.Size = new System.Drawing.Size(359, 304);
            this.staffview.TabIndex = 4;
            this.staffview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffview_CellContentClick);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(100, 323);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // xbtn
            // 
            this.xbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xbtn.Location = new System.Drawing.Point(686, 394);
            this.xbtn.Name = "xbtn";
            this.xbtn.Size = new System.Drawing.Size(161, 52);
            this.xbtn.TabIndex = 5;
            this.xbtn.Text = "Back";
            this.xbtn.UseVisualStyleBackColor = true;
            this.xbtn.Click += new System.EventHandler(this.xbtn_Click);
            // 
            // Staff_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.xbtn);
            this.Controls.Add(this.staffview);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.emailT);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Staff_Information";
            this.Text = "Staff_Information";
            this.Load += new System.EventHandler(this.Staff_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridView staffview;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button xbtn;
    }
}