using System;

class QuickSortProductPrices
{
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int t = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = t;

        return i + 1;
    }

    static void QuickSort(int[] arr, int low, int high) // Recursive QuickSort function
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high); // Partitioning index
            QuickSort(arr, low, pi - 1); // Recursively sort elements before partition
            QuickSort(arr, pi + 1, high); // Recursively sort elements after partition
        }
    }

    static void Main()
    {
        int[] prices = { 1200, 750, 400, 980, 600 };
        QuickSort(prices, 0, prices.Length - 1);

        Console.WriteLine("Sorted Product Prices:");
        foreach (int p in prices)
            Console.Write(p + " ");
    }
}
