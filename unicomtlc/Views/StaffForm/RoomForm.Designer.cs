namespace unicomtlc.Views.Staff
{
    partial class RoomForm
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
            this.roomname = new System.Windows.Forms.TextBox();
            this.roomtype = new System.Windows.Forms.ComboBox();
            this.clear = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.roomview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.roomview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Management";
            // 
            // roomname
            // 
            this.roomname.Location = new System.Drawing.Point(196, 107);
            this.roomname.Name = "roomname";
            this.roomname.Size = new System.Drawing.Size(181, 20);
            this.roomname.TabIndex = 1;
            // 
            // roomtype
            // 
            this.roomtype.FormattingEnabled = true;
            this.roomtype.Location = new System.Drawing.Point(196, 147);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(181, 21);
            this.roomtype.TabIndex = 2;
            this.roomtype.SelectedIndexChanged += new System.EventHandler(this.roomtype_SelectedIndexChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(429, 102);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 28);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(121, 150);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(65, 13);
            this.type.TabIndex = 0;
            this.type.Text = "Room Type:";
            this.type.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(121, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(69, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Room Name:";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(429, 150);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 28);
            this.delete.TabIndex = 3;
            this.delete.Text = "Detele";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(429, 196);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 28);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(302, 196);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 28);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // roomview
            // 
            this.roomview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomview.Location = new System.Drawing.Point(111, 230);
            this.roomview.Name = "roomview";
            this.roomview.Size = new System.Drawing.Size(393, 208);
            this.roomview.TabIndex = 4;
            this.roomview.SelectionChanged += new System.EventHandler(this.roomview_SelectionChanged);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomview);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.roomname);
            this.Controls.Add(this.type);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "RoomForm";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomname;
        private System.Windows.Forms.ComboBox roomtype;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView roomview;
    }
}