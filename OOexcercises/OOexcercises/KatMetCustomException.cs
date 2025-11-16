using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class KatMetCustomException:ArgumentException
    {
        public int MeegegevenWaarde
        {
            get
            {
                return MeegegevenWaarde;
            }
            private set
            {
                if (value > 25 )
                {
                    throw new ArgumentException("Deze kat is te oud!");
                }
                else
                {
                    MeegegevenWaarde = value;
                }
            }
        }
        public int HoogstMogelijkeWaarde
        {
            get
            {
                return HoogstMogelijkeWaarde;
            }
            private set
            {
                if (value > 25)
                {
                    throw new ArgumentException("Deze kat is te oud!");
                }
                else
                {
                    HoogstMogelijkeWaarde = value;
                }
            }
        }
        public int LaagstMogelijkeWaarde
        {
            get
            {
                return LaagstMogelijkeWaarde;
            }
            private set
            {
                if (value > 25)
                {
                    throw new ArgumentException("Deze kat is te oud!");
                }
                else
                {
                    LaagstMogelijkeWaarde = value;
                }
            }
        }

        public KatMetCustomException(int meegegevenWaarde,int laagstMogelijkeWaarde,int hoogstMogelijkeWaarde)
        {
            this.MeegegevenWaarde = meegegevenWaarde;
            this.LaagstMogelijkeWaarde = laagstMogelijkeWaarde;
            this.HoogstMogelijkeWaarde = hoogstMogelijkeWaarde;
        }
    }
}
