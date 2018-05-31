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

            Console.WriteLine("We have hired a new employee!");
            IQuittable newEmployee = new Employee() { FirstName = "Roger", LastName = "Rabbit", Id = 92929 };
            Console.WriteLine("Please welcome {0} {1}, employee number {2}!", ((Employee)newEmployee).FirstName, ((Employee)newEmployee).LastName, ((Employee)newEmployee).Id);

            Console.WriteLine("I have a feeling " + ((Employee)newEmployee).FirstName + " is going to quit! Let's watch what happens:");
            newEmployee.Quit();
            Console.ReadLine();

            Console.WriteLine("What if they quit again?:");
            newEmployee.Quit();
            Console.ReadLine();

            Console.WriteLine("Wait, are they the same person?:");
            Console.WriteLine(employee == newEmployee);
            Console.ReadLine();

            Console.WriteLine("Just to confirm that each person matches themselves, does the second employee equal themselves?:");
            Console.WriteLine(newEmployee == newEmployee);
            Console.ReadLine();

        }
    }
}
