using System;

class vowelandconsonent
{
    static void Main()
    {
        string input = "Hello World";
        int vowelCount = 0;
        int consonantCount = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char ch = char.ToLower(input[i]);
            if (ch >= 'a' && ch <= 'z')
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }



        Console.WriteLine("Vowels: " + vowelCount);
        Console.WriteLine("Consonants: " + consonantCount);
    }
}