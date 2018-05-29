using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByFives
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;

            while (tryAgain)
            {
                Console.WriteLine("Please provide me an integer, and I will perform 3 math operations upon it and tell you the results:");
                ProvidedNumber number = new ProvidedNumber();
                try
                {
                    number.value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("If I take your number and I multiply it by 5, I get " + number.MultiplyByFive());
                    Console.WriteLine("If I take your number and raise it to the fifth power, I get " + number.ExponentFive());
                    Console.WriteLine("If I take your number and add 5 to it, I get " + number.AddFive());
                    tryAgain = false;

                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("Only provide me with integers, please! Error: " + ex.Message);
                }
                Console.ReadLine();
            }

        }
    }
}
