using System;

class SentenceSearch
{
    static void Main()
    {
        string[] sentences =
        {
            "I love coding",
            "C# is powerful",
            "Learning is fun"
        };

        string word = "powerful";

        foreach (string s in sentences)
        {
            if (s.Contains(word))
            {
                Console.WriteLine(s);
                break;
            }
        }
    }
}
