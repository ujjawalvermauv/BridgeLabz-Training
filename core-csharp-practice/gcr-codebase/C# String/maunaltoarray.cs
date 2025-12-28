using System;
class maunaltoarray
{
    static void Main()
    {
        Console.WriteLine("Enter the string:");
        string input = Console.ReadLine();
        // Manually convert string to char array
        char[] manualCharArray = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            manualCharArray[i] = input[i];
        }
        // Convert string to char array using built-in method
        char[] builtInCharArray = input.ToCharArray();
        // compare both char arrays
        bool areEqual = true;
        if (manualCharArray.Length != builtInCharArray.Length)
        {
            areEqual = false;
        }
        else
        {
            for (int i = 0; i < manualCharArray.Length; i++)
            {
                if (manualCharArray[i] != builtInCharArray[i])
                {
                    areEqual = false;
                    break;
                }
                else
                {
                    areEqual = true;
                }
            }
        }
        // Display both char arrays
        Console.WriteLine("Char array manual: " + new string(manualCharArray));
        Console.WriteLine("Char array using builtin : " + new string(builtInCharArray));
        Console.WriteLine("Are both char arrays equal? " + areEqual);
    }
}