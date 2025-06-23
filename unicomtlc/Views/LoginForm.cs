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
using unicomtlc.Controllers;
using unicomtlc.Data;
using unicomtlc.Moddel;
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
            // Initial state: password hidden
            userpassword.UseSystemPasswordChar = true;
            picEye.Image = Properties.Resources.Eye;
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    string query = "SELECT * FROM Users WHERE UserName = @username";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", name.Text.Trim());

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader["Password"].ToString();
                                string inputPassword = userpassword.Text.Trim();


                                Console.WriteLine($"Hashed DB pwd: {hashedPassword}");
                                Console.WriteLine($"Input pwd: {inputPassword}");


                                // ✅ Check if password in DB looks like a BCrypt hash
                                if (!hashedPassword.StartsWith("$2a$") &&
                                    !hashedPassword.StartsWith("$2b$") &&
                                    !hashedPassword.StartsWith("$2y$"))
                                {
                                    MessageBox.Show("Login failed: Password is not securely hashed. Please contact admin.", "Security Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // ✅ Verify bcrypt password
                                if (BCrypt.Net.BCrypt.Verify(inputPassword, hashedPassword))
                                {
                                    string role = reader["Role"].ToString();
                                    string username = reader["UserName"].ToString();

                                    this.Hide();

                                    if (role == "Admin")
                                    {
                                        Adminview adminForm = new Adminview(username, role, this);
                                        adminForm.FormClosed += (s, args) => this.Close();
                                        adminForm.Show();
                                    }
                                    else if (role == "Lecturer")
                                    {
                                        TimetableController controller = new TimetableController();
                                        DataTable dt = controller.GetLecturersAsDataTable();

                                        Lecturerview lecturerForm = new Lecturerview(dt);
                                        lecturerForm.FormClosed += (s, args) => this.Close();
                                        lecturerForm.Show();
                                    }
                                    else if (role == "Student")
                                    {
                                        Students studentsForm = new Students(username, this);
                                        StudentViewForm viewForm = new StudentViewForm(studentsForm);
                                        viewForm.FormClosed += (s, args) => this.Close();
                                        viewForm.Show();
                                    }
                                    else if (role == "Staff")
                                    {
                                        Staffview staffForm = new Staffview();
                                        staffForm.FormClosed += (s, args) => this.Close();
                                        staffForm.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unknown role: " + role, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        this.Show();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            userpassword.UseSystemPasswordChar = !userpassword.UseSystemPasswordChar;
            picEye.Image = userpassword.UseSystemPasswordChar
                ? Properties.Resources.Eye
                : Properties.Resources.Eye;
        }
    }
}
