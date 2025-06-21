namespace unicomtlc.Views
{
    partial class Add_Admin_User
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
            this.username = new System.Windows.Forms.Label();
            this.userpassword = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.roleM = new System.Windows.Forms.ComboBox();
            this.newB = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.saveB = new System.Windows.Forms.Button();
            this.editB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.Addview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Addview)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(63, 51);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(60, 13);
            this.username.TabIndex = 0;
            this.username.Text = "User Name";
            // 
            // userpassword
            // 
            this.userpassword.AutoSize = true;
            this.userpassword.Location = new System.Drawing.Point(70, 87);
            this.userpassword.Name = "userpassword";
            this.userpassword.Size = new System.Drawing.Size(53, 13);
            this.userpassword.TabIndex = 0;
            this.userpassword.Text = "Password";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(94, 117);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(29, 13);
            this.role.TabIndex = 0;
            this.role.Text = "Role";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(129, 80);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(157, 20);
            this.password.TabIndex = 1;
            // 
            // roleM
            // 
            this.roleM.FormattingEnabled = true;
            this.roleM.Location = new System.Drawing.Point(129, 109);
            this.roleM.Name = "roleM";
            this.roleM.Size = new System.Drawing.Size(157, 21);
            this.roleM.TabIndex = 2;
            this.roleM.SelectedIndexChanged += new System.EventHandler(this.RoleM_SelectedIndexChanged);
            // 
            // newB
            // 
            this.newB.Location = new System.Drawing.Point(188, 189);
            this.newB.Name = "newB";
            this.newB.Size = new System.Drawing.Size(98, 23);
            this.newB.TabIndex = 3;
            this.newB.Text = "New";
            this.newB.UseVisualStyleBackColor = true;
            this.newB.Click += new System.EventHandler(this.Button1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(129, 48);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 20);
            this.name.TabIndex = 1;
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(188, 218);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(98, 23);
            this.saveB.TabIndex = 3;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.Button2_Click);
            // 
            // editB
            // 
            this.editB.Location = new System.Drawing.Point(188, 247);
            this.editB.Name = "editB";
            this.editB.Size = new System.Drawing.Size(98, 23);
            this.editB.TabIndex = 3;
            this.editB.Text = "Edit";
            this.editB.UseVisualStyleBackColor = true;
            this.editB.Click += new System.EventHandler(this.Button3_Click);
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(188, 276);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(98, 23);
            this.deleteB.TabIndex = 3;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.Button4_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(188, 305);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(98, 23);
            this.cancelB.TabIndex = 3;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Addview
            // 
            this.Addview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Addview.Location = new System.Drawing.Point(348, 62);
            this.Addview.Name = "Addview";
            this.Addview.Size = new System.Drawing.Size(324, 295);
            this.Addview.TabIndex = 4;
            this.Addview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Addview_CellContentClick);
            this.Addview.SelectionChanged += new System.EventHandler(this.Addview_SelectionChanged);
            // 
            // Add_Admin_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 366);
            this.Controls.Add(this.Addview);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.editB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.newB);
            this.Controls.Add(this.roleM);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.role);
            this.Controls.Add(this.userpassword);
            this.Controls.Add(this.username);
            this.Name = "Add_Admin_User";
            this.Text = "Add_Admin_User";
            this.Load += new System.EventHandler(this.Add_Admin_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Addview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label userpassword;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox roleM;
        private System.Windows.Forms.Button newB;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button editB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.DataGridView Addview;
    }
}