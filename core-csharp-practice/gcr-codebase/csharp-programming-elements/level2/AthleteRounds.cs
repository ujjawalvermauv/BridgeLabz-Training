using System;

class AthleteRounds
{
    static void Main()
    {
        double side1, side2, side3;

        // Taking triangle sides
        Console.Write("Enter side 1: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3: ");
        side3 = Convert.ToDouble(Console.ReadLine());

        // Calculating perimeter
        double perimeter = side1 + side2 + side3;

        // Total distance to cover (5 km = 5000 meters)
        double rounds = 5000 / perimeter;

        // Printing output
        Console.WriteLine("The total number of rounds the athlete will run is " + rounds);
    }
}
