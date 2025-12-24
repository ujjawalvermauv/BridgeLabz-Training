using System;

class OddEvenArray
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.Error.WriteLine("Invalid natural number.");
            Environment.Exit(1);
        }

        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                even[evenIndex++] = i;
            else
                odd[oddIndex++] = i;
        }

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddIndex; i++)
            Console.Write(odd[i] + " ");

        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
            Console.Write(even[i] + " ");
    }
}
