using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class Fiets
    {
        public string Kleur;
        public int AantalVersnellingen;
        public double Snelheid;


        public double Toename(double Toename)
        {
            return Snelheid = Snelheid+ Toename;
        }

        public double Rem()
        {
          return Snelheid = 0;
        }
    }
}
