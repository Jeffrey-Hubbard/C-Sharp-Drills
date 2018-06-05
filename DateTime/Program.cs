using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.Write("The current time is: ");
            Console.WriteLine(dateTime);

            try
            {
                Console.WriteLine("User, please give me a number:");
                double userNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("You entered {0}. In {0} hours, the time would be:", userNumber);
                Console.WriteLine((dateTime.AddHours( userNumber)));
                Console.ReadLine();
            }
            catch
            {

            }


        }
    }
}
