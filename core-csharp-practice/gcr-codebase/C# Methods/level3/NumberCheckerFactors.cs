using System;

class NumberCheckerFactors
{
    // a. Find factors and return as array
    public static int[] GetFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) count++;
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }
        return factors;
    }

    // b. Find greatest factor (which is the number itself)
    public static int FindGreatestFactor(int[] factors)
    {
        return factors[factors.Length - 1];
    }

    // c. Sum of factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors) sum += f;
        return sum;
    }

    // d. Product of factors
    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int f in factors) product *= f;
        return product;
    }

    // e. Product of cubes of factors
    public static double ProductOfCubes(int[] factors)
    {
        double product = 1;
        foreach (int f in factors)
        {
            product *= Math.Pow(f, 3);
        }
        return product;
    }

    // f, g, h. Proper divisors sum logic (Sum excluding the number itself)
    public static string GetDivisorStatus(int number, int[] factors)
    {
        int properSum = SumOfFactors(factors) - number;
        if (properSum == number) return "Perfect";
        if (properSum > number) return "Abundant";
        return "Deficient";
    }

    // i. Check if Strong Number (Sum of factorial of digits)
    public static bool IsStrong(int number)
    {
        int temp = number;
        int sum = 0;
        while (temp > 0)
        {
            int digit = temp % 10;
            int fact = 1;
            for (int i = 1; i <= digit; i++) fact *= i;
            sum += fact;
            temp /= 10;
        }
        return sum == number;
    }

    static void Main()
    {
        Console.Write("Enter number for factor analysis: ");
        int n = int.Parse(Console.ReadLine());

        int[] factors = GetFactors(n);
        Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));
        Console.WriteLine("Divisor Status: " + GetDivisorStatus(n, factors));
        Console.WriteLine("Is Strong Number: " + IsStrong(n));
    }
}