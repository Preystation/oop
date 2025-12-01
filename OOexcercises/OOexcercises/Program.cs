using System.Collections.Immutable;
using System.Globalization;

namespace OOexcercises
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!\n" +
                "Topic van de uit te voeren oefening?" +
                "\n1.DateTime" +
                "\n2.Classes and objects" +
                "\n3.Datastructuren" +
                "\n5.exceptions" +
                "\n6.Polymorfisme");

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
                case 5:
                    ExceptionHandling.ShowSubmenu();
                    break;
                case 6:
                    Polymorfisme.ToonSubmenu();
                    break;
            }
        }
    }
}
