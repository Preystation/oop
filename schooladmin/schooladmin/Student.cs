using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Student:Person
    {
      
        private List<CourseResistration> courseRegistrations = new List<CourseResistration>();
   
        public int Age
        {
            get
            {
                int difference = DateTime.Now.Year - Birthdate.Year;

                if (DateTime.Now.Year < Birthdate.Year)
                {
                    difference--;
                }
                return difference;
            }
        }
        private int age;
        private static List<Student> allStudenten = new List<Student>();
        public static ImmutableList<Student> allStudents
        {
            get { return allStudenten.ToImmutableList<Student>(); }
        }
        public Student(string name,DateTime birthdate):base(name,birthdate)
        {

            allStudenten.Add(this);
        }



        public override string GenerateNameCard()
        {
            return $"{Name} (STUDENT)";
        }
        public override double DetermineWorkLoad()
        {
            return (byte)(courseRegistrations.Count * 10);
        }
        public void RegisterCourseResult(Course course,byte? result)
        {

            if (result<20)
            {
                CourseResistration newCourseResult = new CourseResistration(course, result);
         
                courseRegistrations.Add(newCourseResult);
            }
           
            
        }
        public double Average()
        {
            int total = 0;
            double sum =0;
            foreach (CourseResistration cr in courseRegistrations)
            {
                if (cr.Result is not null)
                {
                    sum = (double)(sum + cr.Result);
                    total++;
                }
            }
            
            return sum / total;
        }
        public void ShowOverview()
        {
            string cijferrapport = "Cijferrraport";
            string lines = "";
            while (cijferrapport.Length != lines.Length){
                lines = lines + "*";
            }
            Console.WriteLine($"{GenerateNameCard()}({Age})");
            Console.WriteLine($"Werkbelasting {DetermineWorkLoad()}" +
                $"\n{cijferrapport}" +
                $"\n{lines}");
            foreach (CourseResistration cr in courseRegistrations)
            {
                Console.WriteLine($"{cr.Course}:\t{cr.Result}");
            }
            Console.WriteLine($"Gemiddelde:\t{Average():f2}");
            Console.WriteLine();
        }
      
    }
}
