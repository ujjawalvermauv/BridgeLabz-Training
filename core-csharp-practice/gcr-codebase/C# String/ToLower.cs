using System;

class ToLowerManual
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        string manualLower = ConvertToLower(input);
        string builtInLower = input.ToLower();

        Console.WriteLine("Manual Lowercase: " + manualLower);
        Console.WriteLine("Built-in Lowercase: " + builtInLower);
    }

    static string ConvertToLower(string text)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch >= 'A' && ch <= 'Z')
                result += (char)(ch + 32); // ASCII logic
            else
                result += ch;
        }
        return result;
    }
}
