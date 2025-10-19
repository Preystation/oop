﻿using System;
using System.Collections.Generic;
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
            int counter = 0;
            string respond = "";
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            do
            {
                if (counter == 0) { 
                Console.WriteLine("Wil je een naam en een nummer inlezen?");
                    respond = Console.ReadLine().ToLower();
                    counter++;
                }
               
                if (respond =="ja")
                {
                    
                    Console.WriteLine("Naam?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Nummer?");
                    string number = Console.ReadLine();
                    if (!(phonebook.ContainsKey(name)))
                    {
                        phonebook.Add(name, number);
                    }
                    else
                    {
                        Console.WriteLine("Fout");
                    }
                    
                     Console.WriteLine("Wil je (nog) een naam en een nummer inlezen?");
                    respond = Console.ReadLine().ToLower();
                }
                
            } while (!(respond=="nee"));
            foreach(var item in phonebook)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
        }public static void PhoneBookCityNameNumber()
        {
            string respond = "";
            Dictionary<string, Dictionary<string, string>> phonebook = new Dictionary<string, Dictionary<string, string>>();
            bool keepRunning = true;
            Console.WriteLine("Wil je een gemeente,naam en nummer inlezen?");
            while (keepRunning)
            {
                respond = Console.ReadLine();
                if (respond=="nee")
                {
                    keepRunning = false;
                }
                if (respond == "ja" || respond == "")
                {
                    Console.WriteLine("Gemeente?");
                    string gemeente = Console.ReadLine();
                    Console.WriteLine("Naam?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Nummer");
                    string number = Console.ReadLine();
                    if (!(phonebook.ContainsKey(gemeente))){
                        phonebook.Add(gemeente, new Dictionary<string, string>());
                    }
                    else
                    {
                        Console.WriteLine("Fout");
                    }
                        phonebook[gemeente].Add(name, number);
                    
                }
                Console.WriteLine("Wil je (nog) een gemeente,naam en nummer inlezen?");
            }
            foreach(var gemeente in phonebook)
            {
                Console.WriteLine($"Gemeente {gemeente.Key}");
                foreach(var entry in gemeente.Value)
                {
                    Console.WriteLine($"{entry.Key} {entry.Value}");
                }
            }
            
        }
        public static void H13_PhoneBookWithBuilder()
        {

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
                   // PhoneBookWithBuilder();
                    break;
                case 4:
                    break;
            }
        }
    }
}
