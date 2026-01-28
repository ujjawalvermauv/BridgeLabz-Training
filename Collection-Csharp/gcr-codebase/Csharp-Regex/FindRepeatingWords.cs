using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is is a repeated repeated test.";
        string pattern = @"\b(\w+)\s+\1\b";

        foreach (Match m in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
            Console.WriteLine(m.Value);
    }
}
