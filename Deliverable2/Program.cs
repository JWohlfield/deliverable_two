using System;

namespace Deliverable2
{
    /*
        Author:   Jeffrey Wohlfield
        Date  11-29-2020
        
        This program will prompt user for a decision of "heads" or "tails" and also a number of times
        to flip a coin.
            The program will then perform a coin flip to match the number chosen
            Record the number of correct matches
            Display a percentage of matching flips
    */
    class Program
    {
        static void Main(string[] args)
        {
            string headsOrTailsGuess;
            int numberOfFlips = 0; int correctCount = 0;
            string[] sides = { "heads","tails" };

            //  Get input from user about heads or tails guess
            Console.Write("Guess which will have more: heads or tails? ");
            headsOrTailsGuess = Console.ReadLine();
            int guessIndex = Array.IndexOf(sides, headsOrTailsGuess);

            //  Get input from user of how may times to flip
            Console.Write("How many times shall we flip a coin? ");
            numberOfFlips = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //  Create Random object
            Random rand = new Random();

            for (int i = 0; i < numberOfFlips; i++)
            {
                //  Flip the coin (0 is heads, 1 is tails)
                int toss = rand.Next(2);

                if(toss == guessIndex) correctCount++;
                
                Console.WriteLine(sides[toss]);
            }

            Console.WriteLine("\nYour guess, {0}, came up {1} times", headsOrTailsGuess, correctCount);
            Console.WriteLine(value: "That's " + ((double)correctCount / (double)numberOfFlips).ToString("0.00%"));

        }
    }
}
