using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class Rectangle
    {
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een hoogte van {value} in te stellen!");
                }
                {
                    height = value;
                }
            }
        }
        private double width;
        public double Width 
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een breedt van {value} in te stellen!");
                }
                {
                    width = value;
                }
            }

        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle() : base()
        {

        }

    }
}
