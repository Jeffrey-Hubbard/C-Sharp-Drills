using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhile
{
    class Program
    {


        static void Main()
        {
            int raceLength = 25;
            int distanceTraveled = 0;
            bool hasQuit = false;
            bool hasWon = false;



            // Do a boolean comparison using a while statement
            do
            {

                // Do a boolean comparison using a do while statement
                while (!hasWon && !hasQuit)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the racing game! You will control a small car (>) on a short race track.");
                    Console.WriteLine("You can use 'l' and 'r to move along the track, or press 'x' at any time to exit.");

                    DrawRaceLine();
                    DrawCarLine();
                    DrawRaceLine();

                    Console.WriteLine("Race Length: " + raceLength + " | Distance Traveled : " + distanceTraveled);
                    Console.WriteLine("Has Quit: " + hasQuit + " | Has Won: " + hasWon);


                    ConsoleKeyInfo input;
                    input = Console.ReadKey(true);
                    switch (input.Key)
                    {
                        case ConsoleKey.L:
                            if (distanceTraveled > 0) { distanceTraveled -= 1; }
                            break;
                        case ConsoleKey.R:
                            distanceTraveled += 1;
                            break;
                        case ConsoleKey.X:
                            hasQuit = true;
                            break;
                    }




                    if (distanceTraveled >= raceLength)
                    {
                        hasWon = true;
                    }

                }

                if (hasWon)
                {
                    Console.Clear();
                    Console.WriteLine("*** YOU WON!! ***");
                    Console.WriteLine("Press 'x' to exit");
                    Console.ReadKey();
                    hasQuit = true;
                }
                



            } while (!hasQuit);

            void DrawRaceLine()
            {
                for (int i = 0; i < raceLength; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
            }

            void DrawCarLine()
            {
                for (int j = 0; j < distanceTraveled; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(">");
            }

        }



    }


}
