using System;

class Student
{
    public int RollNo;
    public string Name;
    public int Marks;

    public Student(int rollNo, string name, int marks)
    {
        RollNo = rollNo;
        Name = name;
        Marks = marks;
    }
}

class EduResults
{
    // Merge Sort Function
    public static void MergeSort(Student[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    // Merge two sorted halves
    private static void Merge(Student[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        Student[] L = new Student[n1];
        Student[] R = new Student[n2];

        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];

        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        // Stable merge
        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex].Marks <= R[jIndex].Marks)
                arr[k++] = L[iIndex++];
            else
                arr[k++] = R[jIndex++];
        }

        while (iIndex < n1)
            arr[k++] = L[iIndex++];

        while (jIndex < n2)
            arr[k++] = R[jIndex++];
    }

    // Main Method
    static void Main()
    {
        // Combined district-wise sorted data
        Student[] students =
        {
            new Student(101, "Amit", 78),
            new Student(102, "Riya", 85),
            new Student(103, "Kunal", 85),
            new Student(104, "Sneha", 92),
            new Student(105, "Rahul", 92),
            new Student(106, "Neha", 96)
        };

        Console.WriteLine("Before Sorting:");
        PrintStudents(students);
        MergeSort(students, 0, students.Length - 1);
        Console.WriteLine("\nFinal State-wise Rank List:");
        PrintStudents(students);
    }
    static void PrintStudents(Student[] students){
    foreach (Student s in students)
    {
        Console.WriteLine(
            "RollNo: " + s.RollNo +", Name: " + s.Name +", Marks: " + s.Marks
        );
    }
}


    
}
