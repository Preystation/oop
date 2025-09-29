using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schooladmin
{
    internal class Course
    {
        public string Title;
        public List<Student> Students = new List<Student>();
        private byte creditpoints;
        public byte Creditpoints {
            get
            {
                return creditpoints;
            }
           private set
            {
                creditpoints = value;
            }
                }
        private int id;
        public int Id { 
            get 
            { return id; 
            }
        }
        private static int maxId = 0;
        public static List<Course> AllCourses = new List<Course>();

    
        public Course(string title,List<Student> students,byte creditPoints)
        {
            this.Title = title;
            this.Students = students;
            this.Creditpoints = creditPoints;
            id = maxId++;
            AllCourses.Add(this);
        }


        public Course(string title, List<Student> students) : this(title, students, 3)
        {

        }

        public Course(string title) : this(title, new List<Student>()) { }
        public void ShowOverview()
        {
            Console.WriteLine($"{Title} ({id}) ({creditpoints})");
            foreach (Student item in Students)
            {
                Console.WriteLine(item.Name);
              
            }
            Console.WriteLine();
        }

        public static Course SearchCourseById(int id)
        {
            foreach( Course item in AllCourses)
            {
                if(item.id == id)
                {
                    return item;
                }
            }
            return null;
        } 
    }
}
