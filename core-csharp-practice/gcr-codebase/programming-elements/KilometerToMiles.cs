using System;

class KilometersToMiles
{
    static void Main()
    {
        double km, miles;   // Declaring variables

        // Taking distance in kilometers
        Console.Write("Enter distance in kilometers: ");
        km = Convert.ToDouble(Console.ReadLine());

        // Formula: Miles = Kilometers * 0.621371
        miles = km * 0.621371;

        // Displaying converted distance
        Console.WriteLine("Distance in miles = " + miles);
    }
}
