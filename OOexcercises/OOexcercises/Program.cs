using System.Globalization;

namespace OOexcercises
{
    internal class Program
    {
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
        }
    }
}
