using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class NumberProcessor
    {
        public void Process(int firstNumber, int secondNumber)
        {
            int answer = firstNumber * 11;
            Console.WriteLine("The second number entered was " + secondNumber);
        }
    }
}
