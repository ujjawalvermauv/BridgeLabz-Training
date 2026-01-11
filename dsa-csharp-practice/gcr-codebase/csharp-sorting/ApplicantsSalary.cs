using System;

class HeapSortSalary
{
    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;
        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;
            Heapify(arr, n, largest);
        }
    }

    static void HeapSort(int[] arr) // Main HeapSort function
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--) // Build heap
            Heapify(arr, n, i);

        for (int i = n - 1; i > 0; i--) // One by one extract elements from heap
        {
            int temp = arr[0]; // Move current root to end
            arr[0] = arr[i];
            arr[i] = temp; // call max heapify on the reduced heap
            Heapify(arr, i, 0);
        }
    }

    static void Main()
    {
        int[] salaries = { 45000, 30000, 60000, 50000, 35000 };
        HeapSort(salaries);
        Console.WriteLine("Sorted Salary Demands:");
        foreach (int s in salaries)
            Console.Write(s + " ");
    }
}
