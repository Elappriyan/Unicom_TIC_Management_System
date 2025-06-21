using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using unicomtlc.Controllers;
using unicomtlc.Moddel;

namespace unicomtlc.Views
{
    public partial class Students : Form
    {
        private StudentController _controller = new StudentController();
        private CourseController _courseController = new CourseController();
        private int selectedStudentid = -1;

        public Students(string username)
        {
            InitializeComponent();
            LoadCourses();
            LoadStudents();
        }

        public Students()
        {
        }

        private void LoadCourses()
        {
            courseid.DropDownStyle = ComboBoxStyle.DropDownList;

            CourseController courseController = new CourseController();
            List<Course> courses = courseController.GetAllCourses();

            courseid.DataSource = null;
            courseid.DataSource = courses;
            courseid.DisplayMember = "CourseName";
            courseid.ValueMember = "CourseID"; 
            courseid.SelectedIndex = -1;
        }


        private void LoadStudents()
        {
            Studentview.DataSource = StudentController.GetAllStudents();
            Studentview.ClearSelection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (courseid.SelectedValue == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            int courseId = Convert.ToInt32(courseid.SelectedValue);

            var student = new Student
            {
                Name = name.Text,
                Address = address.Text,
                Age = age.Text,
                CourseID = courseId
            };

            if (_controller.AddStudent(student))
            {
                ClearInputs();
                MessageBox.Show("Student added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add student.");
            }
            LoadStudents();
        }

        private void ClearInputs()
        {
            name.Text = "";
            address.Text = "";
            age.Text = "";
            courseid.SelectedIndex = -1;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (Studentview.CurrentRow == null) return;

            var selectedStudent = (Student)Studentview.CurrentRow.DataBoundItem;

            if (courseid.SelectedValue == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            int courseId = Convert.ToInt32(courseid.SelectedValue);

            selectedStudent.Name = name.Text;
            selectedStudent.Address = address.Text;
            selectedStudent.Age = age.Text;
            selectedStudent.CourseID = courseId;

            StudentController.UpdateStudent(selectedStudent);
            LoadStudents();
            MessageBox.Show("Student updated successfully!");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedStudentid == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                StudentController.DeleteStaff(selectedStudentid);
                MessageBox.Show("Student deleted successfully.");
                LoadStudents();
                ClearInputs();
                selectedStudentid = -1;
            }
        }

        private void Studentview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Studentview_SelectionChanged(object sender, EventArgs e)
        {
            if (Studentview.CurrentRow?.DataBoundItem is Student selectedStudent)
            {
                selectedStudentid = selectedStudent.Id;
                name.Text = selectedStudent.Name;
                address.Text = selectedStudent.Address;
                age.Text = selectedStudent.Age;
                courseid.SelectedValue = selectedStudent.CourseID;
            }
        }

        private void courseid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseid.SelectedItem is Course selectedCourse)
            {
                Console.WriteLine("Selected Course ID: " + selectedCourse.CourseID);
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }
    }
}
