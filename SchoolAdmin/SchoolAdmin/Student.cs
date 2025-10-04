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
        private List<CourseResult> courseResult = new List<CourseResult>();
        public static int StudentCounter = 1;
        public int Age { get 
            {
                TimeSpan difference = DateTime.Now - Birthdate;
                int years = (int)(difference.Days / 365);
                return years;
            } 
        }
        public Student(string name,DateTime birthDate)
        {
            this.Name = name;
            this.Birthdate = birthDate;
            StudentCounter++;
        }



        public string GenerateNameCard()
        {
            return $"{Name} (STUDENT)";
        }

        public byte DetermineWorkLoad()
        {
            return (byte)(courseResult.Count()*10);
        }

        public void RegisterCourseResult(string course,byte result )
        {

            if (result > 20 && result <0)
            {
                Console.WriteLine("Ongeldige cijfer");
            }


            else
            {
                CourseResult cr = new CourseResult(course, result);
                
            }

                    
                
            }
        public double Average()
        {
            double sum = 0;
            foreach (CourseResult cr in courseResult)
            {
                sum = sum + cr.Result;
            }
            return sum / courseResult.Count;
        }



        public void ShowOverview()
        {
            string cijferrapport = "Cijferrapport";
            string lines = "";
            while (lines .Length!= cijferrapport.Length)
            {
                lines = lines + "*";
            }

            Console.WriteLine($"{Name} {Age}" +
                $"\nWerkbelasting\t{Average()}" +
                $"\n{cijferrapport}" +
                $"\n{lines}");

            foreach (CourseResult cr in courseResult)
            {
                Console.WriteLine($"{cr.Name}:\t{cr.Result}");
            }
            Console.WriteLine();
        }

        }
    }

