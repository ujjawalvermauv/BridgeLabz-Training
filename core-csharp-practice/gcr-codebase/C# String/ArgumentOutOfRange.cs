using System;

class ArgumentOutOfRange
{
    static void Main()
    {
        string text = "Hello";

        try
        {
            // Invalid substring (start index out of range)
            string result = text.Substring(10, 2);
            Console.WriteLine(result);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("ArgumentOutOfRangeException caught!");
            Console.WriteLine(ex.Message);
        }
    }
}
