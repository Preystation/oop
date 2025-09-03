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
        public void RegisterForCourse(string course, double result)
        {
            if (result > 20)
            {
                Console.WriteLine("Ongeldige cijfer, cijfer mag niet hoger zijn dan 20.");
            }
            else
            {
                CourseResult cr = new CourseResult();
                cr.Name = course;
                cr.Result = result;
                coursesResult.Add(cr);


            }
        }
        public double Average()
        {
            double sum = 0;
            foreach (CourseResult cr in coursesResult)
            {
                sum = sum + cr.Result;
            }
            return sum / coursesResult.Count;
        }
        public void ShowOverview()
        {
            GenerateNameCard();
            Console.WriteLine($"Werkbelasting {DetermineWorkLoad()} uren");
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("*************");
            foreach (CourseResult cr in coursesResult)
            {
                Console.WriteLine($"{cr.Name} {cr.Result}");
            }
           
            Console.WriteLine($"Gemiddelde {Average():f02}");
            Console.WriteLine("");
        }
    }
}
