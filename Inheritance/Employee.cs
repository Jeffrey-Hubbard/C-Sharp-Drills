using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee<T> : Person, IQuittable where T : IComparable<T>
    {
        public int Id { get; set; }
        public bool ActivelyEmployed = true;
        public List<T> Things { get; set; }


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

        // The below code was used for a previous drill that specified checking the id property to 
        // compare two employee objects, however, comparisons of objects with generic type
        // parameters instantiated with different parameters cannot be done, so this code 
        // no longer works. Instead, the main program just gets the id property from the employee and uses
        // standard int == comparison.

        //public static bool operator ==(Employee<T> firstEmployee, Employee<T> secondEmployee)
        //{
        //    if (firstEmployee.Id == secondEmployee.Id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static bool operator !=(Employee<T> firstEmployee, Employee<T> secondEmployee)
        //{
        //    if (firstEmployee.Id == secondEmployee.Id)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

    }
}
