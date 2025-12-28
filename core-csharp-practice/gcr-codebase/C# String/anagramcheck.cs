using System;

class AnagramCheck
{
    static void Main()
    {
        Console.WriteLine("Enter first string:");
        string s1 = Console.ReadLine();

        Console.WriteLine("Enter second string:");
        string s2 = Console.ReadLine();

        if (s1.Length != s2.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        int[] freq = new int[256];

        for (int i = 0; i < s1.Length; i++)
        {
            freq[s1[i]]++;
            freq[s2[i]]--;
        }

        foreach (int f in freq)
        {
            if (f != 0)
            {
                Console.WriteLine("Not Anagrams");
                return;
            }
        }

        Console.WriteLine("Strings are Anagrams");
    }
}
