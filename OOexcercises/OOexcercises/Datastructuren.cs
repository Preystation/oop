using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class Datastructuren
    {
        public static void PhoneBookNumber()
        {
            Dictionary<string,string> phonebook = new Dictionary<string, string>();
            string answer = "";
            Console.WriteLine("Wil je een naam en nummer inlezen?");
            answer = Console.ReadLine().ToLower().Trim();
            do
            {
               
                Console.WriteLine("Naam?");
                string name = Console.ReadLine();
                Console.WriteLine("Nummer?");
                string number = Console.ReadLine();
                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }
                else
                {
                    phonebook.Add(name, number);
                }
                Console.WriteLine("Wil je (nog) een naam en nummer inlezen?");
                answer = Console.ReadLine().ToLower().Trim();


            } while (answer=="ja".ToLower().Trim());
            foreach(var ph in phonebook)
            {
                Console.WriteLine($"{ph.Key} {ph.Value}");
            }
        }
        public static void PhoneBookCityNameNumber()
        {
            Console.WriteLine("Wil je een gemeente, naam en nummer inlezen?");
            Dictionary<string, Dictionary<string, string>> phonebook = new Dictionary<string, Dictionary<string, string>>();
            string respond = Console.ReadLine();
            while(respond.ToLower().Trim() == "ja")
            {
                Console.WriteLine("Gemeente?");
                string gemeente = Console.ReadLine();
                Console.WriteLine("Naam?");
                string name = Console.ReadLine();
                Console.WriteLine("Nummer?");
                string number = Console.ReadLine();
                if (phonebook.ContainsKey(gemeente))
                {
                    phonebook[gemeente].Add(name, number);
                }
                else
                {
                    phonebook.Add(gemeente, new Dictionary<string, string>());
                    phonebook[gemeente].Add(name, number);
                }
                Console.WriteLine("Wil je nog een gemeente,naam en nummer inlezen?");
                respond = Console.ReadLine();
            }
            foreach (var gemeente in phonebook)
            {
                Console.WriteLine($"Gemeente:{gemeente.Key}");
                foreach (var personen in gemeente.Value)
                {
                    Console.WriteLine($"{personen.Key} {personen.Value}");
                }
            }
            

        }
        public static void H13_PhoneBookWithBuilder()
        {
            var builder = ImmutableDictionary.CreateBuilder<string, string>();
            string respond = Console.ReadLine();
            while (respond == "ja")
            {
                Console.WriteLine("Naam?");
                string name = Console.ReadLine();
                Console.WriteLine("Nummer?");
                string number = Console.ReadLine();
                builder[name] = number;
                var phonebook = builder.ToImmutableDictionary<string, string>();
            }
        
        }
        public static void Submenu()
        {
            Console.WriteLine("Uit te voeren oefening?" +
                "\n1.H13-PhoneBookNumber" +
                "\n2.H13-PhoneBookCityNameNumber" +
                "\n3.H13-PhoneBookWithBuilder"
                );

            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    PhoneBookNumber();
                    break;
                case 2:
                    PhoneBookCityNameNumber();
                    break;
                case 3:
                    H13_PhoneBookWithBuilder();
                    break;
                case 4:
                    break;
            }
        }
    }
}
