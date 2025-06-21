using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Moddel;


namespace unicomtlc.Moddel
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        [Browsable(false)] public int CourseID { get; set; }
        public string CourseName { get; set; }


    }
}
