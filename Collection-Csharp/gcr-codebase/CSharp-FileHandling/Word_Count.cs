using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class WordCount
{
    static void Main()
    {
        Dictionary<string, int> words = new Dictionary<string, int>();

        using (StreamReader sr = new StreamReader("text.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                foreach (var word in line.Split(' ', ',', '.', '!', '?'))
                {
                    if (string.IsNullOrWhiteSpace(word)) continue;
                    string key = word.ToLower();
                    words[key] = words.ContainsKey(key) ? words[key] + 1 : 1;
                }
            }
        }

        foreach (var item in words.OrderByDescending(x => x.Value).Take(5))
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}
