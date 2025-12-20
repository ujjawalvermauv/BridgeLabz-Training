using System;

class AreaOfCircle
{
    static void Main()
    {
        double radius, area;   // Declaring variables

        // Taking radius input
        Console.Write("Enter radius: ");
        radius = Convert.ToDouble(Console.ReadLine());

        // Formula: Area = π * r * r
        area = Math.PI * radius * radius;

        // Displaying area
        Console.WriteLine("Area of Circle = " + area);
    }
}
