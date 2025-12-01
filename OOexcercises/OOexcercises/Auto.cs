using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class Auto
    {
        public string AutoType { get; set; }
        public IAandrijving Aandrijving { get; set; }

        public Auto(string autoType, IAandrijving? aandrijving) {
            AutoType = autoType;      
            Aandrijving = aandrijving;
        }

       
    }
}
