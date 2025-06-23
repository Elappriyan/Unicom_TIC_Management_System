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
        public int MarkID { get; set; }
        public int StudentID { get; set; }  // FK
        public int ExamID { get; set; }     // FK

        public double Score { get; set; }
        public string StudentName { get; set; }
        public string ExamName { get; set; }
    }
}

