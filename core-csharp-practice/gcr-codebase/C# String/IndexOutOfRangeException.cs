using System;

class IndexOutOfRangeExceptionExample
{
    static void Main(string[] args)
    {
        string sampleString = "Hello, World!";
        AccessInvalidIndex(sampleString);
    }

    static void AccessInvalidIndex(string str)
    {
        try
        {
            // Attempt to access an invalid index
            char invalidChar = str[100]; // Index out of range
            Console.WriteLine(invalidChar);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("An exception occurred: " + ex.Message);
        }
    }
}