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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace unicomtlc.Views
{
    
    public partial class AdminDetails : Form
    {
        private readonly string _username;
        private readonly string _role;
        private readonly Form _previousForm;
        public AdminDetails(string username, string role, Form previousForm)
        {
            InitializeComponent();
            _username = username;
            _role = role;
            _previousForm = previousForm;
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
            _previousForm?.Show(); // Go back to the previous form
            this.Close();
        }

        private void adminName_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
