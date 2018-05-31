using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person, IQuittable //where T : IComparable<T> [<T>]
    {
        public int Id { get; set; }
        public bool ActivelyEmployed = true;
        //public List<T> Things { get; set; }


        public void Quit()
        {
            if (ActivelyEmployed)
            {
                Console.WriteLine("** SYSTEM WARNING ** : EMPLOYEE " + Id + " HAS QUIT.");
                ActivelyEmployed = false;
            }
            else
            {
                Console.WriteLine("ERROR: EMPLOYEE " + Id + " HAS ATTEMPTED TO QUIT, BUT IS ALREADY NOT ACTIVELY EMPLOYED!");
            }


        }



        public static bool operator ==(Employee firstEmployee, Employee secondEmployee)
        {
            Console.WriteLine("Override method called");
            Console.WriteLine("First: " + firstEmployee.Id + " Second: " + secondEmployee.Id);
            if (firstEmployee.Id == secondEmployee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.Id == secondEmployee.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
