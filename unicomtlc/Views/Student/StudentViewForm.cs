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
using unicomtlc.Views;

namespace unicomtlc.Views.admin
{
    public partial class StudentViewForm : Form
    {

        private Students _studentsForm;
        private TimetableForm _timetableForm;
        private TimetableController _timetableController = new TimetableController();
        private MarkController _markControlle = new MarkController();
        private readonly ExamController _examController = new ExamController();

        public StudentViewForm(Students studentsForm )
        {
            InitializeComponent();
            _studentsForm = studentsForm;
            
            stuview.DataSource = _studentsForm.GetStudentTable(); 
        }
        public StudentViewForm(TimetableForm timetableForm)
        {
            InitializeComponent();
            _timetableForm = timetableForm;

            var controller = new TimetableController();
            var list = controller.GetAllTimeTables();
            DataTable dt = ConvertToDataTable(list);

            stuview.DataSource = dt;
        }
        public StudentViewForm(DataTable markData)
        {
            InitializeComponent();
            stuview.DataSource = markData;
        }
        
        public StudentViewForm(DataTable data, string type)
        {
            InitializeComponent();

            if (type == "mark")
            {
                stuview.DataSource = data;
                // Optionally format mark columns
            }
            else if (type == "exam")
            {
                stuview.DataSource = data;
                // Optionally format exam columns
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (_studentsForm != null)
            {
                stuview.DataSource = _studentsForm.GetStudentTable();
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentViewForm_Load(object sender, EventArgs e)
        {

        }


        private void Button2_Click(object sender, EventArgs e)
        {
           var timeTables = _timetableController.GetAllTimeTables();
            stuview.DataSource = ConvertToDataTable(timeTables);
        }
        private DataTable ConvertToDataTable(List<TimeTable> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Lecturer", typeof(string));
            dt.Columns.Add("Subject", typeof(string));
            dt.Columns.Add("Day", typeof(string));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Room", typeof(string));

            foreach (var item in list)
            {
                dt.Rows.Add(item.Id, item.Lecturer, item.Subject, item.Day, item.Time, item.Room);
            }

            return dt;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var marks = _markControlle.GetAllMarks();
            DataTable dt = ConvertToDataTable(marks);
            stuview.DataSource = dt;
        }
        private DataTable ConvertToDataTable(List<Mark> marks)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MarkID", typeof(int));
            dt.Columns.Add("StudentID", typeof(int));   // This should be an int
            dt.Columns.Add("StudentName", typeof(string)); // This is string
            dt.Columns.Add("ExamID", typeof(int));      // int
            dt.Columns.Add("ExamName", typeof(string));   // string
            dt.Columns.Add("Score", typeof(double));

            foreach (var mark in marks)
            {
                dt.Rows.Add(
                    mark.MarkID,
                    mark.StudentID,    // must be int (e.g. 101)
                    mark.StudentName,  // string (e.g. "elappriyan")
                    mark.ExamID,
                    mark.ExamName,
                    mark.Score
                );
            }

            return dt;
        }
        private DataTable ConvertToDataTable(List<Exam> exams)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ExamID", typeof(int));
            dt.Columns.Add("ExamName", typeof(string));
            dt.Columns.Add("ExamDate", typeof(string));
            dt.Columns.Add("SubjectID", typeof(int));
            dt.Columns.Add("SubjectName", typeof(string)); // optional

            foreach (var exam in exams)
            {
                dt.Rows.Add(exam.ExamID, exam.ExamName, exam.ExamDate, exam.SubjectID, exam.SubjectName);
            }

            return dt;
        }
        private void LoadMarks()
        {
            var markList = _markControlle.GetAllMarks();
            var dt = ConvertToDataTable(markList);
            stuview.DataSource = dt;

            // Show StudentID column
            if (stuview.Columns["StudentID"] != null)
            {
                stuview.Columns["StudentID"].Visible = true;
                stuview.Columns["StudentID"].Visible = false;
            }

            // Similarly, control other columns visibility as needed
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            
                var exams = _examController.GetAllExam(); // List<Exam>
                DataTable dt = ConvertToDataTable(exams);
                stuview.DataSource = dt;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
    
}
