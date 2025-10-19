using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class CombinationOf2Numbers
    {
        public static void DemoCombinationOf2Numbersmet()
        {
            CombinationOf2Numbers pair = new CombinationOf2Numbers();
            pair.Number1 = 12;
            pair.Number2 = 12;
            Console.WriteLine("Paar:" + pair.Number1 + ", " + pair.Number2);
            Console.WriteLine($"Som: {pair.Sum()}");
            Console.WriteLine($"Verschil : {pair.Difference()}");
            Console.WriteLine($"Product : {pair.Product()}");
            Console.WriteLine($"Quotient  : {pair.Quotient()}");


        }
        
        public int Number1;
        public int Number2;
        public double Sum()
        {
            return Number1 + Number2;
        }
        public double Difference()
        {
            return Number1 - Number2;
        }
        public double Product()
        {
            return Number1 * Number2;
        }

        public double Quotient()
        {
            if(Number1 ==0 || Number2 == 0)
            {
                Console.WriteLine("fout");
            }

            return Number1 * Number2;
        }
    }
}