using System;
using System.Collections.Generic;
using System.Globalization;
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
             "\n2. H10_Birthday" +
             "\n3. H10_DayOfTheWeek" +
             "\n4. H10_TicksSince2000" +
             "\n5. H10_LeapYearCount" +
             "\n6. H10_CodeTimin");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    h10_clock();
                    break;
                case 2:
                    H10_Birthday();
                    break;
                case 3:
                    H10_DayOfTheWeek();
                    break;
                case 4:
                    H10_TicksSince2000();
                    break;
                case 5:
                    H10_LeapYearCount();
                    break;
                case 6:
                    H10_CodeTiming();
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
        public static void H10_DayOfTheWeek()
        {
            Console.WriteLine("Welke dag");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welke maand");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welke jaar");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime dayOfTheWeek = new DateTime(year, month, day);
            CultureInfo dutch = new CultureInfo("nl-BE");
            Console.WriteLine($"{dayOfTheWeek.ToString("d")} is een {dayOfTheWeek.ToString("dddd",dutch)}");//Chatgpt
        }
        public static void H10_TicksSince2000()
        {
            DateTime now = DateTime.Now;
            DateTime year2000 = new DateTime(2000, 01, 01);
            TimeSpan diff = now - year2000;

            Console.WriteLine($"Sinds {year2000.ToString("d")} zijn er {diff.Ticks} ticks voorbijgegaan.");
        }
        public static void H10_LeapYearCount()
        {
            int startYear = 1799;
            int endYear = 2021;
            int yearCounter = 0;
            for(int i = startYear; i < endYear; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    yearCounter++;
                }
            }

            Console.WriteLine($"Er zijn {yearCounter} schrikeljaren tussen {startYear} en {endYear}");
        }
        public static void H10_CodeTiming()
        {
            int[] numbers = new int[1000000];
            DateTime start = DateTime.Now;
            for(int i = 0;i< numbers.Length; i++)
            {
                numbers[i] = i;
            }
            DateTime end = DateTime.Now;
            TimeSpan diff = end - start;
            Console.WriteLine($"Het duurt {diff.Milliseconds} milliseconden om een array van een miljoen elementen aan te maken en op te vullen met opeenvolgende waarden.");
        }
    }
}
