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
        //private LecturerDetails lecturerForm;
        public Lecturerview()
        {
            InitializeComponent();


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

        private void Button4_Click(object sender, EventArgs e)
        {

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
