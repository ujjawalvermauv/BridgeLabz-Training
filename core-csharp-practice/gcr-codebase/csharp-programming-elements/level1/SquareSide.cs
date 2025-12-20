using System;

class SquareSide
{
    static void Main()
    {
        double perimeter;
        Console.Write("Enter perimeter: ");
        perimeter = Convert.ToDouble(Console.ReadLine());

        double side = perimeter / 4;

        Console.WriteLine("The length of the side is " + side +" whose perimeter is " + perimeter);
    }
}
