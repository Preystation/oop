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
        DateTime now = DateTime.Now;
        public static void H10_Clock()
        {
         while (true) {
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("T"));
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }

        public static void H10_BirthDay()
        {
            Console.WriteLine("Op welk jaar ben je geboren");
            string birthYear = Console.ReadLine();
            DateTime yearOfBirth = DateTime.Parse(birthYear);
            DateTime nextBirthday = new DateTime(DateTime.Now.Year, yearOfBirth.Month, yearOfBirth.Day).AddYears(1);
            TimeSpan difference = nextBirthday - DateTime.Now;
            Console.WriteLine($"Over {difference.Days} ben je jarig.");
;                
                }

        public static void H10_DayOfTheWeek()
        {
            Console.WriteLine("Welke dag?");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welke maand");
            int month = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Welk jaar?");
            int year = Convert.ToInt32(Console.ReadLine()); ;

            DateTime dayOfTheWeek = new DateTime(year, month, day);
            CultureInfo belgianCI = new CultureInfo("nl-BE");
            Console.WriteLine($"{dayOfTheWeek.ToString("d MMMM yyyy", belgianCI)} is een {dayOfTheWeek.ToString("dddd")}");
        }
        public static void H10_TickSince2000()
        {
            DateTime year2000 = new DateTime(2000, 01, 01);
            TimeSpan now = DateTime.Now - year2000;
            Console.WriteLine($"Sinds {year2000.ToString("d")} zijn er {now.Ticks} ticks voorbijgegaan");

        }
        public static void H10_LeapYearCount()
        {
            int year1799 = 1799;
            int year2021 = 2021;
            int count = 0;
            for(int i = year1799; i <= year2021; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    count = count +1;
                }
                
            }
            Console.WriteLine($"Er zijn {count} schrikeljaren tussen {year1799} en  {year2021}");
        }
        public static void CodeTiming()
        {
            DateTime start = DateTime.Now;

            int[] million = new int[1000000];
            
            for(int i = 0; i < million.Length; i++)
            {
                million[i] = i;
            }
            DateTime end = DateTime.Now;
            TimeSpan difference = end - start;

            Console.WriteLine($"Het duurt {difference.Milliseconds} milliseconden om een array van 1 miljoen op te vullen.");
        }
        public static void Submenu()
        {
            
            Console.WriteLine("Oefeningen DateTime" +
                "\n1.Clock" +
                "\n2.Birthday" +
                "\n3.DayOfTheWeek" +
                "\n4 DayOfTheWeek" +
                "\n5 TickSince2000" +
                "\n6 LeapYearCount" +
                "\n7 CodeTiming");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    H10_Clock();
                    break;
                case 2:
                    H10_BirthDay();
                    break;
                case 3:
                    H10_DayOfTheWeek();
                    break;
                case 4:
                    H10_DayOfTheWeek();
                    break;
                case 5:
                    H10_TickSince2000();
                    break;
                case 6:
                    H10_LeapYearCount();
                    break;
                case 7:
                    CodeTiming();
                    break;
                default:
                    Console.WriteLine("Onbekende keuze");
                    break;
            }
      
        }
    }
}
