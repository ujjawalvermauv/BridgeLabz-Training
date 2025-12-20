using System;

class SimpleIntrest
{
    static void Main()
    {
        double p, r, t, si;   // Declaring variables

        // Taking principal amount
        Console.Write("Enter Principal: ");
        p = Convert.ToDouble(Console.ReadLine());

        // Taking rate of interest
        Console.Write("Enter Rate: ");
        r = Convert.ToDouble(Console.ReadLine());

        // Taking time
        Console.Write("Enter Time: ");
        t = Convert.ToDouble(Console.ReadLine());

        // Formula: Simple Interest = (P * R * T) / 100
        si = (p * r * t) / 100;

        // Displaying simple interest
        Console.WriteLine("Simple Interest = " + si);
    }
}
