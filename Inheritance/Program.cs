using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 90210 };
            employee.SayName();
            Console.ReadLine();

            Console.WriteLine("I have a feeling " + employee.FirstName + " is going to quit! Let's watch what happens:");
            employee.Quit();
            Console.ReadLine();

            Console.WriteLine("What if they quit again?:");
            employee.Quit();
            Console.ReadLine();
        }
    }
}
