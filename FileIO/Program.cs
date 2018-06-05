using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please give me a number, so I can practice writing it to a file.");
            string userNumber = Console.ReadLine();
            bool isNumber = Int32.TryParse(userNumber, out int result);
            if (!isNumber)
            {
                Console.WriteLine("That... that isn't a number. But you know what? I will save it anyway, because I'm such a nice guy.");
            }

            Console.WriteLine("I will now save your input, {0}, to a text file on your Desktop.\nPress Enter to continue...", userNumber);
            Console.ReadLine();
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"MyDrillText.txt");
            File.WriteAllText(filePath, userNumber);
            Console.WriteLine("Check your Desktop and confirm the file has been written, but don't delete it yet!");
            Console.WriteLine("You can change the content and save if you want to test me!\nPress Enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Now, without referencing your input before, I will read the number from the file.");
            string newUserNumber = File.ReadAllText(filePath);
            Console.WriteLine("\nYour file says:");
            Console.WriteLine(newUserNumber);
            Console.ReadLine();

            Console.WriteLine("For your convenience, we will now delete that file for you.");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            if (!File.Exists(filePath))
            {
                Console.WriteLine("The file has been deleted. Have a nice day!");
            }
            else
            {
                Console.WriteLine("I was unable to delete the file. Please check and delete it manually. Sorry!");
            }
            Console.ReadLine();
        }
    }
}
