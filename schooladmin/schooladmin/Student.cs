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
        private List<CourseRegistration> courseRegistrations = new List<CourseRegistration>();
        public static uint StudentCounter = 1;
        public int Age { 
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - Birthday.Year;
                return age;
            }
        
        }
        public Student(string name,DateTime birthDate)
        {
            this.Name = name;
            this.Birthday = birthDate;
            StudentNumber = StudentCounter + 1;
        }
        public string GenerateNameCard()
        {
            return $"{Name} ({Age} jaar)";
        }
        public byte DetermineWorkload()
        {
            return (byte)(courseRegistrations.Count * 10);
        }
        public void RegisterCourseResult(string course,byte? result)
        {
            if(result > 20)
            {
                Console.WriteLine("Ongeldige Cijfer");
            }
            else
            {
                CourseRegistration cr = new CourseRegistration(course, result);
                courseRegistrations.Add(cr);
            }

        }
        public double Average()
        { double sum = 0;
            int total = 0;
            foreach (CourseRegistration item in courseRegistrations)
            {
                if(item.Result is not null)
                {
                    sum = sum + (byte)item.Result;
                    total = total + 10;
                }
            }
            return total;
        }
        public void ShowOverview()
        {
            string message = "Cijferraport".Trim();
            string line = "";
            while (message.Length!= line.Length)
            {
                line = line + "*";
            }
           
            Console.WriteLine($"" +
                $"{GenerateNameCard()}" +
                $"\nWerkbelasting:\t{DetermineWorkload()}" +
                $"\n{message}" +
                $"\n{line}");
            
            foreach (CourseRegistration item in courseRegistrations)
            {
                Console.WriteLine($"{item.Name}:\t{item.Result}");
            }
             Console.WriteLine("");
        }
    }
}
