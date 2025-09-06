using System.Globalization;

namespace OOexcercises
{
    internal class Program
    {
        public class Media
        {
            public string Titel;

            public void ToonInfo()
            {
                Console.WriteLine($"{Titel}");
            }
            public Media(string titel)
            {
                Titel = titel;
            }
        }
      public class Boeken : Media
        {
            public string Auteurs;
            public Boeken(string titel, string auteurs) : base(titel)
            {
                Auteurs = auteurs;
            }
        }
        public class Dier
        {
            public string Soort;
            public int Leeftijd;


            public Dier(string soort,int leeftijd)
            {
                this.Soort = soort;
                this.Leeftijd = leeftijd;
                if (leeftijd < 0) Leeftijd = 0;
            }
            public Dier() : this("Hond", 1)
            {

            }
            public Dier(string soort) : this(soort, 0)
            {

            }
            public void ToonInfo()
            {
                Console.WriteLine("Soort: " + Soort + ", Leeftijd: " + Leeftijd);
            }
        }

        
        static void Main(string[] args)
        {
            Dier d1 = new Dier("Vogelbekdier", 10);
            d1.ToonInfo();

            Dier d2 = new Dier();
            Dier d3 = new Dier("Haai");
            d2.ToonInfo();
            d3.ToonInfo();

            Dictionary<int, string> costumers = new Dictionary<int, string>();
            costumers.Add(1, "Cedric");
            costumers.Add(2, "Bart");
            costumers.Add(3, "Kai");
            costumers.Add(4, "Jan");

            foreach(var costumer in costumers)
            {
                Console.WriteLine($"{costumer.Key}\t {costumer.Value}");
            }
            Console.WriteLine(costumers[1]);
        }
    }
}
