using System;
using System.IO;

class WordCount
{
    static void Main()
    {
        string word = "hello";
        int count = 0;

        using (StreamReader sr = new StreamReader("sample.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                foreach (string w in words)
                {
                    if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                        count++;
                }
            }
        }

        Console.WriteLine("Count: " + count);
    }
}
