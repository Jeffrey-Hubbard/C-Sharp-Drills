using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // Added to use the TextInfo to force title casing on input

namespace DaysOfTheWeek
{
    class Program
    {
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello there! Can you tell me what day of the week it is?");
                string dayString = Console.ReadLine();

                // Input may be of wrong case, so let's control for that by forcing
                // title casing. Won't catch all caps entry, but will help any mixed case

                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                dayString = textInfo.ToTitleCase(dayString);

                Day dayName = (Day)Enum.Parse(typeof(Day), dayString); 
                if (Int32.TryParse(dayString, out int result))
                {
                    throw new System.ArgumentException("Invalid input type (int).");
                }
                else
                {
                    Console.WriteLine("Very good! Yes, that is a day of the week.");
                }

            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week. Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
