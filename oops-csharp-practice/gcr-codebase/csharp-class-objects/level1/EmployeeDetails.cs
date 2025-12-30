using System;
public class EmployeeDetails
{
    //Fields (attributes)
    private string name;
    private string id;
    private double salary;
    //Constructor
    public EmployeeDetails(string name, string id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
    //method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Employee Salary: " + salary);
    }
    // Main method to test the EmployeeDetails class
    public static void Main()
    {
        // Creating an instance of the EmployeeDetails class
        EmployeeDetails emp1 = new EmployeeDetails("ujjawal", "cap", 50000);
        EmployeeDetails emp2 = new EmployeeDetails("harsh", "gem", 60000);

        // Displaying employee details
        emp1.DisplayDetails();
        emp2.DisplayDetails();
    }





}