using System;
class EmployeeManagemntSystem
{
    public static string CompanyName = "Microsoft";
    public string employeeName;
    private static int totalEmployees = 0;
    public readonly int employeeID;
    public string Designation;
    public EmployeeManagemntSystem(string employeeName, int employeeID, string Designation)
    {
        this.employeeName = employeeName;
        this.employeeID = employeeID;
        this.Designation = Designation;
        totalEmployees++;


    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);

    }
    public void DisplayDetails()
    {
        Console.WriteLine("Company Name: " + CompanyName);
        Console.WriteLine("Employee Name: " + employeeName);
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Designation: " + Designation);

    }
    public static void Main()
    {
        EmployeeManagemntSystem emp1 = new EmployeeManagemntSystem("Ujjawal Verma", 101, "Software Engineer");
        EmployeeManagemntSystem emp2 = new EmployeeManagemntSystem("Amit Kumar", 102, "Senior Developer");

        // using static method
        EmployeeManagemntSystem.DisplayTotalEmployees();

        // using 'is' operator before displaying details
        if (emp1 is EmployeeManagemntSystem)
        {
            Console.WriteLine("\nEmployee 1 Details:");
            emp1.DisplayDetails();
        }

        if (emp2 is EmployeeManagemntSystem)
        {
            Console.WriteLine("\nEmployee 2 Details:");
            emp2.DisplayDetails();
        }
    }





}