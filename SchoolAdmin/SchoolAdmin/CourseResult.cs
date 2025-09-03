using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class CourseResult
    {
        public string Name { get; set; }
        public double Result { get; set; }
        public void SetResult(double value)
        {
            Result = (value <= 20) ? value : 20;
        }
    }
}
