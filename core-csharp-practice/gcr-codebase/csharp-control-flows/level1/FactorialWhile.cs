using System;

class FactorialWhile
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int factorial = 1;
        int i = 1;
        while (i <= number)
        {
            factorial = factorial * i;
            i++;
        }
        Console.WriteLine("Factorial is " + factorial);
    }
}
