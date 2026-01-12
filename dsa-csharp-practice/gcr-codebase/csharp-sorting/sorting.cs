using System;

public class Student
{
    public int Id;
    public string Name;

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class Program
{
    public static void Main()
    {
        // Initializing a fixed-size array of Students
        Student[] students = new Student[4];
        students[0] = new Student(104, "ujjawal");
        students[1] = new Student(101, "ankit");
        students[2] = new Student(103, "raj");
        students[3] = new Student(102, "harshita");

        Console.WriteLine("Sorting by Student ID:");
        SortById(students);
        PrintArray(students);

        Console.WriteLine("Sorting by Student Name:");
        SortByName(students);
        PrintArray(students);
    }

    // Insertion Sort by ID
    public static void SortById(Student[] arr) // Sorts the array of Students by their ID using Insertion Sort
    {
        for (int i = 1; i < arr.Length; i++)
        {
            Student key = arr[i];
            int j = i - 1;

            // Shift elements that have an ID greater than the key
            while (j >= 0 && arr[j].Id > key.Id)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key; // Insert key at correct position
        }
    }

    // Insertion Sort by Name
    public static void SortByName(Student[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            Student key = arr[i];
            int j = i - 1;

            // Shift elements that have a Name greater than the key
            while (j >= 0 && String.Compare(arr[j].Name, key.Name) > 0)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    public static void PrintArray(Student[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("ID " + arr[i].Id + ", Name " + arr[i].Name);
        }
    }
}