using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unicomtlc.Controllers;
using unicomtlc.Data;
using unicomtlc.Moddel;
using static System.Collections.Specialized.BitVector32;

namespace unicomtlc.Views.CourseMang
{ 
    public partial class SubjectForm : Form
    {
        subjectController controller;
        private CourseController courseController;
        private readonly Form _previousForm;
        public SubjectForm(Adminview adminview)
        {
           controller = new subjectController();
            InitializeComponent();
            courseController = new CourseController();

            _previousForm = adminview;
            LoadSubjects();
        }
        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadnewCourses(); 
        }

        private void LoadSubjects()
        {
            SubjectView.DataSource = null;
            SubjectView.DataSource = controller.GetAllSubjectsWithCourseName();
        }
        private void LoadnewCourses()
        {
            couresbox.DropDownStyle = ComboBoxStyle.DropDownList;

            CourseController courseController = new CourseController();
            couresbox.DataSource = courseController.GetAllCourses(); 
            couresbox.DisplayMember = "CourseName"; 
            couresbox.ValueMember = "CourseID";
            
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || couresbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var subject = new Subject
            {
                Name = name.Text.Trim(),
                Coursename = couresbox.SelectedValue?.ToString()
            };

            try
            {
                controller.AddSubject(subject);
                MessageBox.Show("Subject added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add subject.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (SubjectView.CurrentRow != null)
            {
                
                var cellValue = SubjectView.CurrentRow.Cells["ID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int subjectId))
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this subject?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        controller.DeleteSubject(subjectId);
                        LoadSubjects();
                    }
                }
                else
                {
                    MessageBox.Show("Could not find valid subject ID.");
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to delete.");
            }
        }

        private void SubjectView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();  
            _previousForm?.Show();
        }

        private void SubjectView_SelectionChanged(object sender, EventArgs e)
        {
            if (SubjectView.SelectedRows.Count > 0)
            {
                var selectedRow = SubjectView.SelectedRows[0];

                string subjectName = "";
                object courseIdValue = null;

                if (SubjectView.Columns.Contains("Name"))
                    subjectName = selectedRow.Cells["Name"].Value?.ToString() ?? "";

            
                if (SubjectView.Columns.Contains("CourseID"))
                    courseIdValue = selectedRow.Cells["CourseID"].Value;
                else if (SubjectView.Columns.Contains("Coursename"))
                    courseIdValue = selectedRow.Cells["Coursename"].Value;
                else if (SubjectView.Columns.Contains("CourseName"))
                    courseIdValue = selectedRow.Cells["CourseName"].Value;

                // Update controls
                name.Text = subjectName;

                if (courseIdValue != null && int.TryParse(courseIdValue.ToString(), out int courseId))
                {
                    couresbox.SelectedValue = courseId;
                }
                else
                {
                    couresbox.SelectedIndex = -1;
                }
            }
            else
            {
                name.Clear();
                couresbox.SelectedIndex = -1;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            name.Clear();             
            couresbox.SelectedIndex = -1;
        }
    }
    
}
