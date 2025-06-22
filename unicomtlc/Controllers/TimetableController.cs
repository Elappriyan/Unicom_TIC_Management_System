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

            return lecturers;
        }

       
        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();

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

            return rooms;
        }
        public void AddTimeTable(TimeTable tt)
        {
            using (var conn = DB.GetConnection())
            {
               

                using (var cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO TimeTable (Lecturer, Subject, Day, Time, Room) VALUES (@Lecturer, @Subject, @Day, @Time, @Room)";
                    cmd.Parameters.AddWithValue("@Lecturer", tt.Lecturer);
                    cmd.Parameters.AddWithValue("@Subject", tt.Subject);
                    cmd.Parameters.AddWithValue("@Day", tt.Day);
                    cmd.Parameters.AddWithValue("@Time", tt.Time);
                    cmd.Parameters.AddWithValue("@Room", tt.Room);

                    cmd.ExecuteNonQuery(); // do not keep connection open unnecessarily
                }
            }
        }

        public List<TimeTable> GetAllTimeTables()
        {
            var list = new List<TimeTable>();

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

            return list;
        }

        public void UpdateTimeTable(TimeTable tt)
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

        public void DeleteTimeTable(int Id)
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
    }
}




