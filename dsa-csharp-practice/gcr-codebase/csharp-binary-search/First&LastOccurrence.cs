using System;

class FirstLastOccurrence
{
    static int FindIndex(int[] arr, int target, bool first)
    {
        int low = 0, high = arr.Length - 1, result = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                if (first) high = mid - 1;
                else low = mid + 1;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return result;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 2, 2, 3 };
        Console.WriteLine(FindIndex(arr, 2, true));
        Console.WriteLine(FindIndex(arr, 2, false));
    }
}

