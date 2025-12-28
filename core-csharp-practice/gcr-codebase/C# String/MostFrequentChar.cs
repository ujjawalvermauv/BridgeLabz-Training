using System;

class MostFrequentChar
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        char maxChar = input[0];
        int maxCount = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if (input[i] == input[j])
                    count++;
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxChar = input[i];
            }
        }

        Console.WriteLine("Most Frequent Character: " + maxChar);
    }
}
