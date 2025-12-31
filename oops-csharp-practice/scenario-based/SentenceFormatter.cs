using System;
using System.Text;

class SentenceFormatter
{
    public static string FormatSentence(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return "Empty paragraph provided.";

        // Trim extra spaces
        input = input.Trim();
        // Replace multiple spaces with single space
        while (input.Contains("  "))
        {
            input = input.Replace("  ", " ");
        }
        StringBuilder result = new StringBuilder();
        bool capitalizeNext = true;
        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (capitalizeNext && char.IsLetter(ch))
            {
                result.Append(char.ToUpper(ch));
                capitalizeNext = false;
            }
            else
            {
                result.Append(ch);
            }
            // Capitalize after sentence-ending punctuation
            if (ch == '.' || ch == '?' || ch == '!')
            {
                capitalizeNext = true;

                // Ensure one space after punctuation
                if (i + 1 < input.Length && input[i + 1] != ' ')
                {
                    result.Append(' ');
                }
            }
        }

        return result.ToString();
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a paragraph:");
        string input = Console.ReadLine();
        string output = FormatSentence(input);
        Console.WriteLine("\nFormatted Paragraph:");
        Console.WriteLine(output);
    }
}

