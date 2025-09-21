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
