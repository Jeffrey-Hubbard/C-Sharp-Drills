using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputsAndOverloads
{
    class NumberDivider
    {
        public void DivideByTwo(int firstNumber, out int quotient)
        {
            quotient = firstNumber / 2;
        }


    }
}
