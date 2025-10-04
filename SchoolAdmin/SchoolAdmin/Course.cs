using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Course
    {
        public string Title;
        public List<Student> Students = new List<Student>();
        private byte creditpoints;
        public byte CreditPoints
        {
            get
            {
                return creditpoints;
            }
            private set
            {
                if (value > 0)
                {
                    creditpoints = value;
                }
            }
        }
        public int Id { get { return id = maxId++; } }
        private int id;
        private int maxId = 1;
        public static List<Course> AllCourses = new List<Course>();
     

        public Course(string title, List<Student> students, byte creditPoints)
        {
            this.Title = title;
            this.Students = students;
            this.CreditPoints = creditPoints;
            id = maxId++;
            AllCourses.Add(this);
        }

        public Course(string title, List<Student> students) : this(title, students, 3) { }
       

        public Course(string title) : this(title, new List<Student>()) { }


        public void ShowOverview()
        {
            Console.WriteLine($"{Title} {Id} {CreditPoints}");
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name}");
            }
            Console.WriteLine();
        }
        public static Course SearchById(int id)
        {
            foreach (Course course in AllCourses)
            {
                if (id == course.Id)
                {
                    return course;
                }
            }
            return null;
        }
    }
}
