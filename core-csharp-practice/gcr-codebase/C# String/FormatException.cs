using System;

class FormatExceptionnExample
{
    static void Main()
    {
        try
        {
            string value = "abc";
            int number = int.Parse(value); // Invalid format
        }
        catch (FormatException ex)
        {
            Console.WriteLine("FormatException caught!");
            Console.WriteLine(ex.Message);
        }
    }
}
