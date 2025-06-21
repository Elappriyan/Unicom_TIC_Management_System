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
       

        public Staffview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimetableForm  sf = new TimetableForm();
            sf.ShowDialog();
        }

        private void Staffview_Load(object sender, EventArgs e)
        {

        }

        private void mark_Click(object sender, EventArgs e)
        {
            MarkForm sf = new MarkForm();
            sf.ShowDialog();
        }

        private void room_Click(object sender, EventArgs e)
        {
            RoomForm sf = new RoomForm();
            sf.ShowDialog();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            Staff_Information staff_Information = new Staff_Information();
            staff_Information.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            this.Hide();
            form1.ShowDialog();


            this.Show();
        }
    }
}
