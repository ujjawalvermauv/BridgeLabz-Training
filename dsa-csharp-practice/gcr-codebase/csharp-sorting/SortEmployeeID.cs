using System;

class InsertionSortEmployeeIDs
{
    static void Main()
    {
        int[] empIds = { 104, 101, 109, 102, 106 };

        for (int i = 1; i < empIds.Length; i++)
        {
            int key = empIds[i]; // Current element to be compared
            int j = i - 1; // Index of the previous element

            while (j >= 0 && empIds[j] > key) // Shift elements greater than key to the right
            {
                empIds[j + 1] = empIds[j]; // Move element one position ahead
                j--;
            }
            empIds[j + 1] = key;
        }

        Console.WriteLine("Sorted Employee IDs:");
        foreach (int id in empIds)
            Console.Write(id + " ");
    }
}
