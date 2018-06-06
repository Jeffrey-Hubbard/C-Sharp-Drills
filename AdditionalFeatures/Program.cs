using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the {0} Job Fair! Please enter your name: ", Constants.homeCompanyName);
            string name = Console.ReadLine();
            bool isHomeCompany;
            Console.WriteLine("Are you here representing {0}? Please answer 'yes' or press enter if you are.\nIf you are visiting or representing another company, please enter the company name,\nor enter 'Visitor' if you are just visiting.", Constants.homeCompanyName);
            string companyInput = Console.ReadLine();
            if (companyInput == "yes" || companyInput == "" || companyInput == "y" || companyInput == Constants.homeCompanyName)
            {
                isHomeCompany = true;
            }
            else
            {
                isHomeCompany = false;
            }

            var attendee = isHomeCompany ? new Attendee(name) : new Attendee(name, companyInput);

            Console.WriteLine("Welcome {0}! Please wait while we print your Job Fair badge:", attendee.Name);

            Badge badge = new Badge(attendee.Name, attendee.Company);
            badge.PrintBadge();



            Console.ReadLine();
        }
    }
}
