using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Data;
using unicomtlc.Moddel;
using System.Data.SQLite;
using System.Drawing;

namespace unicomtlc.Controllers
{
    internal class ExamController
    {


        public void AddExam(Exam exam)
        {
            using (var con = DB.GetConnection())
            {
                string addExamQuery = "INSERT INTO Exams(ExamName, ExamDate, SubjectId) VALUES(@name, @date, @subjectId)";
                using (var insertCmd = new SQLiteCommand(addExamQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@name", exam.ExamName);
                    insertCmd.Parameters.AddWithValue("@date", exam.ExamDate);
                    insertCmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }
        public List<Exam> GetAllExam()
        {
            var exams = new List<Exam>();

            using (var conn = DB.GetConnection())
            {
               string query = @"
                                SELECT e.ExamID, e.ExamName, e.SubjectId, e.ExamDate, s.SubjectName
                                FROM Exams e
                                LEFT JOIN Subject s ON e.SubjectId = s.SubjectID";


                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exam
                        {
                            ExamID = reader.GetInt32(0),
                            ExamName = reader.GetString(1),
                            SubjectID = reader.GetInt32(2),
                            ExamDate = reader.GetString(3),
                            SubjectName = !reader.IsDBNull(4) ? reader.GetString(4) : null
                        });
                    }
                }
            }

            return exams;
        }
        public void UpdateExam(Exam exam)
        {
            try
            {
                using (var conn = DB.GetConnection())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        UPDATE Exams 
                        SET ExamName = @ExamName, 
                            SubjectId = @SubjectId, 
                            ExamDate = @Date
                        WHERE ExamID = @Id";

                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@SubjectId", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@Date", exam.ExamDate);
                    cmd.Parameters.AddWithValue("@Id", exam.ExamID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    Console.WriteLine(rowsAffected > 0 ? "Exam updated successfully." : "No exam found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating exam: " + ex.Message);
            }
        }
        public void DeleteExam(int examId)
        {
            try
            {
                using (var conn = DB.GetConnection())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Exams WHERE ExamID = @Id";
                    cmd.Parameters.AddWithValue("@Id", examId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    Console.WriteLine(rowsAffected > 0 ? "Exam deleted successfully." : "No exam found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting exam: " + ex.Message);
            }
        }
    }
}






    
    