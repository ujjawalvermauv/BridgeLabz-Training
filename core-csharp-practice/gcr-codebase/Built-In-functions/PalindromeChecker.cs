using System;

class PalindromeChecker
{
    static void Main(string[] args)
    {
        string input = GetInput();
        bool result = IsPalindrome(input);

        DisplayResult(result);
    }

    static string GetInput()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    static bool IsPalindrome(string text)
    {
        string reversed = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversed += text[i];
        }
        return text.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    static void DisplayResult(bool isPalindrome)
    {
        if (isPalindrome)
            Console.WriteLine("It is a Palindrome.");
        else
            Console.WriteLine("It is Not a Palindrome.");
    }
}
