using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            while (true)
            {
                try
                {
                    Console.WriteLine("I have a list of numbers in my head. Give me a number, and I will divide each of my numbers by yours, and tell you what results:");
                    double userNumber = Convert.ToDouble(Console.ReadLine());
                    if (userNumber == 0)
                    {
                        Console.WriteLine("You are tricky, trying to get me to divide by zero. I shall not fall for that trick!");
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("Very well, I shall try to divide each number of mine by " + userNumber);

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            double result = numbers[i] / userNumber;
                            Console.WriteLine("If I divide " + numbers[i] + " by " + userNumber + ", I get: " + result);
                        }
                    }
                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + " : Please enter a number as an int or double.");
                }
                finally
                {
                    Console.WriteLine("\nPress ENTER to continue...");
                    Console.ReadLine();
                }
                Console.WriteLine("Program has exited from the try/catch loop.");
                Console.ReadLine();


                // Results when I run with the input 5 before any exception handling
                //I have a list of numbers in my head. Give me a number, and I will divide each of my numbers by yours, and tell you what results:
                //5
                //Very well, I shall try to divide each number of mine by 5
                //If I divide 1 by 5, I get: 0.2
                //If I divide 1 by 5, I get: 0.2
                //If I divide 2 by 5, I get: 0.4
                //If I divide 3 by 5, I get: 0.6
                //If I divide 5 by 5, I get: 1
                //If I divide 8 by 5, I get: 1.6
                //If I divide 13 by 5, I get: 2.6
                //If I divide 21 by 5, I get: 4.2
                //If I divide 34 by 5, I get: 6.8
                //If I divide 55 by 5, I get: 11
                //If I divide 89 by 5, I get: 17.8
                //If I divide 144 by 5, I get: 28.8

                //When I try to divide by 0, I get an interesting result:
                //I have a list of numbers in my head. Give me a number, and I will divide each of my numbers by yours, and tell you what results:
                //0
                //Very well, I shall try to divide each number of mine by 0
                //If I divide 1 by 0, I get: ∞
                //If I divide 1 by 0, I get: ∞
                //If I divide 2 by 0, I get: ∞
                //If I divide 3 by 0, I get: ∞
                //If I divide 5 by 0, I get: ∞
                //If I divide 8 by 0, I get: ∞
                //If I divide 13 by 0, I get: ∞
                //If I divide 21 by 0, I get: ∞
                //If I divide 34 by 0, I get: ∞
                //If I divide 55 by 0, I get: ∞
                //If I divide 89 by 0, I get: ∞
                //If I divide 144 by 0, I get: ∞

                // This happens because I'm using double for the user input, in case they enter a
                // number that is not a whole number. The spec for the program says the list should 
                // be integers, butthat the input only must be a number. Doubles, while more precise 
                // than a float (at 64 bits) are still subject to imprecision past that point.
                // Doubles represent that infinity symbol as a very small number, like .0000000 (many zeroes) ..1
                // rather than throwing a divide by zero error.
                // Leaving aside academics on inifinity as a math construct, we will focus on how
                // it is not useful in this context, and instead add a check after the user input
                // If we were not using double, we would have received a System.DivideByZero exception
                // that we would have in a caught block just like the FormatException below.

                // Attempting to divide by a string does yield an error:
                // An unhandled exception of type 'System.FormatException' occurred in mscorlib.dll
                // Input string was not in a correct format.
                // So we will handle that in a try/catch

                // Program informs on exit the try/catch loop, handles numbers, strings, and 0, displaying
                // proper messages on the screen.




            }



















            // The below code is from the tutorial and not part of the program:
            //try
            //{
            //    Console.WriteLine("Pick a number:");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick another number:");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine("First divided by the second is: " + numberThree);
            //    //Console.ReadLine();
            //}

            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message + " : Please type a whole number.");
            //}
            //catch (System.DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message + " : Please don't divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}


        }
    }
}
