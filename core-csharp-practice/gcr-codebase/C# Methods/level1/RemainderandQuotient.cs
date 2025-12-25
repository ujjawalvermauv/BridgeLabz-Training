using System;

class RemainderandQuotient
{
    public int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }

    static void Main()
    {
        RemainderandQuotient util = new RemainderandQuotient();
        
        Console.Write("Enter Number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter Divisor: ");
        int div = int.Parse(Console.ReadLine());

        int[] result = util.FindRemainderAndQuotient(num, div);
        Console.WriteLine("Quotient: " + result[0] + ", Remainder: " + result[1]);
    }
}