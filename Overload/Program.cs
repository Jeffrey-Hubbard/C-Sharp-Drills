using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retryOne = true;
            bool retryTwo = true;
            bool retryThree = true;

            Console.WriteLine("In this program, we will test a single Class to watch it use overloaded parameters (one method name) to handle three types of input.");

            while (retryOne)
            {
                string input;
                Console.WriteLine("First, give me an integer, and I will square it.");
                input = Console.ReadLine();
                bool testInput = Int32.TryParse(input, out int parsedInput);
                if (testInput)
                {
                    Guess firstGuess = new Guess();
                    firstGuess.ProcessGuess(parsedInput, out int result);
                    Console.WriteLine("Your integer " + parsedInput + " squared is " + result);
                    Console.ReadLine();
                    retryOne = false;
                    
                }
                else
                {
                    Console.WriteLine("I asked for an integer, please. Try again!");
                    Console.ReadLine();
                }


            }

            while (retryTwo)
            {
                string input;
                Console.WriteLine("Second, give me a decimal, and I will multiply it by 7.");
                input = Console.ReadLine();
                bool testInput = Decimal.TryParse(input, out decimal parsedInput);
                if (testInput)
                {
                    Guess secondGuess = new Guess();
                    secondGuess.ProcessGuess(parsedInput, out decimal result);
                    Console.WriteLine("Your decimal " + parsedInput + " multiplied by 7 is " + result);
                    Console.ReadLine();
                    retryTwo = false;

                }
                else
                {
                    Console.WriteLine("I asked for a decimal, please. Try again!");
                    Console.ReadLine();
                }


            }

            while (retryThree)
            {
                string input;
                Console.WriteLine("Third, enter a string. If it can be converted to an integer, I will tell you the remainder after I have divided that number by 2.");
                input = Console.ReadLine();
                Guess thirdGuess = new Guess();
                thirdGuess.ProcessGuess(input, out int result, out bool parseable);
                if (parseable)
                {
                    Console.WriteLine("Your string input, divided by two, leaves a remainder of " + result);
                    Console.ReadLine();
                    retryThree = false;
                }
                else
                {
                    Console.WriteLine("Your input string was not able to be parsed into an integer. Please try again.");
                }

            }

        }
    }
}
