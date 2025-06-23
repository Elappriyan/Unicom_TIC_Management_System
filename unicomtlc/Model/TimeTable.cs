using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicomtlc.Moddel;


namespace unicomtlc.Moddel
{
    internal class TimeTable
    {
        
         public int Id { get; set; } 
        public string Lecturer { get; set; }
        public string Subject { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Room { get; set; }
        public int RoomId { get; set; } //fk
        public int ID { get; set; } // fk
    }
}
