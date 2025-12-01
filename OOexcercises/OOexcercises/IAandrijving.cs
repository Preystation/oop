using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal interface IAandrijving
    {
        void EnergieToevoegen();
        void Vertragen(int kmPerUurPerSeconde, int doelsnelheid);
        void Versnellen(int kmPerUurPerSeconde, int doelsnelheid);
    }
}
