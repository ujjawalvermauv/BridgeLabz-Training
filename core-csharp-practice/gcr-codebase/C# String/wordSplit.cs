using System;

class WordSplit
{
    static void Main()
    {
        Console.WriteLine("Enter the text:");
        string input = Console.ReadLine();

        string[,] wordsWithLengths = SplitTextIntoWords(input);

        Console.WriteLine("Words and their lengths:");
        for (int i = 0; i < wordsWithLengths.GetLength(0); i++)
        {
            Console.WriteLine("Word: " + wordsWithLengths[i, 0] + ", Length: " + wordsWithLengths[i, 1]);
        }
    }

    static string[,] SplitTextIntoWords(string text)
    {
        int length = GetStringLength(text);
        int wordCount = 0;
        bool inWord = false;

        // Count words
        for (int i = 0; i < length; i++)
        {
            if (text[i] != ' ' && !inWord)
            {
                inWord = true;
                wordCount++;
            }
            else if (text[i] == ' ')
            {
                inWord = false;
            }
        }

        string[,] result = new string[wordCount, 2];
        int wordIndex = 0;
        int charCount = 0;
        inWord = false;

        // Extract words and lengths
        for (int i = 0; i <= length; i++)
        {
            if (i < length && text[i] != ' ')
            {
                if (!inWord)
                {
                    inWord = true;
                    result[wordIndex, 0] = "";
                    charCount = 0;
                }

                result[wordIndex, 0] += text[i];
                charCount++;
            }
            else
            {
                if (inWord)
                {
                    inWord = false;
                    result[wordIndex, 1] = charCount.ToString();
                    wordIndex++;
                }
            }
        }

        return result;
    }

    static int GetStringLength(string text)
    {
        int count = 0;
        foreach (char c in text)
        {
            count++;
        }
        return count;
    }
}
