using System.Globalization;

namespace OOexcercises
{
    internal class Program
    {

  
        static void Main(string[] args)
        {

            Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!" +
                "\nTopic van de uit te voeren oefening?" +
                "\n1. DateTime" +
                "\n2. Classes and objects");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                   DateTimeExcercises.Submenu();
                        break;
                case 2:
                    ClassesAndObjects.Submenu();
                    break;
                default:
                    Console.WriteLine("Onbekende keuze");
                    break;
            }

        }
    }
}
