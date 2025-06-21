using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using unicomtlc.Moddel;

namespace unicomtlc.Data
{
    internal class Databasemange
    {
        public static void creatTable()
        {
            string creatTableQuery = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserName TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL 
                );

                CREATE TABLE IF NOT EXISTS Course (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL UNIQUE
                );

                CREATE TABLE IF NOT EXISTS Subject (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL,
                    CourseID INTEGER NOT NULL,
                    FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
                );

                CREATE TABLE IF NOT EXISTS Students (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    Age TEXT NOT NULL,
                    CourseID INTEGER NOT NULL,
                    FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
                );

                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT NOT NULL,
                    ExamDate TEXT NOT NULL,
                    SubjectID INTEGER NOT NULL,
                    FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID)
                );

                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER NOT NULL,
                    ExamID INTEGER NOT NULL,
                    Score INTEGER NOT NULL,
                    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
                );

                CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT NOT NULL UNIQUE,
                    RoomType TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Timetable (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Lecturer TEXT NOT NULL,
                    Subject TEXT NOT NULL,
                    Day TEXT NOT NULL,
                    Time TEXT NOT NULL,
                    Room TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Admin (
                    AdminID INTEGER PRIMARY KEY AUTOINCREMENT,
                    AdminName TEXT NOT NULL,
                    PhoneNumber TEXT NOT NULL
                );
               CREATE TABLE IF NOT EXISTS Lecturers (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    Department TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    PhoneNumber TEXT NOT NULL
                );
       
               CREATE TABLE  IF NOT EXISTS Staff  (
                    StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    Email TEXT NOT NULL UNIQUE,
                    PhoneNumber TEXT NOT NULL
                    
                );
            ";

            using (var con = DB.GetConnection())
            {
               
                SQLiteCommand cmd = new SQLiteCommand(creatTableQuery, con);
                cmd.ExecuteNonQuery();
                
            }
        }
    }
}
