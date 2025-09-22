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

            }
                }
        private int id;
        public int Id { 
            get 
            { return id; 
            }
        }
        private static int maxId = 1;
        public static List<Course> Courses = new List<Course>();
        public void ShowOverview()
        {
            Console.WriteLine($"{Title}");
            foreach (Student item in Students)
            {
                Console.WriteLine(item.Name);
              
            }
            Console.WriteLine();
        }
    }
}
