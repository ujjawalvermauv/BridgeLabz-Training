using System;
using System.Text;

class ConcatenateStrings
{
    static void Main()
    {
        string[] words = { "Hello", " ", "World", "!" };
        StringBuilder sb = new StringBuilder();

        foreach (string word in words)
        {
            sb.Append(word);
        }

        Console.WriteLine(sb.ToString());
    }
}
