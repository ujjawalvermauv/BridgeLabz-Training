using System;

class ManualReplace
{
    static void Main()
    {
        Console.WriteLine("Enter main string:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter character to replace:");
        char oldChar = Console.ReadLine()[0];
        Console.WriteLine("Enter new character:");
        char newChar = Console.ReadLine()[0];
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == oldChar)
                result += newChar;
            else
                result += text[i];
        }

        Console.WriteLine("Modified String: " + result);
    }
}
