using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal abstract class Ketel
    {
        public abstract int Inhoud { get; protected set; }
        public abstract int Temperatuur { get; protected set; }
        public Ketel(int inhoud)
        {
            this.Inhoud = inhoud;
            this.Temperatuur = 0;
        }
    }
}
