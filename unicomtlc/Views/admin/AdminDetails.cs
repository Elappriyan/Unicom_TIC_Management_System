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

namespace unicomtlc.Views
{
    public partial class AdminDetails : Form
    {
        public AdminDetails()
        {
            InitializeComponent();
            LoadStudent();
        }


        private void LoadStudent()
        {
            List<AdminDetail> admins = AdminControllers.GetAdminview();
            Adminviews.DataSource = admins;

        }








        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = adminName.Text.Trim();
            string phone = adminPNumber.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter both Name and Phone Number.");
                return;
            }

         
            AdminDetail admin1 = new AdminDetail
            {
                adminName = name,
                adminPNumber = phone
            };

            AdminControllers controller = new AdminControllers();
            string result = controller.AddAdmin(admin1);

            if (result == "Success")
            {
                MessageBox.Show("Admin Added Successfully");
                adminName.Clear();
                adminPNumber.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add admin: " + result);
            }

            LoadStudent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminform form = new Adminform();
            form.ShowDialog();
        }

        private void adminName_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
