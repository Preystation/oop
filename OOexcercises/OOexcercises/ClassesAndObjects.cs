using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class ClassesAndObjects
    {
        public static void Figure()
        {
            Triangle one = new Triangle();
            Triangle two = new Triangle();

            // Foutieve waarde - wordt geweigerd
            one.Base = -1;

            // Geldige waardes
            one.Base = 2.2;
            one.Height = 1.5;

            two.Base = 3;
            two.Height = 3.3;

            Console.WriteLine("=== Driehoeken ===");
            Console.WriteLine($"Driehoek 1: basis = {one.Base}, hoogte = {one.Height}, oppervlakte = {one.Area}");
            Console.WriteLine($"Driehoek 2: basis = {two.Base}, hoogte = {two.Height}, oppervlakte = {two.Area}");
        }
        public static void DemoFiguresWithConstructor()
        {
            Triangle one = new Triangle(2.2, 1.5);
            Triangle two = new Triangle();

            // Foutieve waarde - wordt geweigerd
            one.Base = -1;

            // Geldige waardes
        

            two.Base = 3;
            two.Height = 3.3;

            Console.WriteLine("=== Driehoeken ===");
            Console.WriteLine($"Driehoek 1: basis = {one.Base}, hoogte = {one.Height}, oppervlakte = {one.Area}");
            Console.WriteLine($"Driehoek 2: basis = {two.Base}, hoogte = {two.Height}, oppervlakte = {two.Area}");
        }
        public static void DemoPurchase()
        {
            FoodPurchase kaas = new FoodPurchase("Kaas",2, 2.45,true);
            kaas.ShowOverview();
            FoodPurchase boter = new FoodPurchase("boter", 0, 5555, true);
            boter.ShowOverview();
        }
        public static void Submenu()
        {
            Console.WriteLine("Oefeningen ClassesAndObjects" +
                "\n1.H10-Combination of 2 numbers" +
                "\n2.H10-Figures" +
                "\n3.H11-DemoFiguresWithConstructor" +
                "\n4.H11-Foodpurchase.");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    CombinationOf2Numbers.DemoCombinationOf2Numbersmet();
                    break;
                case 2:
                    Figure();
                    break;
                case 3:
                    DemoFiguresWithConstructor();
                    break;
                case 4:
                    DemoPurchase();
                    break;
            }
        }
    }
}
