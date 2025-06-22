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
    public partial class Adminview : Form
    {
        private readonly Form _previousForm;
        private readonly string  loggedUser;
        private readonly string userRole;
        
        
       

        public Adminview(string username, string role, Form previousForm)
        {
            InitializeComponent();
            loggedUser = username;
            userRole = role;
            _previousForm = previousForm;
        }

        public Adminview()
        {
            
            
        }

       

        /*
        public MainForm()
        {
        }

        public MainForm(CourseForm courseForm)
        {
            this.courseForm = courseForm;
        }*/

        private void Adminview_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome {loggedUser} ({userRole})!";
        }

        private void Course_subject_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm(this);
            this.Hide();
            courseForm.Show();

        }

        private void StudentM_Click(object sender, EventArgs e)
        {
            this.Hide();                         // hide Adminview
            Students students = new Students(loggedUser, this);// pass Adminview to Students form
            students.ShowDialog();
        }

        private void StaffM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Information staffInfoForm = new Staff_Information(this);
            staffInfoForm.Show();
        }

        private void Exam_marksM_Click(object sender, EventArgs e)
        {   
            this.Hide();
            ExamForm examForm = new ExamForm(this);
            examForm.ShowDialog();
                      
        }

        private void TimetableM_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimetableForm ttForm = new TimetableForm(this);
            ttForm.Show();
        }

        private void LecturerM_Click(object sender, EventArgs e)
        {

            this.Hide();
            LecturerDetails lecturerForm = new LecturerDetails(this);
            lecturerForm.Show();

        }

        private void AddM_Click(object sender, EventArgs e)
        {

            this.Hide();
            Add_Admin_User addUserForm = new Add_Admin_User(this);
            addUserForm.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome {loggedUser} ({userRole})!";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubjectForm subjectForm = new SubjectForm(this);
            subjectForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide Adminview
            MarkForm markForm = new MarkForm(this);  // Pass Adminview as previous form
            markForm.ShowDialog();
            this.Show();  // Show Adminv
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();


            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
    

