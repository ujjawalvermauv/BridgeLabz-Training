using System;

class Program
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
            throw new ArgumentException();

        return amount * rate * years / 100;
    }

    static void Main()
    {
        try
        {
            double interest = CalculateInterest(1000, -5, 2);
            Console.WriteLine("Interest: " + interest);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid input: Amount and rate must be positive");
        }
    }
}
