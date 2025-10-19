using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class CourseResistration
    {
        public Course Course {
            get 
            { 
                return course; 
            }
          
        
        }
        private Course course;
        public byte? Result
        {
            get
            {
                return result;
            }
            set
            {
                if (value < 20)
                {
                    result = value;
                }
            }
        }
        private byte? result;
        public CourseResistration(Course course,byte? result)
        {
            this.course = course;
            this.result = result;
        }
    }
}
