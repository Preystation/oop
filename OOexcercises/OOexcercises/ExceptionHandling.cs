using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class ExceptionHandling

    {
        private static void DemonstreerFoutafhandelingWeekdagenZonderException()

        {
            string[] arr = new string[5];
            arr[0] = "Vrijdag";
            arr[1] = "Maandag";
            arr[2] = "Dinsdag";
            arr[3] = "Woensdag";
            arr[4] = "Donderdag";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }
        private static void DemonstreerFoutafhandelingWeekdagenMetException()
        {
            string[] arr = new string[5];
            arr[0] = "Vrijdag";
            arr[1] = "Maandag";
            arr[2] = "Dinsdag";
            arr[3] = "Woensdag";
            arr[4] = "Donderdag";
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
        private static void DemonstreerFoutafhandelingOverflowZonderException()
        {
            int num1, num2;
            int resultaat;
            num1 = 30;
            num2 = 60;
            resultaat = Convert.ToInt32(num1 * num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);
        }

        private static void DemonstreerFoutafhandelingOverflowException()
        {
          
            try
            {
                int num1, num2;
                byte resultaat;
                num1 = 30;
                num2 = 60;
                resultaat = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Het getal is te groot om te converteren naar het gewenste formaat.");
            } 
        }
        public static void DemonstreerKeuzeElement()
        {
            int[] numbers = { 9, 2, 6 };
            bool keeprunning = true;
            do
            {
                Console.WriteLine("Geef de index van eht getal dat je wil zien");
                int index = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine(numbers[index]);  
                }
                catch
                {
                    Console.WriteLine("Die index hebben wij niet");
                }
            } while (keeprunning);
        }
        public static void DemonstreerKeuzeElementExtraVeilig()
        {
            int[] numbers = { 9, 2, 6 };
            bool keeprunning = true;
            do
            {
            
                try
                {
                    Console.WriteLine("Geef de index van eht getal dat je wil zien");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numbers[index]);
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Die index hebben wij niet");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Dit is tekst");
                }
               catch
                {
                    Console.WriteLine("Fout gebeurd.");
                }
            } while (keeprunning);
        }
        public static void DemonstreerLeeftijdKat()
        {
            try
            {
                Cat kat = new Cat(27);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
        public static void DemonstreerLeeftijdKatMetResourceCleanup()
        {
            List<int> ageCats = new List<int>() { 20, 25, 10, 15, 19, 16, 29, 1, 1, 1, 1, 1, 15, 16, 17, 18, 19, 10 };

            
                foreach (int ac in ageCats)
                {
                    if (ac > 30)
                    {
                        throw new ArgumentException("Het is niet gelukt :-(");
                    ageCats.Clear();
                    }
                   
                }
                Console.WriteLine("De volledige lijst met katten is aangemaakt!");
            ageCats.Clear();

        }
        public static  void ShowSubmenu()
        {
            Console.WriteLine("1. voor ExceptionHandlingExcercise" +
                "\n2. Voor eceptions handling" +
                "\n3. DemonstreerFoutafhandelingOverflowZonderException" +
                "\n4. overflow-met-exception-handling" +
                "\n5. DemonstreerKeuzeElement" +
                "\n6. DemonstreerKeuzeElementExtraVeilig" +
                "\n7. leeftijd kat" +
                "\n8. DemonstreerLeeftijdKatMetResourceCleanup" +
                "\n9. FileHelper nog doen" +
                "\n10.h16-leeftijd-kat-custom ");

            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    DemonstreerFoutafhandelingWeekdagenZonderException();
                    break;
                case 2:
                    DemonstreerFoutafhandelingWeekdagenMetException();
                    break;
                case 3:
                    DemonstreerFoutafhandelingOverflowZonderException();
                    break;
                case 4:
                    DemonstreerFoutafhandelingOverflowException();
                    break;
                case 5:
                    DemonstreerKeuzeElement();
                    break;
                case 6:
                    DemonstreerKeuzeElementExtraVeilig();
                    break;
                case 7:
                    DemonstreerLeeftijdKat();
                    break;
                case 8:
                    DemonstreerLeeftijdKatMetResourceCleanup();
                    break;

            }
        }
    }
}
