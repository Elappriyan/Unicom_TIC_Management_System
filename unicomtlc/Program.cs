﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using unicomtlc.Data;
using unicomtlc.Moddel;
using unicomtlc.Password;
using unicomtlc.Views;
using unicomtlc.Views.admin;
using unicomtlc.Views.CourseMang;
using unicomtlc.Views.Staff;

namespace unicomtlc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PasswordHelper.UpdateUserPassword("Admin", "Admin123");
            Databasemange.creatTable();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Add_Admin_User ());
            // Application.Run(new StudentViewForm());
           
            Application.Run(new LoginForm());

        }
    }
}
