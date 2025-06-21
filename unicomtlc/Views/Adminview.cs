using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unicomtlc.Views.admin;
using unicomtlc.Views.CourseMang;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace unicomtlc.Views
{
    public partial class MainForm : Form
    {
        private string loggedUser;
        private string userRole;

        public MainForm(string username, string role)
        {
            InitializeComponent();
            loggedUser = username;
            userRole = role;
        }

        public MainForm()
        {
        }

        private void Adminview_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome {loggedUser} ({userRole})!";
        }

        private void course_subject_Click(object sender, EventArgs e)
        {
            
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();

            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog();
        }

        private void studentM_Click(object sender, EventArgs e)
        {
            
            Students students = new Students(); 
            students.ShowDialog();
        }

        private void staffM_Click(object sender, EventArgs e)
        {
            
            Staff_Information  staff_Information = new Staff_Information();
            staff_Information.ShowDialog();
        }

        private void exam_marksM_Click(object sender, EventArgs e)
        {
            
            ExamForm examForm = new ExamForm();
            examForm.ShowDialog();


            MarkForm markForm = new MarkForm(); 
            markForm.ShowDialog();
        }

        private void timetableM_Click(object sender, EventArgs e)
        {
            
            TimetableForm timetableForm = new TimetableForm();
            timetableForm.ShowDialog();
        }

        private void lecturerM_Click(object sender, EventArgs e)
        {
            
            LecturerDetails lecturerDetails = new LecturerDetails();
            lecturerDetails.ShowDialog();
        }

        private void addM_Click(object sender, EventArgs e)
        {
           
            Add_Admin_User add_Admin_User = new Add_Admin_User();
            add_Admin_User.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    

