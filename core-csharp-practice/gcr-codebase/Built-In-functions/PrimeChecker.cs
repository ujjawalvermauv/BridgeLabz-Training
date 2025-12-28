using System;

class PrimeChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = CheckPrime(number);

        if (isPrime)
            Console.WriteLine("Number is Prime.");
        else
            Console.WriteLine("Number is Not Prime.");
    }

    static bool CheckPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
