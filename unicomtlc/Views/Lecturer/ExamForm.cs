using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using unicomtlc.Controllers;
using unicomtlc.Model;
using unicomtlc.Moddel;

namespace unicomtlc.Views
{
    public partial class ExamForm : Form
    {
        private readonly Form _previousForm;
        private readonly ExamController _examController = new ExamController();
        private readonly subjectController _subjectController = new subjectController();
        private int selectedExamId = -1;
        public ExamForm(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
            examview.SelectionChanged += Examview_SelectionChanged;
            LoadSubjectsToComboBox();
            LoadExams();
            
        }

        

        private void LoadSubjectsToComboBox()
        {
            var subjects = _subjectController.GetAllSubjectsWithCourseName();
            subjectbox.DataSource = subjects;
            subjectbox.DisplayMember = "Name";
            subjectbox.ValueMember = "ID";
            subjectbox.SelectedIndex = -1;
        }
        private void LoadExams()
        {
            examview.DataSource = null;
            examview.DataSource = _examController.GetAllExam();

            
            examview.Columns["ExamID"].Visible = true;
            examview.Columns["SubjectID"].Visible = false;

            
            examview.Columns["ExamName"].HeaderText = "Exam Name";
            examview.Columns["ExamDate"].HeaderText = "Exam Date";
            examview.Columns["SubjectName"].HeaderText = "Subject";

            examview.ClearSelection();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Examdate_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nexam.Text) || subjectbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var exam = new Exam
            {
                ExamName = nexam.Text.Trim(),
                ExamDate = DateTime.Parse(date.Text).ToString("yyyy-MM-dd"),

                SubjectID = Convert.ToInt32(subjectbox.SelectedValue)
            };

            _examController.AddExam(exam);
            LoadExams();
            ClearFields();
            MessageBox.Show("Exam added successfully!");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Select an exam to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nexam.Text) || subjectbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var exam = new Exam
            {
                ExamID = selectedExamId,
                ExamName = nexam.Text.Trim(),
                ExamDate = DateTime.Parse(date.Text).ToString("yyyy-MM-dd"),

                SubjectID = Convert.ToInt32(subjectbox.SelectedValue)
            };

            _examController.UpdateExam(exam);
            LoadExams();
            ClearFields();
            MessageBox.Show("Exam updated successfully!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Select an exam to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this exam?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _examController.DeleteExam(selectedExamId);
                LoadExams();
                ClearFields();
                MessageBox.Show("Exam deleted.");
            }
        }
        private void ClearFields()
        {
            selectedExamId = -1;
            nexam.Clear();
            date.Value = DateTime.Today;

            subjectbox.SelectedIndex = -1;
            examview.ClearSelection();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(value: $"Selected date: {date.Value.ToString("yyyy-MM-dd")}");
        }

        private void Examview_SelectionChanged(object sender, EventArgs e)
        {
            if (examview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = examview.SelectedRows[0];

                // Make sure all required columns exist before accessing
                if (selectedRow.Cells["ExamID"].Value != null)
                {
                    selectedExamId = Convert.ToInt32(selectedRow.Cells["ExamID"].Value);
                    nexam.Text = selectedRow.Cells["ExamName"].Value.ToString();
                    date.Value = DateTime.Parse(selectedRow.Cells["ExamDate"].Value.ToString());

                    // Handle subject selection by ID
                    int subjectId = Convert.ToInt32(selectedRow.Cells["SubjectID"].Value);
                    subjectbox.SelectedValue = subjectId;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*Lecturerview form1 = new Lecturerview();
            form1.Show();

            // Close or hide Form2
            this.Close();  // orForm1 form1 = new Form1();
            form1.Show();*/


            this.Close();
            _previousForm?.Show();


        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
