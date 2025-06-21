using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unicomtlc.Data;
using unicomtlc.Views.admin;

namespace unicomtlc.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE UserName = @username AND Password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", name.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", userpassword.Text.Trim());

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["Role"].ToString();
                            string username = reader["UserName"].ToString();

                            this.Hide(); // Hide login form

                            if (role == "Admin")
                            {
                                Adminview adminForm = new Adminview(username, role, this);
                                adminForm.Show();
                                this.Hide();
                            }
                            else if (role == "Lecturer")
                            {
                                // Student dashboard
                                Lecturerview studentForm = new Lecturerview();
                                studentForm.Show();
                            }
                            else if (role == "Student")
                            {
                                StudentViewForm staffForm = new StudentViewForm();
                                staffForm.Show();
                            }
                            else if (role == "Staff")
                            {
                                this.Hide();  // hide LoginForm
                                Staffview staffForm = new Staffview();
                                staffForm.FormClosed += (s, args) => this.Close();  // Close LoginForm when Staffview is closed
                                staffForm.Show();








                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            
                        }
                    }

                }
            }
        }
    }
}
