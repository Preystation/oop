using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
  
   public class Student
    {

        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public uint StudentNumber { get; set; }
        private  List<string> Courses = new List<string>();

        public uint StudentCounter = 1;
        public void GenerateNameCard()
        {
            Console.WriteLine($"{Name} (STUDENT)");
        }
        public double DetermineWorkLoad()
        {
            return Courses.Count * 10;
        }
        public void RegisterForCourse(string course)
        {
            if (Courses.Contains(course))
            {
                Console.WriteLine("Student kan zich niet dubbel inschrijven voor een vak.");
            }
            else
            {
                Courses.Add(course);
            }
        }
    }

}
