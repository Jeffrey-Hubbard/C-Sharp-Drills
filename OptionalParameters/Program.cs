using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber;
            //int secondNumber;
            bool getFirstNumber = true;
            bool getSecondNumber = true;
            bool isInt = false;
            string input = null;
            int output;

            GivenNumbers givenNumbers = new GivenNumbers();

            while (getFirstNumber)
            {
                try
                {
                    Console.WriteLine("In this exercise, I will ask you to provide 1 or 2 integers. \nYou must provide the first, but the second is optional.\nIf you do not provide a second integer, I will use the value of 10.\nThen I will multiple the two numbers together and tell you the result.");
                    Console.WriteLine("Please provide the first integer (required):");
                    givenNumbers.firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You entered " + givenNumbers.firstNumber);
                    getFirstNumber = false;
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("You did not follow directions. Your entry was not an integer. Please try again.");
                }
                Console.ReadLine();
            }

            while (getSecondNumber)
            {
                Console.WriteLine("Please provide the second integer (optional):");

                input = Console.ReadLine();
                //Console.WriteLine("input " + input);
                
                getSecondNumber = false;



            }

            isInt = Int32.TryParse(input, out int inputInt);
            givenNumbers.secondNumber = inputInt;



            if (isInt)
            {
                output = givenNumbers.ProcessNumbers(givenNumbers.firstNumber, givenNumbers.secondNumber);
            }
            else
            {
                Console.WriteLine("Your input was not an integer, so I am using the default value of 10.");
                output = givenNumbers.ProcessNumbers(givenNumbers.firstNumber);
            }

            Console.WriteLine("The answer is " + output);
            Console.ReadLine();


        }
    }
}
