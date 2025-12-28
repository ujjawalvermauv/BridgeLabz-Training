using System;

class FibonacciGenerator
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        PrintFibonacci(terms);
    }

    static void PrintFibonacci(int terms)
    {
        int a = 0, b = 1;

        Console.Write("Fibonacci Series: ");

        for (int i = 1; i <= terms; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }
}
