using System;

class ToUpperManual
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        string manualUpper = ConvertToUpper(input);
        string builtInUpper = input.ToUpper();

        Console.WriteLine("Manual Uppercase: " + manualUpper);
        Console.WriteLine("Built-in Uppercase: " + builtInUpper);
    }

    static string ConvertToUpper(string text)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch >= 'a' && ch <= 'z')
                result += (char)(ch - 32); // ASCII logic
            else
                result += ch;
        }
        return result;
    }
}
