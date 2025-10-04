using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class CourseResult
    {
        public string Name
        {
            get { return name; }
            set
            {
                if (value is not null && value != "")
                {
                    name = value;
                }
            }
        }
        private string name;
        public byte Result
        {
            get
            {
                return result;
            }
            set
            {
                if(value>20|| value < 0)
                {
                    Console.WriteLine("Kan niet meer dan 20 zijn en kan neit onder de 0 zijn ");
                }
                else
                {
                    result = value;
                }
            }
        }
        private byte result;
    public CourseResult(string name,byte result)
        {
            this.Name = name;
            this.Result = result;
        }

   
    }
}
