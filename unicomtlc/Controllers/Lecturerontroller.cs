using System;
using System.Collections.Generic;
using System.Data.SQLite;
using unicomtlc.Data;
using unicomtlc.Moddel;

namespace unicomtlc.Controllers
{
    internal class LecturerController
    {
        public void Addlecturer(Lecturer lecturer)
        {
            using (var con = DB.GetConnection())
            {
                string addLecturerQuery = "INSERT INTO Lecturers (FullName, Email, PhoneNumber, Department) VALUES (@FullName, @Email, @PhoneNumber, @Department)";
                SQLiteCommand insertCmd = new SQLiteCommand(addLecturerQuery, con);
                insertCmd.Parameters.AddWithValue("@FullName", lecturer.FullName);
                insertCmd.Parameters.AddWithValue("@Email", lecturer.Email);
                insertCmd.Parameters.AddWithValue("@PhoneNumber", lecturer.PhoneNumber);
                insertCmd.Parameters.AddWithValue("@Department", lecturer.Department);
                insertCmd.ExecuteNonQuery();
            }

        }

        public List<Lecturer> GetAllLecturers()
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            string query = "SELECT * FROM Lecturers";

            using (var con = DB.GetConnection())
            {
                

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lecturer lecturer = new Lecturer
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Department = reader["Department"].ToString()
                        };

                        lecturers.Add(lecturer);
                    }
                }
                return lecturers;
            }

        }
        public bool UpdateLecturer(Lecturer lecturer)
        {
            using (var con = DB.GetConnection())
            {
                

                string query = "UPDATE Lecturers SET FullName=@FullName, Email=@Email, PhoneNumber=@PhoneNumber, Department=@Department WHERE ID=@ID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", lecturer.FullName);
                    cmd.Parameters.AddWithValue("@Email", lecturer.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", lecturer.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Department", lecturer.Department);
                    cmd.Parameters.AddWithValue("@ID", lecturer.ID);

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
        public bool DeleteLecturer(int lecturerID)
        {
            using (var con = DB.GetConnection())
            {
                

                string query = "DELETE FROM Lecturers WHERE ID = @ID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", lecturerID);

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

    }

}