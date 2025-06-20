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

        

        private string GetCourseNameById(string courseId, SQLiteConnection con)
        {
            string courseName = null;
            string query = "SELECT CourseName FROM Course WHERE CourseID = @CourseID";

            using (var cmd = new SQLiteCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@CourseID", courseId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        courseName = reader["CourseName"].ToString();
                    }
                }
            }

            return courseName;
        }
        public List<Subject> GetAllSubjectsWithCourseName()
        {
            List<Subject> subjects = new List<Subject>();

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
                            Name = reader["SubjectName"].ToString(),
                            Coursename = reader["CourseName"].ToString()
                        });
                    }
                }
            }

            return subjects;
        }

        public void DeleteSubject(int subjectId)
        {
            using (var con = DB.GetConnection())
            {
                

                string deleteQuery = "DELETE FROM Subject WHERE SubjectID = @SubjectID";
                using (var cmd = new SQLiteCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

}   

