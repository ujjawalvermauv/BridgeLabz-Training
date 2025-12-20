using System;

class Program
{
    static void Main()
    {
        double length, width, perimeter;   // Declaring variables

        // Taking length input
        Console.Write("Enter length: ");
        length = Convert.ToDouble(Console.ReadLine());

        // Taking width input
        Console.Write("Enter width: ");
        width = Convert.ToDouble(Console.ReadLine());

        // Formula: Perimeter = 2 * (length + width)
        perimeter = 2 * (length + width);

        // Displaying perimeter
        Console.WriteLine("Perimeter of Rectangle = " + perimeter);
    }
}
