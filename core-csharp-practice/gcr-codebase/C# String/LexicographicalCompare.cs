using System;

class LexicographicalCompare
{
    static void Main()
    {
        Console.WriteLine("Enter first string:");
        string s1 = Console.ReadLine();

        Console.WriteLine("Enter second string:");
        string s2 = Console.ReadLine();

        int minLength = s1.Length < s2.Length ? s1.Length : s2.Length;
        bool decided = false;

        for (int i = 0; i < minLength; i++)
        {
            if (s1[i] < s2[i])
            {
                Console.WriteLine(s1 + " comes before " + s2);
                decided = true;
                break;
            }
            else if (s1[i] > s2[i])
            {
                Console.WriteLine(s2 + " comes before " + s1);
                decided = true;
                break;
            }
        }

        if (!decided)
        {
            if (s1.Length < s2.Length)
                Console.WriteLine(s1 + " comes before " + s2);
            else if (s1.Length > s2.Length)
                Console.WriteLine(s2 + " comes before " + s1);
            else
                Console.WriteLine("Both strings are equal");
        }
    }
}
