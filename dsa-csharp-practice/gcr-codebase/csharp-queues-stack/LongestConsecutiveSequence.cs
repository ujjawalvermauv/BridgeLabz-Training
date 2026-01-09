using System;
using System.Collections.Generic;

class LongestConsecutive
{
    static int LongestSequence(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in nums)
        {
            if (!set.Contains(num - 1))
            {
                int current = num;
                int count = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }
                longest = Math.Max(longest, count);
            }
        }
        return longest;
    }

    static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine(LongestSequence(nums));
    }
}
