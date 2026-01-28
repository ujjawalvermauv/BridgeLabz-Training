using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "I love Java, Python, JavaScript and Go.";
        string pattern = @"\b(Java|Python|JavaScript|Go)\b";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
