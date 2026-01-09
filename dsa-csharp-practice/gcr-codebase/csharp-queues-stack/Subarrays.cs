using System;
using System.Collections.Generic;

class ZeroSumSubarray
{
    static bool HasZeroSumSubarray(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        int sum = 0;

        foreach (int num in arr)
        {
            sum += num;
            if (sum == 0 || set.Contains(sum))
                return true;

            set.Add(sum);
        }
        return false;
    }

    static void Main()
    {
        int[] arr = { 4, 2, -3, 1, 6 };
        Console.WriteLine(HasZeroSumSubarray(arr));
    }
}
