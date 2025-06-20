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
        
        public SubjectForm()
        {
           controller = new subjectController();
            InitializeComponent();
            courseController = new CourseController();
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
            couresbox.DisplayMember = "Name"; 
            couresbox.ValueMember = "ID";
            //couresbox.selectedIndex = -1;
        }
        private void add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(name.Text) || couresbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var subject = new Subject
            {
                Name = name.Text.Trim(),
                Coursename = couresbox.SelectedValue?.ToString()
            };

            controller.AddSubject(subject);
            LoadSubjects();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (SubjectView.CurrentRow?.DataBoundItem is Subject selectedSubject)

            {
                var confirm = MessageBox.Show("Are you sure you want to delete this subject?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    controller.DeleteSubject(selectedSubject.ID);
                    LoadSubjects(); 
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
    }
    
}
