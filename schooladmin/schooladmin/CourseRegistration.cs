using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schooladmin
{
    internal class CourseRegistration
    {
        private string course;
        public string Name
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }
        private byte? result;
        public byte? Result { 
            get
            {
                return result;
            }
            set
            {
                if ((value>20) && !(value is not null))
                {
                    result = value;
                }
            }
        }
        public CourseRegistration(string name,byte? result)
        {
            this.course = name;
            this.Result = result;
        }
    }
}
