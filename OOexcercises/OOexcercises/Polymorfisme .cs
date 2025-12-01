using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOexcercises
{
    internal class Polymorfisme
    {
        public static void autoconstructeur()
        {
            Auto volvo = new Auto("Porche1234", new AandrijvingBezine());
            volvo.Aandrijving.Versnellen(10,120);
        }
        public static void DemonstreerGrootkeuken()
        {
            Ketel ketel1 = new Stoomketel(300);
            Ketel ketel2 = new Stoomketel(300, 100);
            Ketel ketel3 = new KetelZonderDoseren(150, 100);
            Ketel ketel4 = new KetelZonderDoseren(300, 100);
            Ketel ketel5 = new KetelMetDoseren(200, 100);
            Ketel ketel6 = new KetelMetDoseren(150, 100);

        }
        public static void ToonSubmenu()
        {
            Console.WriteLine($"Maak een keuze aan de volgende oefeningen." +
                $"\n1.h17-autoconstructeur" +
                $"\n2.h17-grootkeuken");
            int number = 0;
            try
            {
                 number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            switch (number)
            {
                case 1:
                    autoconstructeur();
                    break;
                case 2:
                    DemonstreerGrootkeuken();
                    break;
                default:
                    Console.WriteLine($"Onbekende keuze");
                    break;
            }
        }
    }
}
