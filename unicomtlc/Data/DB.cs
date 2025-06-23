using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicomtlc.Data
{


    internal static class DB
    {
        private static string ConnectionString = "Data Source=unicomtlcDB.db;Version=3;BusyTimeout=5000;";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = null;
            try
            {
                conn = new SQLiteConnection(ConnectionString);
                conn.Open();
            }
            catch (SQLiteException ex)
            {
                
                Console.WriteLine($"SQLite error: {ex.Message}");
               
                throw; 
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"General error: {ex.Message}");
                throw; 
            }
            return conn;
        }
    }

}
