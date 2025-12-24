using System;

class StoreSum
{
    static void Main()
    {
        double[] numbers = new double[10];
        int index = 0;
        double total = 0.0;

        while (true)
        {
            Console.Write("Enter a number: ");
            double input = double.Parse(Console.ReadLine());
            if (input <= 0 || index == numbers.Length)
                break;
        }

        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("Sum = " + total);
    }
}
