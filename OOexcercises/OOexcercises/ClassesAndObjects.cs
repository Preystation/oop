using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class ClassesAndObjects
    {

        public static void Submenu()
        {
            Console.WriteLine("Uit te voeren oefening?"+
      "\n1. H10_CombinationOf2Numbers" +
      "\n4 H11_FoodPurchase");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                   H10_CombinationOf2Numbers();
                    break;
                case 4:
                    DemoPurchase();
                    break;
                default:
                    Console.WriteLine("Onbekende keuze");
                    break;
            }
        }


        public class CombinationOf2Numbers // hulp van chatgpt
        {
            public int number1 { get; set; }
            public int number2 {get;set;}

            public double Sum()
            {
                return number1 + number2;
            }
            public double Difference()
            {
                return number1 - number2;
            }
            public double Product()
            {
                return number1 * number2;
            }
            public double Quotient()
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Fout!");
                    return number2 / number2;
                }
                else
                {
                    return (double)number1 / number2;
                }
            }


        }
        public static void H10_CombinationOf2Numbers()
        {
            CombinationOf2Numbers pair = new CombinationOf2Numbers();
            pair.number1 = 12;
            pair.number2 = 34;
            Console.WriteLine("Paar:" + pair.number1 + ", " + pair.number2);
            Console.WriteLine("Som = " + pair.Sum());
            Console.WriteLine("Verschil = " + pair.Difference());
            Console.WriteLine("Product = " + pair.Product());
            Console.WriteLine("Quotient = " + pair.Quotient());
        }


        public static void DemoPurchase()
        {
            FoodPurchase kaas = new FoodPurchase("kaas", 2, 2.45, true);
            FoodPurchase boter = new FoodPurchase("Boter", 0, 5555, true);

            Console.WriteLine($"De Totaalprijs van {kaas.ProductName} is {kaas.CalculateTotalPrice}" +
                $"De vervaldatum van aankoop{kaas.Number} is {kaas.ExpirationDate}");

        }

    }
}
