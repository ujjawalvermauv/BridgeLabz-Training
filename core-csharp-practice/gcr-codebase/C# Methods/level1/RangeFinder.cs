using System;

class RangeFinder
{
    public int[] FindSmallestAndLargest(int n1, int n2, int n3)
    {
        int min = Math.Min(n1, Math.Min(n2, n3));
        int max = Math.Max(n1, Math.Max(n2, n3));
        return new int[] { min, max };
    }

    static void Main()
    {
        RangeFinder finder = new RangeFinder();
        int[] results = finder.FindSmallestAndLargest(10, 5, 20);
        Console.WriteLine("Smallest: " + results[0] + ", Largest: " + results[1]);
    }
}