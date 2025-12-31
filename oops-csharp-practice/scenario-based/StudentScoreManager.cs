using System;

class StudentScoreManager
{
    static void Main(string[] args)
    {
        int numberOfStudents = GetNumberOfStudents();
        int[] scores = GetStudentScores(numberOfStudents);

        double averageScore = CalculateAverage(scores);
        int highestScore = FindHighest(scores);
        int lowestScore = FindLowest(scores);

        Console.WriteLine("\n--- Results ---");
        Console.WriteLine("Average Score: " + averageScore);
        Console.WriteLine("Highest Score: " + highestScore);
        Console.WriteLine("Lowest Score: " + lowestScore);

        Console.WriteLine("Scores Above Average:");
        DisplayScoresAboveAverage(scores, averageScore);
    }

    // Method to get number of students with validation
    static int GetNumberOfStudents()
    {
        int n;
        Console.Write("Enter number of students: ");

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Invalid input. Enter a positive number: ");
        }
        return n;
    }

    // Method to get student scores
    static int[] GetStudentScores(int n)
    {
        int[] scores = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter score for student " + (i + 1) + ": ");

            while (!int.TryParse(Console.ReadLine(), out scores[i]) || scores[i] < 0)
            {
                Console.Write("Invalid score. Enter a non-negative number: ");
            }
        }
        return scores;
    }

    // Calculate average
    static double CalculateAverage(int[] scores)
    {
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        return (double)sum / scores.Length;
    }

    // Find highest score
    static int FindHighest(int[] scores)
    {
        int highest = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > highest)
                highest = scores[i];
        }
        return highest;
    }

    // Find lowest score
    static int FindLowest(int[] scores)
    {
        int lowest = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] < lowest)
                lowest = scores[i];
        }
        return lowest;
    }

    // Display scores above average
    static void DisplayScoresAboveAverage(int[] scores, double average)
    {
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > average)
            {
                Console.WriteLine(scores[i]);
            }
        }
    }
}
