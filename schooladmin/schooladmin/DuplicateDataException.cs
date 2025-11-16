using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class DuplicateDataException:ArgumentException
    {
        public System.Object Object1;
        public System.Object Object2;

        public DuplicateDataException(string message,System.Object object1, System.Object object2):base(message)
        {
            this.Object1 = object1;
            this.Object2 = object2;
        }
    }
}
