using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Data;
using unicomtlc.Moddel;
using unicomtlc.Model;

namespace unicomtlc.Controllers
{
    public class StaffController
    {


        //  Add Staff
        public bool AddStaff(Staffs staffs)
        {
            using (var con = DB.GetConnection())
            {
                string query = "INSERT INTO Staff (FullName, Email, PhoneNumber) VALUES (@FullName, @Email, @PhoneNumber)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", staffs.FullName);
                    cmd.Parameters.AddWithValue("@Email", staffs.Email); 
                    cmd.Parameters.AddWithValue("@PhoneNumber", staffs.PhoneNumber);

                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Add Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Update Staff
        public static bool UpdateStaff(int staffId, string fullName, string email, string phoneNumber)
        {
            using (var con = DB.GetConnection())
            {

                string query = "UPDATE Staff SET FullName = @FullName, Email = @Email, PhoneNumber = @PhoneNumber WHERE StaffID = @StaffID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);

                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Update Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public List<Staffs> GetStaffView()
        {
            List<Staffs> staffList = new List<Staffs>();
            string getStaffQuery = "SELECT * FROM Staff";

            try
            {
                using (var con = DB.GetConnection())
                {
                    
                    using (SQLiteCommand getCommand = new SQLiteCommand(getStaffQuery, con))
                    using (var reader = getCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Staffs staff = new Staffs
                            {
                                StaffID = reader.GetInt32(reader.GetOrdinal("StaffID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                
                               
                            };

                            staffList.Add(staff);
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return staffList;
        }
        public bool DeleteStaff(int id)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Staff WHERE StaffID = @id";
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine($"Database error: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return false;
                }
            }
        }

       
        
       
        
    }
}
