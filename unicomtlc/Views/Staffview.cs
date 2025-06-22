using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unicomtlc.Views.Staff;


namespace unicomtlc.Views
{
    public partial class Staffview : Form
    {
        private Staff_Information _staffInfoForm;


        public Staffview()
        {
            InitializeComponent();
            _staffInfoForm = new Staff_Information();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimetableForm ttForm = new TimetableForm(this);
            ttForm.Show();
        }

        private void Staffview_Load(object sender, EventArgs e)
        {

        }

        private void mark_Click(object sender, EventArgs e)
        {

            this.Hide();
            MarkForm ma = new MarkForm(this);
            ma.Show();
        }

        private void room_Click(object sender, EventArgs e)
        {
            RoomForm sf = new RoomForm();
            sf.ShowDialog();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            DataTable staffData = _staffInfoForm.GetStaffTable();
            staview.DataSource = staffData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            this.Hide();
            form1.ShowDialog();


            //this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm ex = new ExamForm(this);
            ex.ShowDialog();
        }
    }
}
