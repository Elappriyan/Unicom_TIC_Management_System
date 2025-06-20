using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Moddel;


namespace unicomtlc.Moddel
{
    internal class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string role { get; set; }

        public Users() { }

        public Users(int userID, string userName, string userPassword, string role)
        {
            UserID = userID;
            UserName = userName;
            UserPassword = userPassword;
            this.role = role;
        }
    }
}
