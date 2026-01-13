using System;
using System.Text;
using System.Collections.Generic;

class RemoveDuplicates
{
    static void Main()
    {
        string input = "programming";
        StringBuilder sb = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                sb.Append(c);
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
