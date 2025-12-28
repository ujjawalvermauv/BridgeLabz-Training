using System;

class CompareString
{
    static void Main(string[] args)
    {
        string str1, str2;
        Console.WriteLine("Enter first string:");
        str1 = Console.ReadLine();
        Console.WriteLine("Enter second string:");
        str2 = Console.ReadLine();
        bool isEqual = true;
        if (str1.Length != str2.Length)
        {
            isEqual = false;
        }
        else
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    isEqual = false;
                    break;
                }
                else
                {
                    isEqual = true;
                }
            }
        }

        if (isEqual)
        {
            Console.WriteLine("Both strings are equal");
        }
        else
        {
            Console.WriteLine("Both strings are not equal");
        }

    }
}