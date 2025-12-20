using System;

class VolumeOfACylinder
{
    static void Main()
    {
        double radius, height, volume;   // Declaring variables

        // Taking radius input
        Console.Write("Enter radius: ");
        radius = Convert.ToDouble(Console.ReadLine());

        // Taking height input
        Console.Write("Enter height: ");
        height = Convert.ToDouble(Console.ReadLine());

        // Formula: Volume = π * r * r * h
        volume = Math.PI * radius * radius * height;

        // Displaying volume
        Console.WriteLine("Volume of Cylinder = " + volume);
    }
}
