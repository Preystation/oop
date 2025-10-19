using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class StudyProgram
    {
        private string name;
        private string Name { get { return name; } }
        private  List<Course> courses = new List<Course>();
        public ImmutableList<Course> Courses
        {
            get
            {
                return courses.ToImmutableList<Course>();
            }
           
        }
        public StudyProgram(string name)
        {
            this.name = name;
           
        }
        public void ShowOverview()
        {
            Console.WriteLine($"Programma: {Name}\n");
            foreach (Course course in Courses)
            {
                course.ShowOverview();
            }
        }
    }
}
