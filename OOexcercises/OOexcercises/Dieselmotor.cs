using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class Dieselmotor
    {
        public interface IAandrijving
        {
            void EnergieToevoegen();
            void Vertragen(int kmPerUurSeconde, int doelsnelheid);
            void Versnellen(int kmPerUurPerSeconde, int doelsnelheid);
        }
    }
}
