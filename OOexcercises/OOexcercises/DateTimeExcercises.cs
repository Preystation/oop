using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class DateTimeExcercises
    {
        public static void Submenu()
        {

            Console.WriteLine("Uit te voeren oefening?" +
             "\n1. H10-Clock");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    h10_clock();
                    break;
                default:
                    Console.WriteLine("Onbekende keuze");
                    break;
            }
        }
        public static void h10_clock() {
            while (true)
            {
                Console.Clear();
             DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("T"));
                System.Threading.Thread.Sleep(1000);

            }
        }
    }
}
