
using System;

class FriendsDetails
{
    static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + ": ");
            heights[i] = double.Parse(Console.ReadLine());

            if (ages[i] <= 0 || heights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Enter again.");
                i--;
            }
        }

        int youngestIndex = 0;
        int tallestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;

            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }

        Console.WriteLine("Youngest Friend: " + names[youngestIndex]);
        Console.WriteLine("Tallest Friend: " + names[tallestIndex]);
    }
}
