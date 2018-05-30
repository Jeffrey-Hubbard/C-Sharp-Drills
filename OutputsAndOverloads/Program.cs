using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputsAndOverloads
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberDivider numberDivider = new NumberDivider();

            try
            {
                Console.WriteLine("Give me an integer, and I will divide it by two for you:");
                int input = Convert.ToInt32(Console.ReadLine());
                numberDivider.DivideByTwo(input, out int output);
                Console.WriteLine("Your number divided by two is " + output);
                Console.ReadLine();
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(ex.Message + " : You have failed to follow directions. This program will terminate.");
                Console.ReadLine();
            }

            Console.WriteLine("Actually, one more thing. Give me either an integer or a string. \nIf it is an integer, I will add all the digits of the integer together. \nIf it is a string, I will tell you how long the string is.");
            string newInput = Console.ReadLine();

            if (Int32.TryParse(newInput, out int result))
            {
                int inputInt = Convert.ToInt32(newInput);
                DigitCounter.CountDigits(inputInt, out int totalCount);
                Console.WriteLine("Your input was an integer, and when I add each digit together, I get: " + totalCount);
            }
            else
            {
                DigitCounter.CountDigits(newInput, out int totalCount);
                Console.WriteLine("Your input was interpreted as a string, which contained " + totalCount + " characters.");
            }
            Console.ReadLine();
        }
    }
}
