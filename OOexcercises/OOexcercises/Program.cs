using System.Collections.Immutable;
using System.Globalization;

namespace OOexcercises
{
    internal class Program
    {

  
        static void Main(string[] args)
        {
            var builder = ImmutableDictionary.CreateBuilder<int, string>();
            int counter = 1;
            counter = counter+1;
            builder.Add(1, "Harry potter");
            builder.Add(2,"The Hobbit");
            //Waarde veranderen
            builder[2] = "The Hobbit Extended edition";

            ImmutableDictionary<int, string> boeken = builder.ToImmutable();

            foreach(var boek in boeken)
            {
                Console.WriteLine($"{boek.Key}\t{boek.Value}");
            }

            Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!\n" +
                "Topic van de uit te voeren oefening?" +
                "\n1.DateTime" +
                "\n2.Classes and objects" +
                "\n3.Datastructuren");

            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    DateTimeExcercises.Submenu();
                    break;
                case 2:
                    ClassesAndObjects.Submenu();
                    break;
                case 3:
                    Datastructuren.Submenu();
                    break;
                case 4:
                    Inheritance.ShowSubMenu();
                    break;
            }
        }
    }
}
