using System;
class UniversityStudentManagement
{
    public static string UniversityName = "GLA University";
    public string studentName;
    public readonly int studentRollNumber;
    public char studentGrade;
    private static int totalStudents = 0;
    public UniversityStudentManagement(string studentName, int studentRollNumber, char studentGrade)
    {
        this.studentName = studentName;
        this.studentRollNumber = studentRollNumber;
        this.studentGrade = studentGrade;
        totalStudents++;
    }
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);

    }
    public void DisplayDetails()
    {
        Console.WriteLine("University Name: " + UniversityName);
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Student Roll Number: " + studentRollNumber);
        Console.WriteLine("Student Grade: " + studentGrade);
    }
    public static void Main()
    {
        UniversityStudentManagement student1 = new UniversityStudentManagement("Ujjawal Verma", 201, 'A');
        UniversityStudentManagement student2 = new UniversityStudentManagement("Amit Kumar", 202, 'B');

        // using static method
        UniversityStudentManagement.DisplayTotalStudents();
        // using 'is' operator before displaying details
        if (student1 is UniversityStudentManagement)
        {
            Console.WriteLine("\nStudent 1 Details:");
            student1.DisplayDetails();
        }
        if (student2 is UniversityStudentManagement)
        {
            Console.WriteLine("\nStudent 2 Details:");
            student2.DisplayDetails();
        }
    }






}