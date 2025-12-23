using System;

class SumUntilZero
{
    static void Main(string[] args)
    {
        double total = 0.0;
        double value = double.Parse(Console.ReadLine());

        while (value != 0)
        {
            total = total + value;
            value = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Total is " + total);
    }
}
