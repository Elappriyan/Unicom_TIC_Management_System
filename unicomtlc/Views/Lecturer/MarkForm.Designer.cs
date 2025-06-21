namespace unicomtlc.Views
{
    partial class MarkForm
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
            this.sthudentidL = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.examidL = new System.Windows.Forms.Label();
            this.markL = new System.Windows.Forms.Label();
            this.markt = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.markview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exambox = new System.Windows.Forms.ComboBox();
            this.namebox = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.markview)).BeginInit();
            this.SuspendLayout();
            // 
            // sthudentidL
            // 
            this.sthudentidL.AutoSize = true;
            this.sthudentidL.Location = new System.Drawing.Point(183, 110);
            this.sthudentidL.Name = "sthudentidL";
            this.sthudentidL.Size = new System.Drawing.Size(75, 13);
            this.sthudentidL.TabIndex = 0;
            this.sthudentidL.Text = "Student Name";
            this.sthudentidL.Click += new System.EventHandler(this.label1_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(267, 299);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // examidL
            // 
            this.examidL.AutoSize = true;
            this.examidL.Location = new System.Drawing.Point(183, 151);
            this.examidL.Name = "examidL";
            this.examidL.Size = new System.Drawing.Size(64, 13);
            this.examidL.TabIndex = 0;
            this.examidL.Text = "Exam Name";
            // 
            // markL
            // 
            this.markL.AutoSize = true;
            this.markL.Location = new System.Drawing.Point(183, 193);
            this.markL.Name = "markL";
            this.markL.Size = new System.Drawing.Size(35, 13);
            this.markL.TabIndex = 0;
            this.markL.Text = "Score";
            this.markL.Click += new System.EventHandler(this.markL_Click);
            // 
            // markt
            // 
            this.markt.Location = new System.Drawing.Point(264, 186);
            this.markt.Name = "markt";
            this.markt.Size = new System.Drawing.Size(158, 20);
            this.markt.TabIndex = 1;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(267, 253);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(166, 253);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter The Mark";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // markview
            // 
            this.markview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markview.Location = new System.Drawing.Point(470, 62);
            this.markview.Name = "markview";
            this.markview.Size = new System.Drawing.Size(496, 304);
            this.markview.TabIndex = 3;
            this.markview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.markview_CellContentClick);
            this.markview.SelectionChanged += new System.EventHandler(this.markview_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mark list";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exambox
            // 
            this.exambox.FormattingEnabled = true;
            this.exambox.Location = new System.Drawing.Point(264, 151);
            this.exambox.Name = "exambox";
            this.exambox.Size = new System.Drawing.Size(158, 21);
            this.exambox.TabIndex = 5;
            // 
            // namebox
            // 
            this.namebox.FormattingEnabled = true;
            this.namebox.Location = new System.Drawing.Point(267, 110);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(158, 21);
            this.namebox.TabIndex = 5;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(903, 520);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(121, 40);
            this.back.TabIndex = 6;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 647);
            this.Controls.Add(this.back);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.exambox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.markview);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.markt);
            this.Controls.Add(this.markL);
            this.Controls.Add(this.examidL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sthudentidL);
            this.Name = "MarkForm";
            this.Text = "Enter The MarkForm";
            this.Load += new System.EventHandler(this.MarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sthudentidL;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label examidL;
        private System.Windows.Forms.Label markL;
        private System.Windows.Forms.TextBox markt;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView markview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox exambox;
        private System.Windows.Forms.ComboBox namebox;
        private System.Windows.Forms.Button back;
    }
}