using System;

class NaturalSumCompareFor
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number >= 1)
        {
            int sumLoop = 0;
            for (int i = 1; i <= number; i++)
            {
                sumLoop = sumLoop + i;
            }
            int sumFormula = number * (number + 1) / 2;
            Console.WriteLine("Sum using loop: " + sumLoop);
            Console.WriteLine("Sum using formula: " + sumFormula);
        }
    }
}
