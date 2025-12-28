using System;
using System.Linq; // Required for the Distinct() method

class RemoveDuplicateEfficient
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string result = new string(input.Distinct().ToArray());

        Console.WriteLine("String after removing duplicates: " + result);
    }
}
