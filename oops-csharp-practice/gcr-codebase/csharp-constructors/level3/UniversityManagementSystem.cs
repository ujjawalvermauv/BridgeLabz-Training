using System;
public class UniversityManagementSystem
{
    public int RollNumber;
    protected string Name;
    private double cgpa;
    public UniversityManagementSystem(int rollNumber, string name, double cgpa) //constructor
    {
        this.RollNumber = rollNumber;
        this.Name = name;
        this.cgpa = cgpa;
    }

    public void SetCgpa(double cgpa) //method to modify private variable
    {
        this.cgpa = cgpa;
    }
    public double GetCgpa() //method to access private variable
    {
        return cgpa;
    }
    public void DisplayStudentDetails() //method to display student details
    {
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("CGPA: " + cgpa);
    }
    class PostgraduateStudent : UniversityManagementSystem
    {
        public PostgraduateStudent(int rollNumber, string name, double cgpa) : base(rollNumber, name, cgpa)
        {

        }
        public void ShowName()
        {
            Console.WriteLine("Postgraduate Student Name: " + Name);
        }

    }
    public static void Main()
    {
        UniversityManagementSystem student = new UniversityManagementSystem(101, "Ujjawal Verma", 9.1);
        student.DisplayStudentDetails();
        student.SetCgpa(9.5); //modifying private variable using method
        PostgraduateStudent pgStudent = new PostgraduateStudent(103, "Harsh Kumar", 9.6);
        pgStudent.ShowName();
    }



}