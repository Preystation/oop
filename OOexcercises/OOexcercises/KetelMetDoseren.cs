using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class KetelMetDoseren :Ketel, IVerwarmen, IWaterDoseren
    {
        public KetelMetDoseren(int inhoud) : base(inhoud)
        {
        }

        public override int Inhoud { get; protected set; }
        public override int Temperatuur { get; protected set; }

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
