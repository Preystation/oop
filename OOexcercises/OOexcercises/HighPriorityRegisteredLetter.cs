using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class HighPriorityRegisteredLetter:RegisteredLetter
    {
        public override byte Duration
        {
            get
            {
                return (byte)Math.Ceiling(Distance / 200);
            }
        }
        private double kostprijs;
        public override double Price
        {

            get
            {
                kostprijs = Math.Max(30, 30 * ((int)Distance / 100));
                return kostprijs;
            }
            set { kostprijs = value; }
        }
    }
}
