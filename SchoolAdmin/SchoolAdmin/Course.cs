using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
     public class Course
    {
        public string Title { get; set; }
        public List<Student> Students = new List<Student>();
        public byte CreditPoints { get; private set; }
        public int Id { get; private set; } 
        private static int maxId = 1;
        public static List<Course> AllCourses = new List<Course>();

        public Course(string title,List<Student> students,byte creditpoints)
        {
            this.Title = title;
            this.Students = new List<Student>();
            this.CreditPoints = creditpoints;
            Id = maxId++;
            AllCourses.Add(this);
        }
        public Course(string title, List<Student> students) : this(title, students, 3)
        {
        }
        public Course(string title) : this(title, new List<Student>())
        {
        }

        public void ShowOverview()
        {
            Console.WriteLine($"{Title} ({Id}) ({CreditPoints} stp)");
            foreach (Student st in Students)
            {
                Console.WriteLine(st.Name);
            }
            Console.WriteLine();
        }
    }
}
