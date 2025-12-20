using System;

class WeightConversion
{
    static void Main()
    {
        double pounds;

        // Taking weight in pounds
        Console.Write("Enter weight in pounds: ");
        pounds = Convert.ToDouble(Console.ReadLine());

        // Conversion (1 pound = 2.2 kg)
        double kg = pounds / 2.2;

        // Displaying result
        Console.WriteLine("The weight of the person in pounds is " + pounds + " and in kg is " + kg);
    }
}
