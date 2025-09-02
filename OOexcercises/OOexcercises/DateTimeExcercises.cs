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
             "\n1. H10-Clock" +
             "\n2. H10_Birthday");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    h10_clock();
                    break;
                case 2:
                    H10_Birthday();
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
        public static void H10_Birthday()
        {
            DateTime now = DateTime.Now;
            Console.Write("Voer je verjaardag in:");
            string date = Console.ReadLine();
            DateTime birthday = DateTime.Parse(date);
            DateTime nextBirtday = new DateTime(now.Year, birthday.Month, birthday.Day);
            nextBirtday = nextBirtday.AddYears(1);
            TimeSpan diff = nextBirtday - now;
            Console.WriteLine($"Over {diff.Days} dagen bent u jarig");
        }
    }
}
