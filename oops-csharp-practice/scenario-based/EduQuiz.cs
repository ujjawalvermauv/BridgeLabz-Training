using System;

class EduQuiz
{
    // Method to calculate score
    static int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;
        for (int i = 0; i < correct.Length; i++)
        {
            if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }

        return score;
    }

    static void Main(string[] args)
    {
        // Correct answers
        string[] correctAnswers = { "A", "B", "C", "D", "A", "C", "B", "D", "A", "C" };
        // Student answers
        string[] studentAnswers = { "a", "B", "c", "A", "A", "C", "b", "D", "a", "b" };
        Console.WriteLine("📘 Quiz Result:\n");
        // Print detailed feedback
        for (int i = 0; i < correctAnswers.Length; i++)
        {
            if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Question " + (i + 1) + ": Correct");
            }
            else
            {
                Console.WriteLine("Question " + (i + 1) + ": Incorrect");
            }
        }

        // Calculate score
        int score = CalculateScore(correctAnswers, studentAnswers);
        // Calculate percentage
        double percentage = (score * 100.0) / correctAnswers.Length;
        Console.WriteLine("Total Score: " + score + " / " + correctAnswers.Length);
        Console.WriteLine("Percentage: " + percentage + "%");

        // Pass / Fail
        if (percentage >= 40)
        {
            Console.WriteLine("Result: PASS ");
        }
        else
        {
            Console.WriteLine("Result: FAIL ");
        }
    }
}
