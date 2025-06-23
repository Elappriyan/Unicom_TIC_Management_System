using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using unicomtlc.Data;
using unicomtlc.Moddel;

namespace unicomtlc.Controllers
{
    internal class subjectController
    {
        public void AddSubject(Subject subject)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    string insertQuery = "INSERT INTO Subject (SubjectName, Courseid) VALUES (@SubjectName, @CourseID)";
                    using (var cmd = new SQLiteCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@SubjectName", subject.Name);
                        cmd.Parameters.AddWithValue("@CourseID", subject.Coursename); 
                        cmd.ExecuteNonQuery();
                    }

                    string courseName = GetCourseNameById(subject.Coursename, con);

                    if (!string.IsNullOrEmpty(courseName))
                    {
                        Console.WriteLine("Subject added to course: " + courseName);
                    }
                    else
                    {
                        Console.WriteLine("Course not found for ID: " + subject.Coursename);
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error adding subject: {ex.Message}");
                
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error adding subject: {ex.Message}");
               
            }





        }



        private string GetCourseNameById(string courseId, SQLiteConnection con)
        {
            string courseName = null;
            string query = "SELECT CourseName FROM Course WHERE CourseID = @CourseID";

            

            try
            {
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CourseID", courseId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            courseName = reader["CourseName"]?.ToString();
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error fetching course name: {ex.Message}");
                
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error fetching course name: {ex.Message}");
                
            }

            return courseName;

        }
        public List<Subject> GetAllSubjectsWithCourseName()
        {
            List<Subject> subjects = new List<Subject>();

            try
            {
                using (var con = DB.GetConnection())
                {
                    string query = @"
            SELECT s.SubjectID, s.SubjectName, c.CourseName 
            FROM Subject s
            JOIN Course c ON s.CourseID = c.CourseID";

                    using (var cmd = new SQLiteCommand(query, con))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject
                            {
                                ID = Convert.ToInt32(reader["SubjectID"]),
                                Name = reader["SubjectName"]?.ToString(),
                                Coursename = reader["CourseName"]?.ToString()
                            });
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"Database error fetching subjects: {ex.Message}");
                
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error fetching subjects: {ex.Message}");
                
            }

            return subjects;

        }

        public void DeleteSubject(int subjectId)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    string deleteQuery = "DELETE FROM Subject WHERE SubjectID = @SubjectID";
                    using (var cmd = new SQLiteCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No subject found with the specified ID.");
                            
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error deleting subject: {ex.Message}");
                
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error deleting subject: {ex.Message}");
                
            }

        }

    }

}   

