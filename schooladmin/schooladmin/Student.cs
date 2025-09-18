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
        private List<CourseResult> coursesResults = new List<CourseResult>();
        public static uint StudentCounter = 1;

        public string GenerateNameCard()
        {
            return $"{Name} (student)";
        }
        public byte DetermineWorkload()
        {
            return (byte)(coursesResults.Count * 10);
        }
        public void RegisterCourseResult(string course,byte result)
        {
            if(result > 20)
            {
                Console.WriteLine("Ongeldige Cijfer");
            }
            CourseResult cr = new CourseResult();
            cr.Name = course;
            cr.Result = result;
            coursesResults.Add(cr);

        }
        public double Average()
        { double som = 0;
            foreach (CourseResult item in coursesResults)
            {
                som = som + item.Result;
            }
            return som;
        }
        public void ShowOverview()
        {
            Console.WriteLine($"{GenerateNameCard()}" +
                $"\nWerkbelasting:\t {DetermineWorkload()}" +
                $"\nCijferraport" +
                $"\n************");
            foreach (CourseResult item in coursesResults)
            {
                Console.WriteLine($"{item.Name}:\t{item.Result}");
            }

        }
    }
}
