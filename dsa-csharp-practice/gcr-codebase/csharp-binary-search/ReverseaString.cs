using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = "hello";
        StringBuilder sb = new StringBuilder(input);

        for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
        {
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
        }

        Console.WriteLine(sb.ToString());
    }
}
