using System;

class PowerCalculation
{
    static void Main()
    {
        double baseNum, exponent, result;   // Declaring variables

        // Taking base value
        Console.Write("Enter base: ");
        baseNum = Convert.ToDouble(Console.ReadLine());

        // Taking exponent value
        Console.Write("Enter exponent: ");
        exponent = Convert.ToDouble(Console.ReadLine());

        // Using Math.Pow() to calculate power
        result = Math.Pow(baseNum, exponent);

        // Displaying result
        Console.WriteLine("Result = " + result);
    }
}
