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
            Employee<string> employee = new Employee<string>() { FirstName = "Sample", LastName = "Student", Id = 90210 };
            employee.SayName();
            string[] traits = new string[] { "Ginger", "Freckles", "Graduate" };
            employee.Things = new List<string>();
            employee.Things.AddRange(traits);
            Console.WriteLine(employee.FirstName + " has the following traits:");
            foreach (string trait in employee.Things)
            {
                Console.WriteLine(trait);
            }
            Console.ReadLine();

            Console.WriteLine("We have hired a new employee!");
            Employee<int> newEmployee = new Employee<int>() { FirstName = "Roger", LastName = "Rabbit", Id = 92929 }; // This employee used to be typed to IQuittable for drill purposes.
            newEmployee.Things = new List<int>();
            int[] testScores = { 98, 67, 99, 85, 85, 43, 100 };
            newEmployee.Things.AddRange(testScores);
            Console.WriteLine("Their test scores are:");
            foreach (int testScore in newEmployee.Things)
            {
                Console.WriteLine(testScore);
            }
            Console.ReadLine();

            Console.WriteLine("Please welcome {0} {1}, employee number {2}!", ((Employee<int>)newEmployee).FirstName, ((Employee<int>)newEmployee).LastName, ((Employee<int>)newEmployee).Id);

            Console.WriteLine("I have a feeling " + ((Employee<int>)newEmployee).FirstName + " is going to quit! Let's watch what happens:");
            newEmployee.Quit();
            Console.ReadLine();

            Console.WriteLine("What if they quit again?:");
            newEmployee.Quit();
            Console.ReadLine();

            Console.WriteLine("Wait, are they the same person?:");
            Console.WriteLine(employee.Id == newEmployee.Id);
            Console.ReadLine();

            Console.WriteLine("Just to confirm that each person matches themselves, does the second employee equal themselves?:");
            Console.WriteLine(newEmployee.Id == newEmployee.Id);
            Console.ReadLine();

        }
    }
}
