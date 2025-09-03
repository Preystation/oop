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
        public double Result
        {
            get { return Result; }
            set
            {

                if (Result < 20)
                {
                    Result = value;
                }
                else
                {
                    Console.WriteLine("Resultaat kan niet groter zijn dan 20.");

                }
            }
        }
    }
}
