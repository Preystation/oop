using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Course
    {
        public string Title;
        public List<Student> Students = new List<Student>();
        public byte CreditPoints { 
            get 
            { return creditpoints; 
            }
        private set
            {
                creditpoints = value;
            }
        }
        private byte creditpoints;
        public int Id
        {
            get
            {
                return this.id =id + maxId++ ;
            }
            
        }
        private List<Course> allCourses = new List<Course>();
        public ImmutableList<Course> AllCourses
        {
            get
            {
                return allCourses.ToImmutableList<Course>();
            }
        }
        private int maxId =1;
        private int id;


        public Course(string title,List<Student>students,byte creditpoints)
        {
            this.Title = title;
            this.Students = students;
            this.creditpoints = creditpoints;
            AllCourses.Add(this);
        }

        public Course(string title, List<Student> students):this(title,students,3) { }
        public Course(string title) : this(title,new List<Student>()) { }

        public void ShowOverview()
        {
            Console.WriteLine($"{Title}");
            foreach (Student student in Students)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();
        }
        public Course SearchCourseById(int id)
        {
            foreach (Course course in AllCourses)
            {
                if(course.id == id)
                {
                    return course;
                }
               
            }
            return null;
        }
    }
}
