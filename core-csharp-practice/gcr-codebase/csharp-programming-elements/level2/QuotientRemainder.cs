using System;

class QuotientRemainder
{
    static void Main()
    {
        int number1, number2;

        // Taking first number
        Console.Write("Enter first number: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        // Taking second number
        Console.Write("Enter second number: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        // Division gives quotient
        int quotient = number1 / number2;

        // Modulus gives remainder
        int remainder = number1 % number2;

        // Printing result
        Console.WriteLine("The Quotient is " + quotient +   " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
    }
}
