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

namespace unicomtlc.Views
{
    public partial class MarkForm : Form
    {
        private int selectedMarkId = -1;
        private MarkController controller = new MarkController();
        private readonly ExamController _Controller = new ExamController();
        public MarkForm()
        {
            InitializeComponent();
            LoadExamToComboBox();
        }
        private void LoadExamToComboBox()
        {
            var exams = _Controller.GetAllExam();

            exambox.DataSource = exams;
            exambox.DisplayMember = "ExamName";
            exambox.ValueMember = "ExamID";
            exambox.SelectedIndex = -1;
        }
        private void LoadMarks()
        {
            var marks = controller.GetAllMarks();
            markview.DataSource = marks;
        }
        private void ClearFields()
        {
            name.Clear();
            markt.Clear();
            exambox.SelectedIndex = -1;
            selectedMarkId = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void markL_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MarkForm_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string studentName = name.Text.Trim();
            double score;

            if (string.IsNullOrEmpty(studentName) || exambox.SelectedValue == null || !double.TryParse(markt.Text, out score))
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            int studentID = GetStudentIdByName(studentName);
            if (studentID == -1)
            {
                MessageBox.Show("Student not found.");
                return;
            }

            int examID = Convert.ToInt32(exambox.SelectedValue);

            var mark = new Mark
            {
                StudentID = studentID,
                ExamID = examID,
                Score = score
            };

            controller.AddMark(mark);
            LoadMarks();
            ClearFields();
        }
        private int GetStudentIdByName(string name)
        {
            using (var con = DB.GetConnection())
            {
                
                string query = "SELECT Id FROM Students WHERE Name = @name"; // 👈 Update this line
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                    object result =cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }



    }
}
