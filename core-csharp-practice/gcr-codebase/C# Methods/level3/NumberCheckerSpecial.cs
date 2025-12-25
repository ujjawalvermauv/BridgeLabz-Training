using System;

class NumberCheckerSpecial
{
    // a. Check if Prime Number
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        // Optimization: check up to the square root
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // b. Check if Neon Number (Sum of digits of square equals original)
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }

    // c. Check if Spy Number (Sum of digits equals Product of digits)
    public static bool IsSpy(int number)
    {
        int sum = 0;
        int product = 1;
        int temp = Math.Abs(number);
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }
        return sum == product;
    }

    // d. Check if Automorphic Number (Square ends with number itself)
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        string numStr = number.ToString();
        string squareStr = square.ToString();
        return squareStr.EndsWith(numStr);
    }

    // e. Check if Buzz Number (Divisible by 7 OR ends with 7)
    public static bool IsBuzz(int number)
    {
        return (number % 7 == 0) || (number % 10 == 7);
    }

    static void Main()
    {
        Console.Write("Enter a number to check properties: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Is Prime: " + IsPrime(n));
        Console.WriteLine("Is Neon: " + IsNeon(n));
        Console.WriteLine("Is Spy: " + IsSpy(n));
        Console.WriteLine("Is Automorphic: " + IsAutomorphic(n));
        Console.WriteLine("Is Buzz: " + IsBuzz(n));
    }
}