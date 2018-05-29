using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Guess
    {
        public void ProcessGuess(int guess, out int result)
        {
            result = Convert.ToInt32( Math.Pow(Convert.ToDouble(guess), 2.0));
        }

        public void ProcessGuess(decimal guess, out decimal result)
        {
            result = guess * 7;
        }

        public void ProcessGuess(string guess, out int result, out bool parseable)
        {
            parseable = Int32.TryParse(guess, out int parsedGuess);
            result = ( parsedGuess % 2); // This is 0 if it was not parseable, thus why we return parseable as well


        }
    }


}
