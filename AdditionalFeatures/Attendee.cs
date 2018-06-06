using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Attendee
    {
        public Attendee(string name) : this(name, Constants.homeCompanyName)
        {
        }
        public Attendee (string name, string company)
        {
            Name = name;
            Company = company;
        }

        public string Name;
        public string Company;


    }
}
