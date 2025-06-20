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

namespace unicomtlc.Views.admin
{
    public partial class CourseForm : Form
    {
        CourseController courseController;
        private int selectedCoruesid = -1;
        public CourseForm()
        {
            courseController = new CourseController();
            InitializeComponent();
           
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

        private void add_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Name = name.Text;

            courseController.AddCourse(course);
            MessageBox.Show("Course added successfully.");

            Loadcourse();
          
        }
        private void ClearForm()
        {
            name.Clear();
            
        }
        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void couresview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (selectedCoruesid == -1)
            {
                MessageBox.Show("Please select a course first.");
                return;
            }

            Course updatedCourse = new Course
            {
                ID = selectedCoruesid,
                Name = name.Text
            };

            courseController.UpdateCourse(updatedCourse);
            MessageBox.Show("Course updated successfully.");
            Loadcourse();
           
        }

        private void couresview_SelectionChanged(object sender, EventArgs e)
        {
            if (couresview.SelectedRows.Count > 0)
            {
                var row = couresview.SelectedRows[0];

                if (row.Cells["ID"].Value != null && row.Cells["Name"].Value != null)
                {
                    selectedCoruesid = Convert.ToInt32(row.Cells["ID"].Value);
                    name.Text = row.Cells["Name"].Value.ToString();
                }
            }
            else
            {
                selectedCoruesid = -1;
                ClearForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedCoruesid == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                courseController.DeleteCoures(selectedCoruesid);
                MessageBox.Show("Course deleted successfully.");
                Loadcourse();
                ClearForm();
                selectedCoruesid = -1;
            }
        }
    }
}
