using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(){ fName = "John", lName = "Smith", Id = 1},
                new Employee(){ fName = "Joe", lName = "Jones", Id = 2},
                new Employee(){ fName = "Jerry", lName = "Smith", Id = 3},
                new Employee(){ fName = "Terry", lName = "Rogers", Id = 5},
                new Employee(){ fName = "Berry", lName = "Dodger", Id = 7},
                new Employee(){ fName = "Joe", lName = "Farmer", Id = 8},
                new Employee(){ fName = "Madelyn", lName = "Bright", Id = 999},
                new Employee(){ fName = "Nancy", lName = "Drew", Id = 101},
                new Employee(){ fName = "Stacie", lName = "West", Id = 4},
                new Employee(){ fName = "Millie", lName = "Carpenter", Id = 50}
            };

            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.fName == "Joe")
                {
                    joeList.Add(employee);
                }
            }

            Console.WriteLine("Using a foreach loop, we find the following Joes:");
            foreach (Employee employee in joeList)
            {
                Console.WriteLine(employee.fName + " " + employee.lName + ", Id number " + employee.Id);
            }
            Console.ReadLine();

            List<Employee> joeListLambda = employees.Where(x => x.fName == "Joe").ToList();
            Console.WriteLine("In one line with a lambda expression, we find the following Joes:");
            foreach (Employee employee in joeListLambda)
            {
                Console.WriteLine(employee.fName + " " + employee.lName + ", Id number " + employee.Id);
            }
            Console.ReadLine();

            List<Employee> idList = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("In one line with a lambda expression, we find the following employees with Id greater than 5:");
            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.fName + " " + employee.lName + ", Id number " + employee.Id);
            }
            Console.ReadLine();

        }
    }
}
