using System;

class NaturalSumCompareWhile
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number >= 1)
        {
            int sumLoop = 0;
            int i = 1;

            while (i <= number)
            {
                sumLoop = sumLoop + i;
                i++;
            }

            int sumFormula = number * (number + 1) / 2;

            Console.WriteLine("Sum using loop: " + sumLoop);
            Console.WriteLine("Sum using formula: " + sumFormula);
        }
    }
}
