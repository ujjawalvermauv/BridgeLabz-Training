using System;

class NumberGuessingGame
{
    static void Main(string[] args)
    {
        int lowerBound = 1;
        int upperBound = 100;
        string feedback;

        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("Enter feedback: high, low, or correct");

        while (true)
        {
            int guess = GenerateGuess(lowerBound, upperBound);
            Console.WriteLine("Computer guesses: " + guess);

            feedback = GetFeedback();

            if (feedback == "correct")
            {
                Console.WriteLine("Computer guessed correctly!");
                break;
            }
            else if (feedback == "high")
            {
                upperBound = guess - 1;
            }
            else if (feedback == "low")
            {
                lowerBound = guess + 1;
            }
        }
    }

    static int GenerateGuess(int min, int max)
    {
        return (min + max) / 2;
    }

    static string GetFeedback()
    {
        Console.Write("Your feedback: ");
        return Console.ReadLine().ToLower();
    }
}

