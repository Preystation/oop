using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class Stoomketel : Ketel,IStoomVerwarmen, IVerwarmen, IAfkoelen, IWaterDoseren
    {
        public Stoomketel(int inhoud) : base(inhoud)
        {
        }

        public override int Inhoud { get; protected set; }
        public override int Temperatuur { get; protected set; }

        public void Afkoelen(int doelTemperatuur)
        {
            throw new NotImplementedException();
        }

        public void StoomVerwarmen(int doelTemperatuur)
        {
            throw new NotImplementedException();
        }

        public void Verwarmen(int doelTemperatuur)
        {
            throw new NotImplementedException();
        }

        public void WaterDoseren(int hoeveelheid)
        {
            throw new NotImplementedException();
        }
    }
}

