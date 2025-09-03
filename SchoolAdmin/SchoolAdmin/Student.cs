using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
     class Student
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public uint StudentNumber { get; set; }
        public  List<string> Courses = new List<string>();

        public uint StudentCounter = 1;
        public void GenerateNameCard()
        {
            Console.WriteLine($"{Name} (STUDENT)");
        }
        public double DetermineWorkLoad()
        {
            return Courses.Count * 10;
        }
    }
}
