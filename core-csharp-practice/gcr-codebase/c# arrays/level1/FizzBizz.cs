using System;

class FizzBuzzProgram
{
    static void Main()
    {
        // Take input from user
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        // Validate input
        if (number <= 0)
        {
            Console.Error.WriteLine("Invalid input. Enter a positive integer.");
            Environment.Exit(1);
        }

        // Create string array to store results
        string[] result = new string[number + 1];

        // Store FizzBuzz values in array
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                result[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                result[i] = "Buzz";
            }
            else
            {
                result[i] = i.ToString();
            }
        }

        // Display results
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + result[i]);
        }
    }
}
