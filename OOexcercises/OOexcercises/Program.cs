using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace OOexcercises
{
    internal class Program
    {

        class Boek
        {
            private string titel;
            private int paginas;
            private string auteurs;
            public string Titel { get { return titel; } }
            public Boek(string boektitel,int boekpaginas,string boekAuteur)
            {
                this.titel = boektitel;
               this.paginas = boekpaginas;
                this.auteurs = boekAuteur;
                if (paginas < 1) paginas = 1;
            }

            public Boek(string boektitel, int boekpaginas):this(boektitel, boekpaginas,"onbekend")
            {
                
            }
            public Boek(string boektitel) : this("Niet gevonden",100,"onbekend")
            {

            }
            public Boek() : this("Standaard")
            {

            }
            
        }



        class Auto
        {
            private int benzine;
            private int kilometers;
            public int Benzine { get { return benzine; } }
            public int Kilometers
            {
                get { return kilometers; }
                set
                {
                    if (value == 15)
                    {
                        Console.WriteLine("Waarde kan niet 15 zijn ");

                    }
                    else
                    {
                        kilometers = value;
                    }
                }
            }
            public Auto(int benzine, int kilometers)
            {
                this.benzine = benzine;
                this.Kilometers = kilometers;
            }
         

            public Auto() : this(5, 5)
            {
                // Geen extra code hier
            }
        }
        public static int CircuitPower(int voltage, int current)
        {
            int power = 0;
            power = voltage * current;

            return power;
        }
        public static int convert(int minutes)
        {
            int counter = 0;
            int seconds = 0;
            while (counter < minutes)
            {
                seconds = seconds + 60;
                counter++;
            }
            return seconds;
        }
        static void Main(string[] args)
        {
            Boek b1 = new Boek("C# leren",301);
            Boek b2 = new Boek();
            Console.WriteLine($"{b1.Titel}");
            Console.WriteLine($"{b2.Titel}");
            Boek b3 = new Boek("c# vervangen",150);
            Console.WriteLine($"{b1.Titel} {b1.Titel} {b1.Titel}");
            Auto a1 = new Auto();
            Console.WriteLine($"{a1.Benzine}, {a1.Kilometers}");

            Auto a2 = new Auto(10, 15);
            Console.WriteLine($"{a2.Benzine}, {a2.Kilometers}");
            Console.WriteLine("tet");
            Console.WriteLine(convert(60));
        }
    }
}
