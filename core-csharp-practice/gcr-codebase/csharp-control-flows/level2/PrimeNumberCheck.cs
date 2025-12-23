using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        Console.WriteLine("Is Prime: " + isPrime);
    }
}
