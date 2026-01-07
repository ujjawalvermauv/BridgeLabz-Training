using System;

interface IDepartment // Interface for department-related operations
{
    void AssignDepartment(string departmentName); // Method to assign department
    string GetDepartmentDetails(); // Method to get department details
}

abstract class Employee // Abstract base class for Employee
{
    private string employeeName; // Encapsulated property for employee name
    private int employeeId; // Encapsulated property for employee ID
    protected string department; // Protected field for department
    protected double salary; // Protected field for salary

    public string EmployeeName // Getter and Setter for employee name
    {
        get { return employeeName; }
        set { employeeName = value; }
    }

    public int EmployeeId // Getter and Setter for employee ID
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public abstract void CalculateSalary(); // Abstract method for salary calculation

    public void DisplayEmployeeDetails() // Method to display employee details
    {
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Employee Name: " + EmployeeName);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: " + salary);
    }
}

class FullTimeEmployee : Employee, IDepartment
{
    private double baseSalary;

    public FullTimeEmployee(int id, string name, double salary)
    {
        EmployeeId = id;
        EmployeeName = name;
        baseSalary = salary;
    }

    public override void CalculateSalary()
    {
        this.salary = baseSalary;
    }

    public void AssignDepartment(string deptName)
    {
        department = deptName;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

class PartTimeEmployee : Employee, IDepartment
{
    private double hourlyRate;
    private int hoursWorked;

    public PartTimeEmployee(int id, string name, double rate, int hours)
    {
        EmployeeId = id;
        EmployeeName = name;
        hourlyRate = rate;
        hoursWorked = hours;
    }

    public override void CalculateSalary()
    {
        this.salary = hourlyRate * hoursWorked;
    }

    public void AssignDepartment(string deptName)
    {
        department = deptName;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

class EmployeeManagementSystem // Main class to demonstrate functionality
{
    static void Main(string[] args)
    {
        FullTimeEmployee fullTimeEmp = new FullTimeEmployee(101, "Amit", 50000); // Full-time employee with a base salary
        fullTimeEmp.AssignDepartment("IT");
        fullTimeEmp.CalculateSalary();
        fullTimeEmp.DisplayEmployeeDetails();

        PartTimeEmployee partTimeEmp = new PartTimeEmployee(102, "Riya", 200, 80); // Part-time employee with hourly rate and hours worked
        partTimeEmp.AssignDepartment("HR");
        partTimeEmp.CalculateSalary();
        partTimeEmp.DisplayEmployeeDetails();
    }
}
