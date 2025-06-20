using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Moddel;


namespace unicomtlc.Moddel
{
    internal class Exam
    {
        public int ExamID { get; set; }

        public string ExamName { get; set; }
        public string ExamDate { get; set; }
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
    }
}
