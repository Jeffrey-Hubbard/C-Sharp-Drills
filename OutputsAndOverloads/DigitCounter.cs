using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputsAndOverloads
{
    static class DigitCounter
    {
        public static void CountDigits(int inputInt, out int totalCount)
        {
            totalCount = 0;
            while (inputInt != 0 )
            {
                totalCount += inputInt % 10;
                inputInt /= 10;
            }
        }

        public static void CountDigits(string inputString, out int totalCount)
        {
            totalCount = inputString.Length;
        }
    }
}
