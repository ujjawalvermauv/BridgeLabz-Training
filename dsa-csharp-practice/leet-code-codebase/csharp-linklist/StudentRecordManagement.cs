using System;

class StudentNode
{
    // Student data
    public int RollNumber;
    public string Name;
    public int Age;
    public string Grade;

    // Pointer to next node
    public StudentNode Next;

    // Constructor
    public StudentNode(int rollNumber, string name, int age, string grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    StudentNode head;

    // Add student at beginning
    public void AddStudent(int rollNumber, string name, int age, string grade)
    {
        StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }

    // Delete student by roll number
    public void DeleteStudent(int rollNumber)
    {
        if (head == null)
            return;

        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            return;
        }

        StudentNode current = head;
        while (current.Next != null && current.Next.RollNumber != rollNumber)
        {
            current = current.Next;
        }

        if (current.Next != null)
            current.Next = current.Next.Next;
    }

    // Search student by roll number
    public void SearchStudent(int rollNumber)
    {
        StudentNode current = head;

        while (current != null)
        {
            if (current.RollNumber == rollNumber)
            {
                Console.WriteLine("Roll: " + current.RollNumber + " Name: " + current.Name + " Grade: " + current.Grade);
                return;
            }
            current = current.Next;
        }

        Console.WriteLine("Student not found");
    }

    // Update student grade
    public void UpdateGrade(int rollNumber, string newGrade)
    {
        StudentNode current = head;

        while (current != null)
        {
            if (current.RollNumber == rollNumber)
            {
                current.Grade = newGrade;
                return;
            }
            current = current.Next;
        }
    }

    // Display all students
    public void DisplayStudents()
    {
        StudentNode current = head;

        while (current != null)
        {
            Console.WriteLine("Roll: " + current.RollNumber + " Name: " + current.Name + " Age: " + current.Age + " Grade: " + current.Grade);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentLinkedList studentList = new StudentLinkedList();

        studentList.AddStudent(1, "Amit", 20, "A");
        studentList.AddStudent(2, "Ravi", 21, "B");

        studentList.DisplayStudents();

        studentList.SearchStudent(1);
        studentList.UpdateGrade(2, "A+");
        studentList.DeleteStudent(1);

        Console.WriteLine("After changes:");
        studentList.DisplayStudents();
    }
}
