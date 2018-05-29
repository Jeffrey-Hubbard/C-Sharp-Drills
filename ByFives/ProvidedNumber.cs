using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByFives
{
    class ProvidedNumber
    {
        public int value;

        public int MultiplyByFive()
        {
            return value * 5;
        }

        public int ExponentFive()
        {
            return Convert.ToInt32( Math.Pow( Convert.ToDouble(value), Convert.ToDouble(5)));
        }

        public int AddFive()
        {
            return value + 5;
        }
    }
}
