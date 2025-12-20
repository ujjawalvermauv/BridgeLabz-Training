using System;

class DistanceConversion
{
    static void Main()
    {
        double feet;
        Console.Write("Enter distance in feet: ");
        feet = Convert.ToDouble(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards / 1760;

        Console.WriteLine("Distance in yards is " + yards + " and distance in miles is " + miles);
    }
}
