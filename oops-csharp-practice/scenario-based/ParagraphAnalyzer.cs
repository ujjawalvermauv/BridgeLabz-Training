using System;
using System.Text.RegularExpressions;

class ParagraphAnalyzer
{
    static void AnalyzeText(string paragraph, string oldWord, string newWord)
    {
        if (string.IsNullOrWhiteSpace(paragraph))
        {
            Console.WriteLine("Paragraph is empty or contains only spaces.");
            return;
        }

        string[] words = paragraph.Split(
            new char[] { ' ', '.', ',', '!', '?' },
            StringSplitOptions.RemoveEmptyEntries
        );

        // Word Count
        Console.WriteLine("Word Count: " + words.Length);

        // Longest Word
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        Console.WriteLine("Longest Word: " + longestWord);

        // Replace word (case-insensitive)
        string replacedText = Regex.Replace(
            paragraph,
            oldWord,
            newWord,
            RegexOptions.IgnoreCase
        );

        Console.WriteLine("Updated Paragraph:");
        Console.WriteLine(replacedText);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a paragraph:");
        string paragraph = Console.ReadLine();

        Console.WriteLine("Enter word to replace:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter new word:");
        string newWord = Console.ReadLine();

        AnalyzeText(paragraph, oldWord, newWord);
    }
}
