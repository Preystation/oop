using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class AandrijvingElekrisch : IAandrijving
    {
        public void EnergieToevoegen()
        {
            throw new NotImplementedException();
        }

        public void Versnellen(int kmPerUurPerSeconde, int doelsnelheid)
        {
            Console.WriteLine("Versnellen - Elektrische");
        }

        public void Vertragen(int kmPerUurPerSeconde, int doelsnelheid)
        {
            throw new NotImplementedException();
        }
    }
}
