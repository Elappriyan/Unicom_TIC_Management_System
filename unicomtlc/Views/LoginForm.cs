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

                            this.Hide(); // Hide login form once for all roles

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
                                lecturerForm.FormClosed += (s, args) => this.Close(); // Close LoginForm after Lecturerview is closed
                                lecturerForm.Show();
                            }
                            else if (role == "Student")
                            {
                                // Optionally preload student data here if needed
                                Students studentsForm = new Students(username, this); // pass actual username
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
                                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
               }    }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
