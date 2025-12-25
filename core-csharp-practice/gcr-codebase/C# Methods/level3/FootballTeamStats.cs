using System;

class FootballTeamStats
{
    public int FindSum(int[] heights)
    {
        int totalSum = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            totalSum += heights[i];
        }
        return totalSum;
    }
    public double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }
    public int FindShortest(int[] heights)
    {
        int min = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < min)
            {
                min = heights[i];
            }
        }
        return min;
    }
    public int FindTallest(int[] heights)
    {
        int max = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > max)
            {
                max = heights[i];
            }
        }
        return max;
    }

    static void Main()
    {
        FootballTeamStats stats = new FootballTeamStats();
        Random rand = new Random();
        int[] heights = new int[11];
        Console.WriteLine("Generating heights for 11 players:");
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = rand.Next(150, 251); 
            Console.Write(heights[i] + " ");
        }
        Console.WriteLine("\n");
        Console.WriteLine("Shortest Height: " + stats.FindShortest(heights) + " cms");
        Console.WriteLine("Tallest Height: " + stats.FindTallest(heights) + " cms");
        Console.WriteLine("Mean Height: " + Math.Round(stats.FindMean(heights), 2) + " cms");
    }
}