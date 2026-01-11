using System;

class BubbleSortStudentMarks
{
    static void Main()
    {
        int[] marks = { 78, 45, 89, 60, 72 };

        for (int i = 0; i < marks.Length - 1; i++) // Outer loop for passes
        {
            for (int j = 0; j < marks.Length - 1 - i; j++) // Inner loop for comparisons
            {
                if (marks[j] > marks[j + 1]) // Swap if out of order
                {
                    int temp = marks[j]; // Swap marks[j] and marks[j + 1]
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Student Marks:");
        foreach (int m in marks)
        {
            Console.Write(m + " ");
        }
    }
}
