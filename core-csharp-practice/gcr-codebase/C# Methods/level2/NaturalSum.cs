using System;

class NaturalSum
{
    public int SumRecursion(int n)
    {
        if (n <= 1) return n;
        return n + SumRecursion(n - 1);
    }

    public int SumFormula(int n)
    {
        return (n * (n + 1)) / 2;
    }

    static void Main()
    {
        NaturalSum ns = new NaturalSum();
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Not a natural number.");
            return;
        }
        int res1 = ns.SumRecursion(n);
        int res2 = ns.SumFormula(n);
        Console.WriteLine("Recursion Result: " + res1);
        Console.WriteLine("Formula Result: " + res2);
        Console.WriteLine("Are they equal? " + (res1 == res2));
    }
}