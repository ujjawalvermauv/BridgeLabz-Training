using System;

class SwapNumbers
{
    static void Main()
    {
        int number1, number2, temp;

        // Taking first number
        Console.Write("Enter first number: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        // Taking second number
        Console.Write("Enter second number: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        // Swapping using temporary variable
        temp = number1;
        number1 = number2;
        number2 = temp;

        // Printing swapped values
        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}
