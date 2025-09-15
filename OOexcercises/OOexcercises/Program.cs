using System.Globalization;

namespace OOexcercises
{
    internal class Program
    {
        public static int animals(int chickens, int cows, int pigs)
        {
            int chickenLegs = 0; ;
            for(int i = 0; i < chickens; i++)
            {
                chickenLegs = chickenLegs + 2;
            }

            int cowLegs = 0; ;
            for (int i = 0; i < cows; i++)
            {
                cowLegs = cowLegs + 4;
            }

            int pigLegs = 0; ;
            for (int i = 0; i < pigs; i++)
            {
                pigLegs = pigLegs + 4;
            }
            int total = chickenLegs + cowLegs + pigLegs;
            return total;
        }
        static void Main(string[] args)
        {

            Fiets f1 = new Fiets();
            f1.AantalVersnellingen = 3;
            f1.Kleur = "zwart";
            f1.Snelheid = 15;

            Console.WriteLine(Points(5,2));
    }
    }
}
