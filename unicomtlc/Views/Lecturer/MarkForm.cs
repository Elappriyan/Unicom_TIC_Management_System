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
            LoadStudents();
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

            if (markview.Columns["StudentID"] != null)
                markview.Columns["StudentID"].Visible = false;

            if (markview.Columns["ExamID"] != null)
                markview.Columns["ExamID"].Visible = false;

            if (markview.Columns["MarkID"] != null)
                markview.Columns["MarkID"].Visible = true;  
        }
        private void ClearFields()
        {
            namebox.SelectedIndex = -1;
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
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this mark?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                controller.DeleteMark(selectedMarkId);
                MessageBox.Show("Mark deleted successfully!");

                LoadMarks();
                ClearFields();
            }
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            LoadMarks();

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (namebox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student.");
                return;
            }
            int studentId = (int)namebox.SelectedValue;

            
            if (exambox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an exam.");
                return;
            }
            int examId = (int)exambox.SelectedValue;

            
            if (!double.TryParse(markt.Text.Trim(), out double score))
            {
                MessageBox.Show("Please enter a valid score.");
                return;
            }

            
            var mark = new Mark
            {
                StudentID = studentId,
                ExamID = examId,
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
                
                string query = "SELECT Id FROM Students WHERE name = @name"; // 👈 Update this line
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    object result =cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }

        }

        private void markview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadStudents()
        {
            var students = new List<Student>();

            using (var con = DB.GetConnection())
            {
                string query = "SELECT Id, Name FROM Students";

                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        });
                    }
                }
            }

            namebox.DropDownStyle = ComboBoxStyle.DropDownList;
            namebox.DataSource = students;
            namebox.DisplayMember = "Name";
            namebox.ValueMember = "Id";
            namebox.SelectedIndex = -1;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            if (namebox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student.");
                return;
            }
            int studentId = (int)namebox.SelectedValue;

            if (exambox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an exam.");
                return;
            }
            int examId = (int)exambox.SelectedValue;

            if (!double.TryParse(markt.Text.Trim(), out double score))
            {
                MessageBox.Show("Please enter a valid score.");
                return;
            }

            var mark = new Mark
            {
                MarkID = selectedMarkId,
                StudentID = studentId,
                ExamID = examId,
                Score = score
            };

            controller.UpdateMark(mark);
            LoadMarks();
            ClearFields();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void markview_SelectionChanged(object sender, EventArgs e)
        {
            if (markview.SelectedRows.Count > 0)
            {
                var row = markview.SelectedRows[0];

                if (row.Cells["MarkID"].Value != null)
                {
                    selectedMarkId = Convert.ToInt32(row.Cells["MarkID"].Value);
                    namebox.SelectedValue = Convert.ToInt32(row.Cells["StudentID"].Value);
                    exambox.SelectedValue = Convert.ToInt32(row.Cells["ExamID"].Value);
                    markt.Text = row.Cells["Score"].Value.ToString();
                }
            }
            else
            {
                
                ClearFields();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Staffview form1 = new Staffview();
            this.Hide();
            form1.ShowDialog();


            this.Show();
        }
    }
}

