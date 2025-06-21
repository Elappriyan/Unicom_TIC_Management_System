namespace unicomtlc.Views.admin
{
    partial class CourseForm
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
            this.DeleteCourse = new System.Windows.Forms.Button();
            this.couresname = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.couresview = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.couresview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coures";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(268, 163);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(195, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // DeleteCourse
            // 
            this.DeleteCourse.Location = new System.Drawing.Point(212, 215);
            this.DeleteCourse.Name = "DeleteCourse";
            this.DeleteCourse.Size = new System.Drawing.Size(75, 23);
            this.DeleteCourse.TabIndex = 2;
            this.DeleteCourse.Text = "Delete";
            this.DeleteCourse.UseVisualStyleBackColor = true;
            this.DeleteCourse.Click += new System.EventHandler(this.Button1_Click);
            // 
            // couresname
            // 
            this.couresname.AutoSize = true;
            this.couresname.Location = new System.Drawing.Point(194, 166);
            this.couresname.Name = "couresname";
            this.couresname.Size = new System.Drawing.Size(68, 13);
            this.couresname.TabIndex = 0;
            this.couresname.Text = "CouresName";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(302, 215);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // couresview
            // 
            this.couresview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couresview.Location = new System.Drawing.Point(128, 272);
            this.couresview.Name = "couresview";
            this.couresview.Size = new System.Drawing.Size(471, 166);
            this.couresview.TabIndex = 3;
            this.couresview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Couresview_CellContentClick);
            this.couresview.SelectionChanged += new System.EventHandler(this.Couresview_SelectionChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(388, 215);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(619, 215);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 4;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.couresview);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.DeleteCourse);
            this.Controls.Add(this.name);
            this.Controls.Add(this.couresname);
            this.Controls.Add(this.label1);
            this.Name = "CourseForm";
            this.Text = "Coures";
            ((System.ComponentModel.ISupportInitialize)(this.couresview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button DeleteCourse;
        private System.Windows.Forms.Label couresname;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView couresview;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Backbutton;
    }
}