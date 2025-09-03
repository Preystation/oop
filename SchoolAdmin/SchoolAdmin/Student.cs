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
        private List<CourseResult> coursesResult = new List<CourseResult>();

        public static uint StudentCounter = 1;
        public void GenerateNameCard()
        {
            Console.WriteLine($"{Name} (STUDENT)");
        }
        public double DetermineWorkLoad()
        {
            return coursesResult.Count * 10;
        }
        public void RegisterForCourse(string course,double result)
        {
            if (result > 20)
            {
                Console.WriteLine("Ongeldige cijfer cijfer mag niet hoger zijn dan 20.");
            }
            else
            {
                CourseResult cr = new CourseResult();
                cr.Name = course;
                cr.Result = result;
                coursesResult.Add(cr);
                

            }
        }
    }

}
