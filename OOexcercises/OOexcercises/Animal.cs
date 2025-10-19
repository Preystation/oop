using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal abstract class Animal
    {
      public  enum Genders { male,female}

        private string name;
        private Genders gender;
        private List<string> allergies;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Genders Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        abstract public  ImmutableList<string> Allergies
        {
            get
            {
                return allergies.ToImmutableList<string>();
            }
        }

       // abstract public  void ShowChip() { }
    }
}
