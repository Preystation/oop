using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class StudieProgram
    {
        private string name;
        public string Name { get { return name; } }

        private List<Course> courses = new List<Course>();
        public List<Course> Courses { 
            
            get 
            { 
                return courses; 
            
            }
            set
            {
                courses = value;
            }
        }

        public StudieProgram(string name)
        {
            this.name = name;
        }
    }
}
