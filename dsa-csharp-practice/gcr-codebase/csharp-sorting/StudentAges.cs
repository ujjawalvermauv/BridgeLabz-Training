using System;

class CountingSortStudentAges
{
    static void Main()
    {
        int[] ages = { 12, 15, 10, 14, 12, 18, 16 };
        int min = 10;
        int max = 18;
        int[] count = new int[max - min + 1];
        for (int i = 0; i < ages.Length; i++)
            count[ages[i] - min]++;

        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            while (count[i] > 0)
            {
                ages[index++] = i + min;
                count[i]--;
            }
        }

        Console.WriteLine("Sorted Student Ages:");
        foreach (int a in ages)
            Console.Write(a + " ");
    }
}
