using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unicomtlc.Controllers;
using unicomtlc.Moddel;
using unicomtlc.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace unicomtlc.Views
{
    public partial class Staff_Information : Form
    {
        private StaffController staffController;
        private int selectedStaffID = -1;
        public Staff_Information()
        {
            InitializeComponent();
            staffController = new StaffController();
            LoadStaff();
        }
        private void LoadStaff()
        {
            var staffList = staffController.GetStaffView();
            staffview.DataSource = null;
            staffview.DataSource = staffList;
            staffview.ClearSelection();

            selectedStaffID = -1;
            ClearForm();
        }
        private void ClearForm()
        {
            fullname.Clear();
            emailT.Clear();
            phonenumber.Clear();
            selectedStaffID = -1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff_Information_Load(object sender, EventArgs e)
        {

        }

        private void staffview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = staffview.Rows[e.RowIndex];
                selectedStaffID = Convert.ToInt32(row.Cells["StaffID"].Value);
                fullname.Text = row.Cells["FullName"].Value.ToString();
                emailT.Text = row.Cells["Email"].Value.ToString();
                phonenumber.Text = row.Cells["PhoneNumber"].Value.ToString();
               
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearForm();
            staffview.ClearSelection();
            selectedStaffID = -1;
        }
       
        private void save_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(fullname.Text) ||
          string.IsNullOrWhiteSpace(email.Text) ||
          string.IsNullOrWhiteSpace(phone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create Staff object
            Staffs staff = new Staffs
            {
                FullName = fullname.Text.Trim(),
                Email = emailT.Text.Trim(),
                PhoneNumber = phonenumber.Text.Trim()
            };

            // Call AddStaff
            bool success = staffController.AddStaff(staff);

            if (success)
            {
                MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff(); // Reload data into DataGridView if you have one
                ClearInputs(); // Optional: Clear form fields
            }
            else
            {
                MessageBox.Show("Failed to save staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void ClearInputs()
        {
            fullname.Clear();
            emailT.Clear();
            phonenumber.Clear();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedStaffID == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                StudentController.DeleteStaff(selectedStaffID);
                MessageBox.Show("Student deleted successfully.");
                LoadStaff();
                ClearInputs();
                selectedStaffID = -1;
            }
        }


        private void xbtn_Click(object sender, EventArgs e)
        {
            Staffview form1 = new Staffview();
            this.Hide();
            form1.ShowDialog();


            this.Show();

        }
    }
}

