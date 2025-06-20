using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Moddel;


namespace unicomtlc.Moddel
{
    internal class Mark
    {
        public int Id { get; set; }
        public int StudentID { get; set; }  // Add this
        public int ExamID { get; set; }     // Add this

        public double Score { get; set; }
        public string StudentName { get; set; }
        public string ExamName { get; set; }
    }
}

