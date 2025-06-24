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
    internal class MarkController
    {
        //============================================Exam combobox Gat==============================================
        public List<Exam> GetAllExam()
        {
            var exams = new List<Exam>();

            try
            {
                using (var con = DB.GetConnection())
                {
                    string query = "SELECT ExamID, ExamName FROM Exams";

                    using (var cmd = new SQLiteCommand(query, con))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            exams.Add(new Exam
                            {
                                ExamID = Convert.ToInt32(reader["ExamID"]),
                                ExamName = reader["ExamName"]?.ToString() ?? string.Empty
                            });
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"Database error fetching exams: {ex.Message}");
                // Optionally handle or rethrow the exception
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error fetching exams: {ex.Message}");
                // Optionally handle or rethrow the exception
            }

            return exams;

        }
        //================================= Add=================================================================

        public void AddMark(Mark mark)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    string query = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@StudentID, @ExamID, @Score)";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                        cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
                        cmd.Parameters.AddWithValue("@Score", mark.Score);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error inserting mark: {ex.Message}");
                // Handle or rethrow as needed
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error inserting mark: {ex.Message}");
                // Handle or rethrow as needed
            }

        }
        public void UpdateMark(Mark mark)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    string query = "UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE MarkID = @Id";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                        cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
                        cmd.Parameters.AddWithValue("@Score", mark.Score);
                        cmd.Parameters.AddWithValue("@Id", mark.MarkID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No mark record found with the specified ID.");
                            // Optionally handle this case, e.g., notify user or throw
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error updating mark: {ex.Message}");
                // Optionally handle or rethrow the exception
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error updating mark: {ex.Message}");
                // Optionally handle or rethrow the exception
            }

        }
        public void DeleteMark(int MarkID)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    string query = "DELETE FROM Marks WHERE MarkID = @Id";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", MarkID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No mark record found with the specified ID.");
                            // Optionally notify user or handle this case
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.Error.WriteLine($"SQLite error deleting mark: {ex.Message}");
                // Optionally handle or rethrow
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error deleting mark: {ex.Message}");
                // Optionally handle or rethrow
            }

        }
        public List<Mark> GetAllMarks()
        {
            var marks = new List<Mark>();

            using (var con = DB.GetConnection())
            {
                string query = @"
                               SELECT 
                m.MarkID, 
                m.StudentID, 
                s.Name AS StudentName, 
                m.ExamID, 
                e.ExamName, 
                m.Score
            FROM Marks m
            JOIN Students s ON m.StudentID = s.Id
            JOIN Exams e ON m.ExamID = e.ExamID"
                            ;

                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marks.Add(new Mark
                        {
                            MarkID = Convert.ToInt32(reader["MarkID"]),
                            StudentID = Convert.ToInt32(reader["StudentID"]),       
                            StudentName = reader["StudentName"].ToString(),
                            ExamID = Convert.ToInt32(reader["ExamID"]),             
                            ExamName = reader["ExamName"].ToString(),
                            Score = Convert.ToDouble(reader["Score"])
                        });
                    }
                }
            }

            return marks;
        }

        internal object GetAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
