using System;

class NullReferenceDemo
{
    static void Main()
    {
        // Call the method
        DemonstrateNullReference();
    }

    // Method to demonstrate NullReferenceException
    static void DemonstrateNullReference()
    {
        string message = null;

        try
        {
            int length = message.Length;   // Exception occurs here
            Console.WriteLine("Length: " + length);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("NullReferenceException caught!");
            Console.WriteLine("Error message: " + ex.Message);
        }
    }
}
