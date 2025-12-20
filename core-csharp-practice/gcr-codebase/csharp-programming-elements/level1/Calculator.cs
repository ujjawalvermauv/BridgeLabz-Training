using System;

class Calculator
{
    static void Main()
    {
        double number1, number2;

        Console.Write("Enter first number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Addition: " + (number1 + number2));
        Console.WriteLine("Subtraction: " + (number1 - number2));
        Console.WriteLine("Multiplication: " + (number1 * number2));
        Console.WriteLine("Division: " + (number1 / number2));
    }
}
