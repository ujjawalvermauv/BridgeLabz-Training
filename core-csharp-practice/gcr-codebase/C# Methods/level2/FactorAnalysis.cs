using System;

class FactorAnalysis
{
    public static int[] FindFactors(int number)
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

    public double CalculateSum(int[] factors)
    {
        double sum = 0;
        foreach (int f in factors) sum += f;
        return sum;
    }

    public double CalculateProduct(int[] factors)
    {
        double product = 1;
        foreach (int f in factors) product *= f;
        return product;
    }

    public double CalculateSumOfSquares(int[] factors)
    {
        double sumSq = 0;
        foreach (int f in factors) sumSq += Math.Pow(f, 2);
        return sumSq;
    }

    static void Main()
    {
        FactorAnalysis fa = new FactorAnalysis();
        Console.Write("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        int[] factorsArray = FindFactors(inputNumber);
        
        Console.Write("Factors: ");
        foreach (int f in factorsArray) Console.Write(f + " ");
        
        Console.WriteLine("\nSum: " + fa.CalculateSum(factorsArray));
        Console.WriteLine("Product: " + fa.CalculateProduct(factorsArray));
        Console.WriteLine("Sum of Squares: " + fa.CalculateSumOfSquares(factorsArray));
    }
}