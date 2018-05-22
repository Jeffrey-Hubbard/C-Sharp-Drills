using System;

namespace Drills_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string programName = "Jeff";
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();

            // use if statement to reply to boolean state comparison of name to programName
            if (name != programName)
            {
                Console.WriteLine("Your name is different than mine, my name is " + programName + "! That is terribly convenient.");
            }

            Random random = new Random();
            int programFavNum = random.Next(0, 100);
            Console.WriteLine("I'm curious, what is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            // use if-else statement to reply to boolean statement
            if (favNum == programFavNum)
            {
                Console.WriteLine("What do you know! We have the same favorite number, " + favNum + "!");
            }
            else if (favNum > programFavNum)
            {
                Console.WriteLine("Oh my! Your favorite number is larger than my favorite number, " + programFavNum + "!");
            }
            else
            {
                Console.WriteLine("Haha! My favorite number, " + programFavNum + ", is bigger than yours!");
            }


            string[] colors = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            string programFavColor = colors[random.Next(0, colors.Length)];
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();

            // use ternery statement to reply to boolean state
            string response = (favColor == programFavColor) ? "That's my favorite color too!" : "Eww, I like " + programFavColor + " much better.";
            Console.WriteLine(response);
            Console.ReadLine();
            
            









        }
    }
}
