using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class CourseResult
    {
        public string Name { get; }
           
        
        public double Result { get; set; }
      


        public CourseResult(string name,double result)
        {
            this.Result = result;
            this.Name = name;
        }

        public void SetResult(double value)
        {
            Result = (value <= 20) ? value : 20;
        }
    }
}
