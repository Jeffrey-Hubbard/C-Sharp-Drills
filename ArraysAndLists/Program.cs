using System;
using System.Collections.Generic;


class Program
{


    static void Main()
    {
        bool exit = false;
        int gamePhase = 1;
       
        string question = "";
        string answer = "";

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Arbitrary Index Game!");
            Console.WriteLine("Enter your 'guess' as an integer, or enter 'n' to go to the next part, or 'x' to quit.");
            if (gamePhase < 4)
            {
                question = AskQuestion(gamePhase);
                Console.WriteLine(question);
            }
            else
            {
                exit = true;
            }

            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            int guess;
            if (char.IsDigit(input.KeyChar)) {
                guess = int.Parse(input.KeyChar.ToString());
                answer = GetAnswer(gamePhase, guess);
                Console.WriteLine("\nThe answer is: " + answer + "\n\n");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
            }
            else
            {
                switch (input.Key)
                {
                    case ConsoleKey.N:
                        gamePhase = gamePhase + 1;
                        break;
                    case ConsoleKey.X:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("You entered an invalid answer. Press Enter to try again:");
                        Console.ReadLine();
                        break;
                }
            }
            


        }



        //Comments below are from following along during tutorial, not part of program.
        //List<int> intList = new List<int>();

        //intList.Add(5);
        //intList.Add(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //numArray2[4] = 650;

        //Console.WriteLine(numArray2[4]);
        //Console.ReadLine();
    }

    private static string AskQuestion(int gamePhase)
    {
        int phase = gamePhase;
        string askQuestion = "";
        switch (phase)
        {
            case 1:
                askQuestion = "\n\nThe band \"The Beatles\" had four members. Enter an integer value to select one.";
                break;
            case 2:
                askQuestion = "\n\n\"The Beatles\" released five live albums. Enter an integer to find out one year that they released an album.";
                break;
            case 3:
                askQuestion = "\n\nEnter an index 0-9 to find out the name of a top 10 Billboard chart song by The Beatles.";
                break;
            default:
                Console.WriteLine("\n\nSometing went wrong.");
                break;
        }
        return askQuestion;
    }

    private static string GetAnswer(int gamePhase, int guess)
    {
        int phase = gamePhase;
        int playerGuess = guess;
        string giveAnswer = "";

        string[] beatles = { "John Lennon", "Paul McCartney", "George Harrison", "Ringo Starr" };
        int[] albumYears = { 1977, 1977, 1979, 1994, 2013 };
        string[] albumNames = { "All You Need Is Love", "Yesterday", "Ticket To Ride", "Hello Goodbye", "I Feel Fine", "The Long And Winding Road/For You Blue", "Penny Lane", "Paperback Writer", "Eight Days A Week", "Can't Buy Me Love"};

        switch (phase)
        {
            case 1:
                if (playerGuess >= beatles.Length)
                {
                    giveAnswer = "Invalid input, please try again. Press Enter to continue.";
                }
                else
                {
                    giveAnswer = beatles[playerGuess];
                }
                
                break;
            case 2:
                if (playerGuess >= albumYears.Length)
                {
                    giveAnswer = "Invalid input, please try again. Press Enter to continue.";
                }
                else
                {
                    giveAnswer = Convert.ToString(albumYears[playerGuess]);
                }
                
                break;
            case 3:
                if (playerGuess >= albumNames.Length)
                {
                    giveAnswer = "Invalid input, please try again. Press Enter to continue.";
                }
                else
                {
                    giveAnswer = albumNames[playerGuess];
                }
                break;
            default:
                Console.WriteLine("Someting went wrong.");
                break;
        }
        return giveAnswer;
    }
}
