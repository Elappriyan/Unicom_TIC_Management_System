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
            try
            {
                if (selectedUserId == -1)
                {
                    MessageBox.Show("Please select a user to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    usersController.DeleteUser(selectedUserId);
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId == -1)
                {
                    MessageBox.Show("Please select a user to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(name.Text) ||
                    string.IsNullOrWhiteSpace(password.Text) ||
                    roleM.SelectedItem == null)
                {
                    MessageBox.Show("Please enter all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password.Text.Trim());

                Users user = new Users
                {
                    UserID = selectedUserId,
                    UserName = name.Text.Trim(),
                    Password = hashedPassword,
                    Role = roleM.SelectedItem.ToString()
                };

                usersController.UpdateUser(user);
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(name.Text))
                throw new ArgumentException("Name cannot be empty.");

            if (string.IsNullOrWhiteSpace(password.Text))
                throw new ArgumentException("Password cannot be empty.");

            if (roleM.SelectedItem == null)
                throw new ArgumentException("Please select a role.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password.Text.Trim());

                Users user = new Users
                {
                    UserName = name.Text.Trim(),
                    Password = hashedPassword,
                    Role = roleM.SelectedItem.ToString()
                };

                usersController.Adduser(user);

                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ClearForm();
            }
            catch (ArgumentException ex)
            {
                // Validation error message shown here
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        private void ShowError(string message, Exception ex = null)
        {
            var fullMessage = message;
            if (ex != null)
            {
                fullMessage += "\nDetails: " + ex.Message;
            }
            MessageBox.Show(fullMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                if (Addview.SelectedRows.Count > 0)
                {
                    var row = Addview.SelectedRows[0];

                    if (row.Cells["UserID"].Value == null || !int.TryParse(row.Cells["UserID"].Value.ToString(), out selectedUserId))
                    {
                        selectedUserId = -1;
                        ClearForm();
                        return;
                    }

                    name.Text = row.Cells["UserName"].Value?.ToString() ?? "";
                    password.Clear(); // never show hashed password
                    roleM.SelectedItem = row.Cells["Role"].Value?.ToString() ?? null;
                }
            }
            catch (Exception ex)
            {
                ShowError("Error loading selected user", ex);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();             
            _previousForm?.Show();
        }
    }
}
