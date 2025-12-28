using System;
class reverseString
{
    static void Main()
    {
        //reverse a string without using inbuilt function

        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        Console.WriteLine("Reversed string: " + reversed);

    }

}

