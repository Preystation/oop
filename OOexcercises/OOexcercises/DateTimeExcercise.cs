using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class DateTimeExcercise
    {
        public static void Birthday()
        {
            DateTime birthday = new DateTime(1992, 08, 10);
            birthday.AddYears(10);
            CultureInfo belgium = new CultureInfo("nl,BE");
            Console.WriteLine($"Verjaardag + 10 jaar: {birthday.ToString("d/M/yyyy")}");
            Console.WriteLine($"Dag van de week {birthday.DayOfWeek.ToString("d")}");
        }
    }
}
