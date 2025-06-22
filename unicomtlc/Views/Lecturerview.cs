using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unicomtlc.Views
{
    public partial class Lecturerview : Form
    {
        private DataTable lecturerData;
        public Lecturerview(DataTable data)
        {
            InitializeComponent();
            lecturerData = data;
            this.Load += Lecturerview_Load;
        }
        private void Lecturerview_Load(object sender, EventArgs e)
        {
            lecrviwe.DataSource = lecturerData;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TimetableForm timetable = new TimetableForm(this); // Pass this
            this.Hide();
            timetable.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkForm ma = new MarkForm(this);           
            ma.Show();


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ExamForm ex = new ExamForm(this); // Pass this
            this.Hide();
            ex.Show();
           
        }
        public DataTable GetAllLecturers()
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in lecrviwe.Columns)
            {
                dt.Columns.Add(column.Name);
            }

            foreach (DataGridViewRow row in lecrviwe.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dr = dt.NewRow();
                    foreach (DataGridViewColumn column in lecrviwe.Columns)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value ?? DBNull.Value;
                    }
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            DataTable dt = GetAllLecturers();
            Lecturerview newForm = new Lecturerview(dt);
            newForm.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            this.Hide();
            form1.ShowDialog();


           // this.Show();
        }

        private void Lecrviwe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
