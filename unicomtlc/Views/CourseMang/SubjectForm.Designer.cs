namespace unicomtlc.Views.CourseMang
{
    partial class SubjectForm
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
            this.subjectname = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SubjectView = new System.Windows.Forms.DataGridView();
            this.couresname = new System.Windows.Forms.Label();
            this.couresbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Add";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(295, 125);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(237, 20);
            this.name.TabIndex = 1;
            // 
            // subjectname
            // 
            this.subjectname.AutoSize = true;
            this.subjectname.Location = new System.Drawing.Point(204, 128);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(74, 13);
            this.subjectname.TabIndex = 0;
            this.subjectname.Text = "Subject Name";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(252, 210);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(350, 210);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(446, 210);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // SubjectView
            // 
            this.SubjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectView.Location = new System.Drawing.Point(221, 258);
            this.SubjectView.Name = "SubjectView";
            this.SubjectView.Size = new System.Drawing.Size(300, 150);
            this.SubjectView.TabIndex = 3;
            this.SubjectView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectView_CellContentClick);
            // 
            // couresname
            // 
            this.couresname.AutoSize = true;
            this.couresname.Location = new System.Drawing.Point(204, 160);
            this.couresname.Name = "couresname";
            this.couresname.Size = new System.Drawing.Size(71, 13);
            this.couresname.TabIndex = 0;
            this.couresname.Text = "Coures Name";
            // 
            // couresbox
            // 
            this.couresbox.FormattingEnabled = true;
            this.couresbox.Location = new System.Drawing.Point(295, 160);
            this.couresbox.Name = "couresbox";
            this.couresbox.Size = new System.Drawing.Size(237, 21);
            this.couresbox.TabIndex = 4;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.couresbox);
            this.Controls.Add(this.SubjectView);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.name);
            this.Controls.Add(this.couresname);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.label1);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label subjectname;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView SubjectView;
        private System.Windows.Forms.Label couresname;
        private System.Windows.Forms.ComboBox couresbox;
    }
}