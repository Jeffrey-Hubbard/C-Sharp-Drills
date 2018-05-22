using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drills
{
    class Program
    {
        static void Main()
        {
            // Multiply user input by 50 and display
            Console.WriteLine("Give me a number, and I will multiply it by 50:");
            double firstInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your number, " + firstInput + ", multiplied by 50 is " + firstInput * 50 + ".");
            Console.ReadLine();

            // Add user input to 25 and display
            Console.WriteLine("Give me a number, and I will add 25 to it:");
            double secondInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your number, " + secondInput + ", with 25 added to it is " + (secondInput + 25) + ".");
            Console.ReadLine();

            // Divide user input by 12.5 and display
            Console.WriteLine("Give me a number, and I will divide it by 12.5:");
            double thirdInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your number, " + thirdInput + ", divided by 12.5 is " + thirdInput / 12.5 + ".");
            Console.ReadLine();

            // Is input greater than 50? Answer True/False
            Console.WriteLine("Give me a number, and I will let you know if it is greater than 50:");
            double fourthInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("It is " + (fourthInput > 50) + " that your number, " + fourthInput + ", is greater than 50.");
            Console.ReadLine();

            // Take input, divide it by 7, and print the remainder to the console
            Console.WriteLine("Give me a number, I will divide it by 7 and only tell you the remainder:");
            double fifthInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("When I divide your number, " + fifthInput + ", by 7, the remainder is " + (fifthInput % 7) + ".");
            Console.ReadLine();

            Console.WriteLine("Part Two: Here, we will evaluate and answer three True or False questions.");
            Console.WriteLine("1. Is it True or False that 3 is greater than 2 AND 5 is greater than 4?");
            Console.WriteLine("Press any button to see the answer...");
            Console.ReadLine();

            bool firstBool = 3 > 2 && 5 > 4;
            Console.WriteLine(firstBool);

            Console.WriteLine("2. Is it True or False that 3 is greater than 2 OR 5 is greater than 4?");
            Console.WriteLine("Press any button to see the answer...");
            Console.ReadLine();

            bool secondBool = 3 > 2 || 5 > 4;
            Console.WriteLine(secondBool);

            Console.WriteLine("3. Is it True or False that 2 plus 2 DOES NOT EQUAL 4?");
            Console.WriteLine("Press any button to see the answer...");
            Console.ReadLine();

            bool thirdBool = (2 + 2) != 4;
            Console.WriteLine(thirdBool);

            Console.WriteLine("Thank you for your time! Press any key to close this program.");
            Console.ReadLine();
        }

        
    }
}
