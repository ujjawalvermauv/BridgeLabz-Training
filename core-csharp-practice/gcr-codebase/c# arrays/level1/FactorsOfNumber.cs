using System;

class FactorsOfNumber
{
    static void Main()
    {
        // user enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        //  factors
        Console.WriteLine("Factors of " + number + " are:");

        // Loop from 1 to the number
        for (int i = 1; i <= number; i++)
        {
            // use of if to find i is a factor
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
