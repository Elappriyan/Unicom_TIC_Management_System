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
    internal class CourseController
    {
        public void AddCourse(Course course)
        {
            using (var con = DB.GetConnection())
            {
                var command  = new SQLiteCommand ("INSERT INTO Course(CourseName) VALUES(@name)", con);
                command.Parameters.AddWithValue("@name", course.Name);
                command.ExecuteNonQuery ();
                


            }
        }

        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            string getCourseQuery = "SELECT * FROM Course";

            try
            {
                using (var con = DB.GetConnection())
                {
                   
                    using (SQLiteCommand getCommand = new SQLiteCommand(getCourseQuery, con))
                    using (var reader = getCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Course course1 = new Course(); 
                            course1.ID = reader.GetInt32(0);
                            course1.Name = reader.GetString(1);
                            courses.Add(course1);
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

            return courses; 
        }
        public void UpdateCourse(Course course)
        {
            using (var conn = DB.GetConnection())
            {
             
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Course SET CourseName = @CourseName WHERE CourseID = @id";
                cmd.Parameters.AddWithValue("@CourseName", course.Name);
                cmd.Parameters.AddWithValue("@id", course.ID);
                cmd.ExecuteNonQuery(); 
            }
        }

        public void DeleteCoures(int id)
        {
            using (var conn = DB.GetConnection())
            {
               
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Course WHERE CourseID = @id";
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

