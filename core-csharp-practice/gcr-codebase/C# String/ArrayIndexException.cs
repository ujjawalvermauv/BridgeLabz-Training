using System;

class ArrayIndexException
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30 };

        try
        {
            Console.WriteLine(numbers[5]); // Invalid index
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException caught!");
            Console.WriteLine(ex.Message);
        }
    }
}
