using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class RegisteredLetter
    {
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                if(value > 0)
                {
                    distance = value;
                }
            }
        }
        private double distance;
        public virtual byte Duration
        {
            get
            {
                double timeTravel = Math.Ceiling(Distance/ 100);



                return duration;
            }
        }
        private byte duration;
        
   
    public virtual double Price
        {
            get
            {
                price = 15 + (10 * Distance / 100);
                return price;
            }
            set
            {
                price = value;
            }
        }
        private double price;
}
}