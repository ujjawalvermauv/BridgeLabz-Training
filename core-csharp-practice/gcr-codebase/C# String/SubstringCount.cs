using System;

class SubstringCount
{
    static void Main()
    {
        Console.WriteLine("Enter main string:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter substring:");
        string sub = Console.ReadLine();
        int count = 0;
        for (int i = 0; i <= text.Length - sub.Length; i++)
        {
            bool match = true;

            for (int j = 0; j < sub.Length; j++)
            {
                if (text[i + j] != sub[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
                count++;
        }

        Console.WriteLine("Occurrences: " + count);
    }
}
