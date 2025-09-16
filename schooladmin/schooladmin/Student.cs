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
        private List<string> courses = new List<string>();
        public static uint StudentCounter = 1;

        public string GenerateNameCard()
        {
            return $"{Name} (student)";
        }
        public byte DetermineWorkload()
        {
            return (byte)(courses.Count * 10);
        }
        public void RegisterForCourse(string course)
        {
            if (!courses.Contains(course))
            {
                courses.Add(course);
            }
            
        }
    }
}
