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
            
            
            /*
            if (!courses.Contains(course))
            {
                courses.Add(course);
            }*/
            
        }
    }
}
