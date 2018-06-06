using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool birthYearGuessed = false;

            while (!birthYearGuessed)
            {
                try
                {
                    Console.WriteLine("Hello there! Would you please tell me your age?");
                    int userAge = Convert.ToInt32(Console.ReadLine());
                    // Constraints on userAge input
                    // Age cannot be a negative number
                    if (userAge <= 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    // Output requested is the user's birth year, but with only the age input
                    // that is not possible to calculate. Therefore, state the range relative
                    // to today's date in the latest birth year and the year prior to that.
                    DateTime userLatestBirthYear = DateTime.Now.AddYears(-userAge);
                    Console.WriteLine("You were either born before today's date in {0} or after today's date in {1}.", userLatestBirthYear.Year, userLatestBirthYear.AddYears(-1).Year);
                    Console.ReadLine();
                    birthYearGuessed = true;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Your age must be a positive whole number, greater than zero.");
                    Console.ReadLine();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter a number, with no decimal, for your age.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}
