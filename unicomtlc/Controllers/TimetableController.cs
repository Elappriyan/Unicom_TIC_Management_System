using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Data;
using unicomtlc.Moddel;
using unicomtlc.Views.admin;

namespace unicomtlc.Controllers
{
    internal class TimetableController
    {

        public List<Lecturer> GetAllLecturers()
        {
            var lecturers = new List<Lecturer>();

            try
            {
                using (var conn = DB.GetConnection())
                {
                    string query = "SELECT * FROM Lecturers";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lecturers.Add(new Lecturer
                            {
                                ID = reader.GetInt32(0),
                                FullName = reader.GetString(1),
                                Email = reader.GetString(2),
                                PhoneNumber = reader.GetString(3),
                                Department = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error loading lecturers: {ex.Message}");
                // Optionally: handle or rethrow
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error loading lecturers: {ex.Message}");
                // Optionally: handle or rethrow
            }

            return lecturers;
        }

       
        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();

            try
            {
                using (var conn = DB.GetConnection())
                {
                    string query = "SELECT SubjectID, SubjectName FROM Subject";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error loading subjects: {ex.Message}");
                
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error loading subjects: {ex.Message}");
               
            }

            return subjects;
        }
        public DataTable GetLecturersAsDataTable()
        {
            var lecturers = GetAllLecturers();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("FullName");
            dt.Columns.Add("Email");
            dt.Columns.Add("PhoneNumber");
            dt.Columns.Add("Department");

            foreach (var l in lecturers)
            {
                dt.Rows.Add(l.ID, l.FullName, l.Email, l.PhoneNumber, l.Department);
            }

            return dt;
        }
        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();

            try
            {
                using (var conn = DB.GetConnection())
                {
                    string query = "SELECT RoomID, RoomName FROM Rooms";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Room
                            {
                                RoomID = reader.GetInt32(0),
                                RoomName = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error loading rooms: {ex.Message}");
                // Optionally handle or rethrow
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error loading rooms: {ex.Message}");
                // Optionally handle or rethrow
            }

            return rooms;
        }
        public void AddTimeTable(TimeTable tt)
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    using (var cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;  // Set connection explicitly
                        cmd.CommandText = "INSERT INTO TimeTable (Lecturer, Subject, Day, Time, Room) VALUES (@Lecturer, @Subject, @Day, @Time, @Room)";
                        cmd.Parameters.AddWithValue("@Lecturer", tt.Lecturer);
                        cmd.Parameters.AddWithValue("@Subject", tt.Subject);
                        cmd.Parameters.AddWithValue("@Day", tt.Day);
                        cmd.Parameters.AddWithValue("@Time", tt.Time);
                        cmd.Parameters.AddWithValue("@Room", tt.Room);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error inserting timetable: {ex.Message}");
              
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error inserting timetable: {ex.Message}");
                
            }

        }

        public List<TimeTable> GetAllTimeTables()
        {
            var list = new List<TimeTable>();

            try
            {
                using (var conn = DB.GetConnection())
                {
                    string query = "SELECT Id, Lecturer, Subject, Day, Time, Room FROM TimeTable";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TimeTable
                            {
                                Id = reader.GetInt32(0),
                                Lecturer = reader.GetString(1),
                                Subject = reader.GetString(2),
                                Day = reader.GetString(3),
                                Time = reader.GetString(4),
                                Room = reader.GetString(5),
                            });
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error retrieving timetable: {ex.Message}");
                // Optionally handle or rethrow
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error retrieving timetable: {ex.Message}");
                // Optionally handle or rethrow
            }

            return list;
        }

        public void UpdateTimeTable(TimeTable tt)
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    string query = @"UPDATE TimeTable 
                         SET Lecturer = @lecturer, Subject = @subject, Day = @day, Time = @time, Room = @room
                         WHERE Id = @id";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@lecturer", tt.Lecturer);
                        cmd.Parameters.AddWithValue("@subject", tt.Subject);
                        cmd.Parameters.AddWithValue("@day", tt.Day);
                        cmd.Parameters.AddWithValue("@time", tt.Time);
                        cmd.Parameters.AddWithValue("@room", tt.Room);
                        cmd.Parameters.AddWithValue("@id", tt.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error updating timetable: {ex.Message}");
                // Optionally rethrow or handle further
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error updating timetable: {ex.Message}");
            }
        }

        public void DeleteTimeTable(int Id)
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    string query = "DELETE FROM TimeTable WHERE Id = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error deleting timetable entry: {ex.Message}");
                // Handle or rethrow as needed
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error deleting timetable entry: {ex.Message}");
            }
        }
    }
}




