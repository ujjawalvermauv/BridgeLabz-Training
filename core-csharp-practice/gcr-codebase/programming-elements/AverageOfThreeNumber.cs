using System;

class Program
{
    static void Main()
    {
        double a, b, c, avg;   // Declaring variables

        // Taking first number
        Console.Write("Enter first number: ");
        a = Convert.ToDouble(Console.ReadLine());

        // Taking second number
        Console.Write("Enter second number: ");
        b = Convert.ToDouble(Console.ReadLine());

        // Taking third number
        Console.Write("Enter third number: ");
        c = Convert.ToDouble(Console.ReadLine());

        // Formula: Average = (a + b + c) / 3
        avg = (a + b + c) / 3;

        // Displaying average
        Console.WriteLine("Average = " + avg);
    }
}
