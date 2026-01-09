using System;
using System.Collections.Generic;

class TwoSum
{
    static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
                return new int[] { map[complement], i };

            map[nums[i]] = i;
        }
        return new int[] { -1, -1 };
    }

    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int[] result = FindTwoSum(nums, 9);
        Console.WriteLine(result[0] + " " + result[1]);
    }
}
