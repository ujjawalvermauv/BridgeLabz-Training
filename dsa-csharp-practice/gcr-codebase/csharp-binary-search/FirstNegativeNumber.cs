using System;

class FirstNegative
{
    static void Main()
    {
        int[] arr = { 3, 5, -2, 7, -8 };

        foreach (int num in arr)
        {
            if (num < 0)
            {
                Console.WriteLine(num);
                break;
            }
        }
    }
}
