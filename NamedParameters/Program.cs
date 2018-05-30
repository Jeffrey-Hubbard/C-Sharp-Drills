using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberProcessor numberProcessor = new NumberProcessor();

            int firstNumber = 45;
            int secondNumber = 99;

            Console.WriteLine("First I will pass 45 and 99 to the method, which should result in the number 99 being displayed below:");

            numberProcessor.Process(firstNumber, secondNumber);
            Console.ReadLine();

            Console.WriteLine("Now I will pass the same numbers, as named parameters, in the opposite order. This should also result in the number 99 being displayed below:");

            numberProcessor.Process(secondNumber: secondNumber, firstNumber: firstNumber);
            Console.ReadLine();


        }
    }
}
