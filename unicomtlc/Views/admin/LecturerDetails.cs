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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace unicomtlc.Views
{
    public partial class LecturerDetails : Form
    {
        private LecturerController controller = new LecturerController();
        private int selectedLecturerID = -1;
        public LecturerDetails()
        {
            InitializeComponent();
            controller = new LecturerController();
            LoadLecturers();
        }
        private void LoadLecturers()
        {
           lecturerview.DataSource = null;
            lecturerview.DataSource = controller.GetAllLecturers();
            if (lecturerview.Columns.Contains("CourseID"))
            {
                lecturerview.Columns["CourseID"].Visible = true;
            }


            lecturerview.ClearSelection();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void departmentT_Click(object sender, EventArgs e)
        {

        }

        private void LecturerDetails_Load(object sender, EventArgs e)
        {

        }
        private void ClearInputs()
        {
            name.Clear();
            gmail.Clear();
            phonenumber.Clear();
            department.Clear();
            selectedLecturerID = -1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                    string.IsNullOrWhiteSpace(gmail.Text) ||
                    string.IsNullOrWhiteSpace(phonenumber.Text) ||
                    string.IsNullOrWhiteSpace(departmentT.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create Lecturer object
            Lecturer lecturer = new Lecturer
            {
                FullName = name.Text.Trim(),
                Email = gmail.Text.Trim(),
                PhoneNumber = phonenumber.Text.Trim(),
                Department= department.Text.Trim(),
            };

            try
            {
                
                controller.Addlecturer(lecturer);

                MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLecturers(); 
                ClearInputs();   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save lecturer.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            lecturerview.ClearSelection();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (selectedLecturerID == -1)
            {
                MessageBox.Show("Please select a lecturer first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(gmail.Text) ||
                string.IsNullOrWhiteSpace(phonenumber.Text) ||
                string.IsNullOrWhiteSpace(department.Text)) 
            {
                MessageBox.Show("Please fill in all fields before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Lecturer updatedLecturer = new Lecturer
            {
                ID = selectedLecturerID,
                FullName = name.Text.Trim(),
                Email = gmail.Text.Trim(),
                PhoneNumber = phonenumber.Text.Trim(),
                Department = department.Text.Trim() // Make sure this is the right TextBox
            };

            try
            {
                controller.UpdateLecturer(updatedLecturer);
                MessageBox.Show("Lecturer updated successfully.");
                LoadLecturers();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update lecturer." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lecturerview_SelectionChanged(object sender, EventArgs e)
        {
            if (lecturerview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = lecturerview.SelectedRows[0];

                
                selectedLecturerID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                name.Text = selectedRow.Cells["FullName"].Value.ToString();
                gmail.Text = selectedRow.Cells["Email"].Value.ToString();
                phonenumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                department.Text = selectedRow.Cells["Department"].Value.ToString();
                
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedLecturerID == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                controller.DeleteLecturer(selectedLecturerID);
                MessageBox.Show("Course deleted successfully.");
                LoadLecturers();
                ClearInputs();
                selectedLecturerID = -1;
            }
        }
    }
}