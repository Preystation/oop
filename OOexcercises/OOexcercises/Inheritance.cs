using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class Inheritance
    {
       
        static public void ShowSubMenu()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Uit te voeren oefening?");
                Console.WriteLine("1. H14-DemoPostOffice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DemoPostOffice();
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze!");
                        break;
                }
            }
        }
        public static void DemoPostOffice()
        {
            Console.WriteLine("Wil je nog een brief toevoegen (ja/nee)?");
            string answer = Console.ReadLine();
            List<RegisteredLetter> letters = new List<RegisteredLetter>();
            while (answer.ToLower() == "ja")
            {
                Console.WriteLine("Wat voor brief wil je toevoegen?");
                Console.WriteLine("1. standaard");
                Console.WriteLine("2. internationaal");
                Console.WriteLine("3. hoge prioriteit ");
                Console.WriteLine("4. geen enkele, we zijn klaar met invoeren");
                string choice = Console.ReadLine();
                if (choice == "4")
                {
                    answer = "nee";
                }
                else
                {
                    Console.WriteLine("Hoe ver moet deze brief");
                    double howFar = Convert.ToDouble(Console.ReadLine());
                    switch (choice)
                    {
                        case "1":
                            RegisteredLetter letter = new RegisteredLetter();
                            letter.Distance = howFar;
                            letters.Add(letter);
                            break;
                        case "2":
                            InternationalRegisteredLetter internatLetter = new InternationalRegisteredLetter();
                            internatLetter.Distance = howFar;
                            letters.Add(internatLetter);
                            break;
                        case "3":
                            HighPriorityRegisteredLetter priorLetter = new HighPriorityRegisteredLetter();
                            priorLetter.Distance = howFar;
                            letters.Add(priorLetter);
                            break;
                    }
                }
            }
            int counter = 1;
            foreach (var letter in letters)
            {
                Console.WriteLine($"Brief {counter}: {letter.Distance}km, reistijd {letter.Duration} dagen, kostprijs {letter.Price} euro");
                counter++;
            }
        }
    }
}
