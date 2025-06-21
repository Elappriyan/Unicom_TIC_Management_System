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
            Staff_Information  staff_Information = new Staff_Information();
            staff_Information.ShowDialog();
        }

        private void Exam_marksM_Click(object sender, EventArgs e)
        {   
            this.Hide();
            ExamForm examForm = new ExamForm(this);
            examForm.ShowDialog();
                      
        }

        private void TimetableM_Click(object sender, EventArgs e)
        {
            
            TimetableForm timetableForm = new TimetableForm();
            timetableForm.ShowDialog();
        }

        private void LecturerM_Click(object sender, EventArgs e)
        {
            
            LecturerDetails lecturerDetails = new LecturerDetails();
            lecturerDetails.ShowDialog();
        }

        private void AddM_Click(object sender, EventArgs e)
        {
           
            Add_Admin_User add_Admin_User = new Add_Admin_User();
            add_Admin_User.ShowDialog();
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
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide Adminview
            MarkForm markForm = new MarkForm(this);  // pass current form as previousForm
            markForm.ShowDialog();
            this.Show();
        }
    }
}
    

