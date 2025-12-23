using System;

class FactorialFor
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("Factorial is " + factorial);
    }
}
