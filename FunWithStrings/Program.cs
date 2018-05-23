using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "Hello, my name is ";
            string stringTwo = "Jeff";
            string stringThree = "It is very nice to meet you.";


            Console.WriteLine("Say we have three strings:");
            Console.WriteLine(stringOne);
            Console.WriteLine(stringTwo);
            Console.WriteLine(stringThree);

            Console.WriteLine("Concatenate them together (with a little extra punctuation) and you get:");
            Console.WriteLine(stringOne + stringTwo + ". " + stringThree);
            Console.ReadLine();

            Console.WriteLine("We can easily convert a string to UPPERCASE. \"Jeff\" would become: ");
            Console.WriteLine(stringTwo.ToUpper());
            Console.ReadLine();

            Console.WriteLine("We can use StringBuilder to create strings that are not immutable, that we can change and alter without creating more strings in memory space:");

            StringBuilder sb = new StringBuilder();
            sb.Append("This is very valuable when we have a lot of data, or we are combining data from multiple sources. ");
            sb.Append("We should not forget we can control if text shows on a \nNew Line\n or if it is\n\tIndented. ");
            sb.Append("Just because console text is basic doesn't mean it isn't useful. Many programs do not need much of a user interface. ");
            sb.Append("This is especially true for automation programs and things that run 'in the background' that do not need regular user interaction ");
            sb.Append("A console interface is easy enough to implement, and a developer can use it to interface with the programmer, even if an average user could not.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
