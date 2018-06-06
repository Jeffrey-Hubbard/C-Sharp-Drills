using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Badge
    {
        public Badge(string name) : this(name, Constants.homeCompanyName)
        {
        }
        public Badge(string name, string company)
        {
            Name = name;
            Company = company;
        }

        public string Name;
        public string Company;

        public void PrintBadge()
        {
            int badgeWidth = 12 + Math.Max(Name.Length, Company.Length);
            PrintTopBottom(badgeWidth);
            PrintSpacerLine(badgeWidth);
            PrintBadgeText(Name, badgeWidth);
            PrintSpacerLine(badgeWidth);
            PrintBadgeText(Company, badgeWidth);
            PrintSpacerLine(badgeWidth);
            PrintTopBottom(badgeWidth);
        }

        public void PrintTopBottom(int badgeWidth)
        {
            for (int i = 0; i < badgeWidth; i++)
            {
                Console.Write("=");
            }
        }

        public void PrintSpacerLine(int badgeWidth)
        {
            Console.Write("\n||");
            for (int i = 4; i < badgeWidth; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("||");
        }

        public void PrintBadgeText(string text, int badgeWidth)
        {
            Console.Write("\n||");
            for (int i = 2; i < (badgeWidth - text.Length) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(text);
            for (int i = 2; i < (badgeWidth - text.Length - ((badgeWidth - text.Length) / 2)); i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("||");
        }

    }
}
