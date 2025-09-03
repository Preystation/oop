using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
     public class Course
    {
        public string Title { get; set; }
        public List<Student> Students = new List<Student>();
        public byte CreditPoints { get; set; }
        public int Id 
        { 
            get 
            { 
                return maxId++; 
            }
        }
        private int maxId = 1;
        public static List<Course> AllCourses = new List<Course>();

        public void ShowOverview()
        {
            Console.WriteLine($"{Title}");
           foreach(Student st in Students)
            {
                Console.WriteLine(st.Name);
            }
            Console.WriteLine("");
        }
    }
}
