using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Data;
using unicomtlc.Moddel;

namespace unicomtlc.Controllers
{
    internal class StudentController
    {
        // Add 
        public  bool AddStudent(Student student)
        {
            using (var con = DB.GetConnection())
            {
                
                string query = "INSERT INTO Students (Name, Address ,Age, CourseID) VALUES (@Name,@Address,@Age, @CourseID)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@Age", student.Age);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseID);

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

        //  Students view
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (var con = DB.GetConnection())
            {
            
                string query = @"
            SELECT s.Id, s.Name, s.Address, s.Age, s.CourseID, c.CourseName
            FROM Students s
            INNER JOIN Course c ON s.CourseID = c.CourseID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Age = reader.GetString(3),
                            CourseID = reader.GetInt32(4),
                            CourseName = reader.GetString(5)

                        });
                    }
                }
            }
            return students;
        }

        // Update 
        public static bool UpdateStudent(Student student)
        {
            using (var con = DB.GetConnection())
            {
                string query = "UPDATE Students SET Name = @Name, Address = @Address, Age = @Age, CourseID = @CourseID WHERE Id = @Id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@Age", student.Age);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseID);
                    cmd.Parameters.AddWithValue("@Id", student.Id);

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

        // Delete 
        public static bool DeleteStaff(int id)
        {
            using (var con = DB.GetConnection())
            {
                string query = "DELETE FROM Students WHERE Id = @Id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Delete Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Get Student ID
        public static Student GetStudentById(int id)
        {
            using (var con = DB.GetConnection())
            {
                string query = "SELECT * FROM Students WHERE Id = @Id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                Age = reader.GetString(reader.GetOrdinal("Age")),
                                CourseID = reader.GetInt32(reader.GetOrdinal("CourseID"))
                               
                            };
                        }
                    }
                }
            }

            return null; 
        }
    }
}
