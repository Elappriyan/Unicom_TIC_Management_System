using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Data;

namespace unicomtlc.Password
{
    internal class PasswordHelper
    {
        public static void UpdateUserPassword(string username, string plainPassword)
        {
            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword);

                using (var conn = DB.GetConnection())
                {
                    using (var cmd = new SQLiteCommand("UPDATE Users SET Password = @password WHERE UserName = @username", conn))
                    {
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine($"✅ Password updated successfully for user '{username}'.");
                        else
                            Console.WriteLine($"⚠️ User '{username}' not found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error updating password: " + ex.Message);
            }
        }
      
    }
}
    
