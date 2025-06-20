namespace unicomtlc
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
            this.NameT = new System.Windows.Forms.Label();
            this.AdderssT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.usert = new System.Windows.Forms.TextBox();
            this.adderss = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameT
            // 
            this.NameT.AutoSize = true;
            this.NameT.Location = new System.Drawing.Point(148, 118);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(35, 13);
            this.NameT.TabIndex = 0;
            this.NameT.Text = "Name";
            // 
            // AdderssT
            // 
            this.AdderssT.AutoSize = true;
            this.AdderssT.Location = new System.Drawing.Point(148, 143);
            this.AdderssT.Name = "AdderssT";
            this.AdderssT.Size = new System.Drawing.Size(45, 13);
            this.AdderssT.TabIndex = 0;
            this.AdderssT.Text = "Adderss";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Details";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(246, 115);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(175, 20);
            this.name.TabIndex = 2;
            // 
            // usert
            // 
            this.usert.Location = new System.Drawing.Point(246, 174);
            this.usert.Name = "usert";
            this.usert.Size = new System.Drawing.Size(175, 20);
            this.usert.TabIndex = 2;
            // 
            // adderss
            // 
            this.adderss.Location = new System.Drawing.Point(246, 143);
            this.adderss.Name = "adderss";
            this.adderss.Size = new System.Drawing.Size(175, 20);
            this.adderss.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adderss);
            this.Controls.Add(this.usert);
            this.Controls.Add(this.name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AdderssT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameT);
            this.Name = "Form1";
            this.Text = "Loginf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameT;
        private System.Windows.Forms.Label AdderssT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox usert;
        private System.Windows.Forms.TextBox adderss;
    }
}

