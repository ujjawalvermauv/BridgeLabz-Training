using System;

class LongestWord
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();
        string longestWord = "";
        string currentWord = "";
        for (int i = 0; i <= input.Length; i++)
        {
            if (i < input.Length && input[i] != ' ')
            {
                currentWord += input[i];
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
            }
        }

        Console.WriteLine("Longest word: " + longestWord);
    }
}
