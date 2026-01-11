using System;

class SelectionSortExamScores
{
    static void Main()
    {
        int[] scores = { 56, 89, 45, 72, 60 };

        for (int i = 0; i < scores.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < scores.Length; j++)
            {
                if (scores[j] < scores[minIndex])
                    minIndex = j;
            }

            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }

        Console.WriteLine("Sorted Exam Scores:");
        foreach (int s in scores)
            Console.Write(s + " ");
    }
}
