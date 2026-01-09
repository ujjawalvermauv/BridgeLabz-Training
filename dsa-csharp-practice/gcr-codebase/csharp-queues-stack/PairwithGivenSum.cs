using System;
using System.Collections.Generic;

class PairWithSum
{
    static bool FindPair(int[] arr, int sum)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            if (set.Contains(sum - num))
                return true;
            set.Add(num);
        }
        return false;
    }

    static void Main()
    {
        int[] arr = { 8, 4, 1, 6 };
        Console.WriteLine(FindPair(arr, 10));
    }
}
