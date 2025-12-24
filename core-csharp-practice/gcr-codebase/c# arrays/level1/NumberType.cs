using System;

class NumberAnalysis
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i] + " is Positive and Even");
                else
                    Console.WriteLine(numbers[i] + " is Positive and Odd");
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine(numbers[i] + " is Negative");
            }
            else
            {
                Console.WriteLine(numbers[i] + " is Zero");
            }
        }

        // Compare first and last
        if (numbers[0] == numbers[numbers.Length - 1])
            Console.WriteLine("First and Last elements are equal");
        else if (numbers[0] > numbers[numbers.Length - 1])
            Console.WriteLine("First element is greater");
        else
            Console.WriteLine("Last element is greater");
    }
}
