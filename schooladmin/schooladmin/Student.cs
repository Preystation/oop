using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schooladmin
{
    internal class Student
    {
        public string Name;
        public DateTime Birthday;
        public uint StudentNumber;
        public List<string> Courses = new List<string>();
        public static uint StudentCounter = 1;
    }
}
