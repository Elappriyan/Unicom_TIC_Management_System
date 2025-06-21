using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using unicomtlc.Data;
using unicomtlc.Moddel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace unicomtlc.Controllers
{
    internal class UsersController
    {
        public void Adduser(Users users)
        {
            using (var conn = DB.GetConnection())
            {
               
                string query = "INSERT INTO Users (UserName, Password, Role) VALUES (@u, @p, @r)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", users.UserName);
                    cmd.Parameters.AddWithValue("@p", users.Password);
                    cmd.Parameters.AddWithValue("@r", users.Role);
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = DB.GetConnection())
                {
                    
                    string query = "SELECT * FROM Users";
                    using (var da = new SQLiteDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch
            {
                
            }

            return dt;
        }
        public void UpdateUser(Users user)
        {
            using (var conn = DB.GetConnection())
            {
                
                string query = "UPDATE Users SET UserName=@u, Password=@p, Role=@r WHERE UserID=@id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", user.UserName);
                    cmd.Parameters.AddWithValue("@p", user.Password);
                    cmd.Parameters.AddWithValue("@r", user.Role);
                    cmd.Parameters.AddWithValue("@id", user.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteUser(int userId)
        {
            using (var conn = DB.GetConnection())
            {
                
                string query = "DELETE FROM Users WHERE UserID=@id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
