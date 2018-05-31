using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public bool ActivelyEmployed = true;
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

    }
}
