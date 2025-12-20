using System;

class IntOperation
{
    static void Main()
    {
        int a, b, c;

        // Taking input values
        Console.Write("Enter value of a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of c: ");
        c = Convert.ToInt32(Console.ReadLine());

        // Performing integer operations
        int result1 = a + b * c;   // multiplication first
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        // Displaying results
        Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", " + result4);
    }
}
