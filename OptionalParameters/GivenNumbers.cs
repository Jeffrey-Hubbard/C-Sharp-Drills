using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class GivenNumbers
    {
        public int firstNumber;
        public int secondNumber;

        public int ProcessNumbers(int firstNumber, int secondNumber = 10)
        {
            return firstNumber * secondNumber;
        }
    }
}
