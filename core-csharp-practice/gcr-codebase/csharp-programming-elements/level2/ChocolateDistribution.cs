using System;

class ChocolateDistribution
{
    static void Main()
    {
        int chocolates, children;

        // Taking inputs
        Console.Write("Enter number of chocolates: ");
        chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        children = Convert.ToInt32(Console.ReadLine());

        // Calculating distribution
        int perChild = chocolates / children;
        int remaining = chocolates % children;

        // Displaying result
        Console.WriteLine("Each child gets " + perChild +" chocolates and remaining chocolates are " + remaining);
    }
}
