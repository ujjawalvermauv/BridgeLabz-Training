using System;

class DateComparison
{
    static void Main(string[] args)
    {
        Console.Write("Enter first date (yyyy-MM-dd): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date (yyyy-MM-dd): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        int result = DateTime.Compare(firstDate, secondDate);

        if (result < 0)
        {
            Console.WriteLine("First date is before the second date.");
        }
        else if (result > 0)
        {
            Console.WriteLine("First date is after the second date.");
        }
        else
        {
            Console.WriteLine("Both dates are the same.");
        }
    }
}
