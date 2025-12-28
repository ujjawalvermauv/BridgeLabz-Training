using System;

class SubstringExample
{
    static void Main()
    {
        Console.WriteLine("Enter the string:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the starting index:");
        int startIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of substring:");
        int length = int.Parse(Console.ReadLine());

        // Create substring manually 
        string manualSubstring = "";

        for (int i = startIndex; i < startIndex + length && i < input.Length; i++)
        {
            manualSubstring += input[i];
        }

        // Create substring using built-in method
        string builtInSubstring = input.Substring(startIndex, length);

        // Display both results
        Console.WriteLine("Substring manual: " + manualSubstring);
        Console.WriteLine("Substring using builtin : " + builtInSubstring);

        // Comparing both substrings
        bool areEqual = manualSubstring.Equals(builtInSubstring);

        Console.WriteLine("Are both substrings equal? " + areEqual);
    }
}
