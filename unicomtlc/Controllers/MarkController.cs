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
                            ExamName = reader["ExamName"].ToString()
                        });
                    }
                }
            }

            return exams;
        }
        //================================= Add=================================================================

        public void AddMark(Mark mark)
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
        public void UpdateMark(Mark mark)
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
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteMark(int MarkID)
        {
            using (var con = DB.GetConnection())
            {

                string query = "DELETE FROM Marks WHERE MarkID = @Id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", MarkID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Mark> GetAllMarks()
        {
            var marks = new List<Mark>();

            using (var con = DB.GetConnection())
            {
                string query = @"
            SELECT m.MarkID, m.StudentID, s.Name AS StudentName, e.ExamID, e.ExamName, m.Score
            FROM Marks m
            JOIN Students s ON m.StudentID = s.Id
            JOIN Exams e ON m.ExamID = e.ExamID
        ";

                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marks.Add(new Mark
                        {
                            MarkID = Convert.ToInt32(reader["MarkID"]),
                            StudentID = Convert.ToInt32(reader["StudentID"]),       // changed from "Id" to "StudentID"
                            StudentName = reader["StudentName"].ToString(),
                            ExamID = Convert.ToInt32(reader["ExamID"]),             // Added ExamID to query, now accessible
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
