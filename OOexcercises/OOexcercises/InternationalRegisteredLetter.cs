using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOexcercises
{
    internal class InternationalRegisteredLetter : RegisteredLetter
    {
public override byte Duration
        {
            get
            {
                return (byte)Math.Ceiling(Distance / 50);
            }
        }
        private double kostprijs;
        public override double Price
        {
            get
            {
                kostprijs = Math.Max(20, 20 * ((int)Distance / 100));
                return kostprijs;
            }
            set { kostprijs = value; }
        }
    }
}
