using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number(45.5m);

            Console.WriteLine("The value of the property Amount for object myNumber is " + myNumber.Amount);
            Console.ReadLine();
        }
    }
}
