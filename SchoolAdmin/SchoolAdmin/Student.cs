using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Student
    {
        public string Name;
        public DateTime Birthdate;
        public int StudentNumber;
        private List<string> courses = new List<string>();
        public static int StudentCounter = 1;


        public string GenerateNameCard()
        {
            return $"{Name} (STUDENT)";
        }

        public byte DetermineWorkLoad()
        {
            return (byte)(courses.Count()*10);
        }

        public void RegisterForCourse(string course)
        {
            foreach(string item in courses)
            {
                if(item == course)
                {
                    Console.WriteLine($"{Name} is al ingeschreven voor deze cursus.");
                }
                else
                {
                    courses.Add(course);
                }
            }
        }
    }
}
