using System;

class MathOperations
{
    public int GetSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        return sum;
    }

    static void Main()
    {
        MathOperations op = new MathOperations();
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum is: " + op.GetSum(n));
    }
}