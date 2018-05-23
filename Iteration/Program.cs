using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that
            // goes through each string in the Array, adding the user’s text to the string.Then create a loop
            // that prints off each string in the Array on a separate line.

            string[] fnames = { "Jesse", "Ben", "Nick", "Jeff", "Laura", "Stacey", "Emma", "Jennifer" };
            Console.WriteLine("You can make nicknames for people by adding text to their first name.\nEnter some text to see an example:");
            string input = Console.ReadLine();
            for (int i = 0; i < fnames.Length; i++)
            {
                fnames[i] = fnames[i] + input;
            }

            for (int i = 0; i < fnames.Length; i++)
            {
                Console.WriteLine(fnames[i]);
            }

            Console.ReadLine();

            //2.Create an infinite loop.

            //for (int i = 0 ; ; i++ )
            //{
            //    Console.WriteLine("I have been through this loop " + i + " times...");
            //}


            //3.Fix the infinite loop so it will execute.
            for (int i = 0; i < 100 ; i++)
            {
                Console.WriteLine("I have been through this loop " + i + " times...");
            }

            Console.WriteLine("Out of the loop! Press ENTER to continue...");
            Console.ReadLine();

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            for (int i = 0; i < fnames.Length; i++)
            {
                Console.WriteLine("Who is my best friend? Oh wait, it is " + fnames[i] + "!");
            }

            Console.ReadLine();

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            for (int i = 0; i <= 60; i++)
            {
                Console.WriteLine("Look how high I can count! " + i + "!");
            }

            Console.ReadLine();

            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to
            //search for in the List.Create a loop that iterates through the loop and then    displays the
            //index of the array that contains matching text on the screen.
            List<string> animals = new List<string> { "dog", "cat", "hamster", "rat", "mouse", "ferret", "cow", "pig", "sheep", "fish" };

            Console.WriteLine("I have a list of common home and farm animals. Name one, and I will tell you its place in the list.");
            string animalName = Console.ReadLine();
            int index = -1;

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] == animalName)
                {
                    index = i;
                    break;
                }
            }

            //Console.WriteLine(animalName);
            //Console.WriteLine(index);
            //Console.ReadLine();

            if (index >= 0)
            {
                Console.WriteLine("Your animal is at index " + index + ".");
            }
            else
            {
                Console.WriteLine("Your animal was not found in the list.");
            }

            
            Console.ReadLine();

            //These are complete in the above animal list code.
            //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //8. Add code to that above loop that stops it from executing once a match has been found.

            //9.Create a List of strings that has at least two identical strings in the List. Ask the user 
            //to select text to search for in the List.Create a loop that iterates through the    loop and 
            //then displays the indices of the array that contain matching text on the screen.
            List<string> books = new List<string> { "War and Peace", "Love in a Time of Cholera", "The Unfathomable Lightness of Being", "Ender's Game", "Moral Discourse and Practice", "Just After Sunset", "Neuromancer", "Moral Discourse and Practice" };

            Console.WriteLine("I've made a list of books on my shelf. Enter some text, and I will search the list and tell you at what indices there is matching text in the title");
            string searchText = Console.ReadLine();
            List<int> matchList = new List<int> { };
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Contains(searchText))
                {
                matchList.Add(i);
                }

            }

            if (matchList.Count > 0)
            {
                Console.WriteLine("Matches to your search text \"" + searchText + "\" were found at:");
                foreach (int match in matchList)
                {
                    Console.WriteLine("Match at index: " + match);
                }
            }
            else
            {
                //10.. Add code to that above loop that tells a user if they put in text that isn’t in the List.
                Console.WriteLine("I did not find any results for your search text.");
            }

            Console.ReadLine();

            //11.Create a List of strings that has at least two identical strings in the List. Create a 
            //foreach loop that evaluates each item in the list, and displays a message showing the    
            //string and whether or not it has already appeared in the list.

            Console.WriteLine("Now I will look through those books, because there might be duplicates. When a book appears for a second time, I will flag it.");

            List<string> checkedBooks = new List<string> { };

            foreach (string book in books)
            {
                if (checkedBooks.Contains(book))
                {
                    Console.WriteLine(book + " : This book is a duplicate!");
                }
                else
                {
                    Console.WriteLine(book);
                }
                checkedBooks.Add(book);
            }

            Console.ReadLine();










            // Tutorial text below, not part of the drill
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 94 };

                //for (int i=0; i<testScores.Length; i++)
                //{
                //    if (testScores[i] > 85 )
                //    {
                //        Console.WriteLine("Passing test score: " + testScores[i]);
                //    }
                //}

                //Console.ReadLine();

        }
    }
}
