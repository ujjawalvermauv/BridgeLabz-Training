using System;

class TrackManager
{
    public double CalculateRounds(double s1, double s2, double s3)
    {
        double perimeter = s1 + s2 + s3;
        double targetDistance = 5000;
        return targetDistance / perimeter;
    }
    static void Main()
    {
        TrackManager manager = new TrackManager();
        
        Console.Write("Enter side 1: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter side 2: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter side 3: ");
        double side3 = double.Parse(Console.ReadLine());
        double rounds = manager.CalculateRounds(side1, side2, side3);
        Console.WriteLine("Total rounds needed: " + rounds);
    }
}