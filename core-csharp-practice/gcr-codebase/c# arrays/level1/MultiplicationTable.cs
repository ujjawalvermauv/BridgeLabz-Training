using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] table = new int[10];

        for (int i = 0; i < table.Length; i++)
        {
            table[i] = number * (i + 1);
        }

        for (int i = 0; i < table.Length; i++)
        {
            Console.WriteLine(number + " * " + (i + 1) + " = " + table[i]);
        }
    }
}
