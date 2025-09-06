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

        private double? _result;

        public double? Result
        {
            get { return _result; }

            set
            {
                if(!(value is null) && !(value > 20))
                {
                    _result= value;
                }
            }
        }
      


        public CourseResult(string name,double? result)
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
