using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using unicomtlc.Controllers;
using unicomtlc.Moddel;
using unicomtlc;
using unicomtlc.Views;

namespace unicomtlc.Views.admin
{
    public partial class CourseForm : Form
    {
        private Form _previousForm;
        readonly CourseController courseController;
        private int selectedCoruesid = -1;
        public CourseForm(Form previousForm)
        {
            courseController = new CourseController();
            InitializeComponent();
            _previousForm = previousForm;
            Loadcourse();

        }
        private void Loadcourse()
        {
            couresview.DataSource = null;
            couresview.DataSource = courseController.GetAllCourses();
            if (couresview.Columns.Contains("CourseID"))
            {
                couresview.Columns["CourseID"].Visible = true;
            }

            
            couresview.ClearSelection();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = new Course
                {
                    CourseName = name.Text
                };

                courseController.AddCourse(course);
                MessageBox.Show("Course added successfully.");

                Loadcourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding course: {ex.Message}");
            }



        }
        private void ClearForm()
        {
            name.Clear();
            
        }
        

        private void Update_Click(object sender, EventArgs e)
        {
            if (selectedCoruesid == -1)
            {
                MessageBox.Show("Please select a course first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Course name cannot be empty.");
                return;
            }

            try
            {
                Course updatedCourse = new Course
                {
                    CourseID = selectedCoruesid,
                    CourseName = name.Text.Trim()
                };

                courseController.UpdateCourse(updatedCourse); 
                MessageBox.Show("Course added successfully.");

                Loadcourse();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Couresview_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (couresview.SelectedRows.Count > 0)
                {
                    var row = couresview.SelectedRows[0];

                    if (row.Cells["CourseID"].Value != null &&
                        int.TryParse(row.Cells["CourseID"].Value.ToString(), out int courseId))
                    {
                        selectedCoruesid = courseId;

                        object courseNameValue = row.Cells["CourseName"].Value;
                        name.Text = courseNameValue != null ? courseNameValue.ToString() : string.Empty;
                    }
                    else
                    {
                        selectedCoruesid = -1;
                        name.Clear();
                    }
                }
                else
                {
                    selectedCoruesid = -1;
                    name.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading selected course: {ex.Message}", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedCoruesid = -1;
                name.Clear();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (selectedCoruesid == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                   courseController.DeleteCoures(selectedCoruesid); // <- updated method returning string
                    MessageBox.Show("Course deleted successfully");

                    Loadcourse();
                    ClearForm();
                    selectedCoruesid = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Close();         
            _previousForm?.Show();
        }



        private void Button1_Click_1(object sender, EventArgs e){}
        private void Button1_Click_2(object sender, EventArgs e){}
        private void Name_TextChanged(object sender, EventArgs e){}
        private void Couresview_CellContentClick(object sender, DataGridViewCellEventArgs e){}        
    }
}
