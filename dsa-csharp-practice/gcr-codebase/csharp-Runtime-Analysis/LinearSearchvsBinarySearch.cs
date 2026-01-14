using System;

class SearchExample
{
    static int LinearSearch(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int key)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == key) return mid;
            else if (arr[mid] < key) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] data = { 2, 4, 6, 8, 10, 12 };
        Console.WriteLine(LinearSearch(data, 10));   // O(N)
        Console.WriteLine(BinarySearch(data, 10));   // O(log N)
    }
}
