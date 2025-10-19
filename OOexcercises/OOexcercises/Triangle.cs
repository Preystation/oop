using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class Triangle
    {
        private double @base = 1;
        private double height = 1;

        public double Base
        {
            get { return @base; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een basis van {value} in te stellen!");
                }
                else
                {
                    @base = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een hoogte van {value} in te stellen!");
                }
                else
                {
                    height = value;
                }
            }
        }

        public double Area
        {
            get { return Math.Round(@base * height / 2, 2); } // 2 cijfers na de komma
        }
        public Triangle(double @base, double height)
        {
            this.@base = @base;
            this.height = height;
        }
        public Triangle() : base()
        {

        }
    }
}
