using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class Cat
    {
        public int Age
        {
            get
            {
                return Age;
            }
            private set
            {
                if (value > 25 )
                {
                    throw new ArgumentException("Deze kat is te oud!");
                }
                else
                {
                    Age = value;
                }
            }
        }
 
        public Cat(int age)
        {
            this.Age = age;
        }
    }
}
