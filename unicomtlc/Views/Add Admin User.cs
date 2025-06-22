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
    public partial class Add_Admin_User : Form
    {
        readonly UsersController usersController = new UsersController();
        int selectedUserId = -1;
        private readonly Form _previousForm;


        public Add_Admin_User(Adminview adminview)
        {
            InitializeComponent();
            _previousForm = adminview;
            UsersController usersController = new UsersController();
            LoadRoles();
            LoadUsers();



        }
        private void LoadUsers()
        {
            Addview.DataSource = usersController.GetAllUsers();
        }

        public void ClearForm()
        {
            name.Clear();
            password.Clear();
            roleM.SelectedIndex = -1;
            selectedUserId = -1;
        }
        public void LoadRoles()
        {
                roleM.Items.Clear();
                roleM.Items.Add("Admin");
                roleM.Items.Add("Student");
                roleM.Items.Add("Lecturer");
                roleM.Items.Add("Staff");
                roleM.SelectedIndex = 0; 
        }
        private void Button5_Click(object sender, EventArgs e)
        {
           

            ClearForm();
            LoadUsers();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            usersController.DeleteUser(selectedUserId);
            MessageBox.Show("User deleted.");
            LoadUsers();
            ClearForm();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            Users user = new Users
            {
                UserID = selectedUserId,
                UserName = name.Text,
                Password = password.Text,
                Role = roleM.SelectedItem.ToString()
            };

            usersController.UpdateUser(user);
            MessageBox.Show("User updated.");
            LoadUsers();
            ClearForm();

           
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(password.Text) ||
                 roleM.SelectedItem == null)
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

           
            Users user = new Users
            {
                UserName = name.Text,
                Password = password.Text,
                Role = roleM.SelectedItem.ToString()
            };

            
            usersController.Adduser(user);

            MessageBox.Show("User added successfully.");
            LoadUsers();
            ClearForm();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide(); 
*/
        }

        private void Add_Admin_User_Load(object sender, EventArgs e)
        {

        }

        private void Addview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (Addview.SelectedRows.Count > 0)
            {
                var row = Addview.SelectedRows[0];
                selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
                name.Text = row.Cells["UserName"].Value.ToString();`
                password.Text = row.Cells["Password"].Value.ToString();
               roleM.SelectedItem = row.Cells["Role"].Value.ToString();
            }*/
        }

        private void RoleM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addview_SelectionChanged(object sender, EventArgs e)
        {
            if (Addview.SelectedRows.Count > 0)
            {
                var row = Addview.SelectedRows[0];

                selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
                name.Text = row.Cells["UserName"].Value.ToString();
                password.Text = row.Cells["Password"].Value.ToString();
                roleM.SelectedItem = row.Cells["Role"].Value.ToString();
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();             
            _previousForm?.Show();
        }
    }
}
