using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Data;
using unicomtlc.Moddel;

namespace unicomtlc.Controllers
{
    internal class AdminControllers
    {
        public static string AdminViews { get; set; }
        public string AddAdmin(AdminDetail admin)
        {
            using (var con = DB.GetConnection())
            {
                string addAdminQuery = "INSERT INTO Admin(AdminName, PhoneNumber) VALUES(@name, @phone_no)";
                SQLiteCommand insertCmd = new SQLiteCommand(addAdminQuery, con);
                insertCmd.Parameters.AddWithValue("@name", admin.adminName);
                insertCmd.Parameters.AddWithValue("@phone_no", admin.adminPNumber);
                insertCmd.ExecuteNonQuery();
            }
            return "Admin registration successful.";
        }

        public static List<AdminDetail> GetAdminview()
        {
            List<AdminDetail> admins = new List<AdminDetail>();
            string getAdminQuery = "SELECT * FROM Admin";

            using (var con = DB.GetConnection())
            {


                using (SQLiteCommand getCommand = new SQLiteCommand(getAdminQuery, con))
                using (var reader = getCommand.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        AdminDetail admin = new AdminDetail
                        {
                            
                            adminID = !reader.IsDBNull(0) ? Convert.ToInt32(reader.GetValue(0)) : 0,

                            
                            adminName = !reader.IsDBNull(1) ? reader.GetString(1) : null,

                            
                            adminPNumber = !reader.IsDBNull(2) ? reader.GetString(2) : null
                        };

                        admins.Add(admin);
                    }


                }
                return admins;

            }
        }

        public void UpdateAdmin(AdminDetail admin)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open(); 
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Admin SET Name = @name, PhoneNumber = @phonenumber WHERE Id = @id"; 
                cmd.Parameters.AddWithValue("@name", admin.adminName);
                cmd.Parameters.AddWithValue("@phonenumber", admin.adminPNumber);
                cmd.Parameters.AddWithValue("@id", admin.adminID);

                try
                {
                    cmd.ExecuteNonQuery(); 
                }
                catch (SQLiteException ex)
                {
                   
                    Console.WriteLine($"Database error: {ex.Message}");
                    
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine($"An error occurred: {ex.Message}");
                   
                }
            }
        }

        public void DeleteAdmin(int id)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open(); 
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Admins WHERE Id = @id"; 
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {

                    Console.WriteLine($"Database error: {ex.Message}");

                }
                catch (Exception ex)
                {

                    Console.WriteLine($"An error occurred: {ex.Message}");

                }
            }
        }

    }
}
    




