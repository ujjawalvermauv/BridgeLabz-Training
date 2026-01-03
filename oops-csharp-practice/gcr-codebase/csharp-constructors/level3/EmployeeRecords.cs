using System;
public class EmployeeRecords
{
    public int employeeID;
    protected string department;
    private double salary;
    public EmployeeRecords(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }
    public void SetSalary(double salary) //method to modify private variable
    {
        this.salary = salary;
    }
    public double GetSalary() //method to access private variable
    {
        return salary;
    }
    class Manager : EmployeeRecords
    {
        public Manager(int employeeID, string department, double salary) : base(employeeID, department, salary)
        {

        }
        public void ShowemployeeID()
        {
            System.Console.WriteLine("Manager Employee ID: " + employeeID);
        }
        public void ShowDepartment()
        {
            System.Console.WriteLine("Manager Department: " + department);
        }

    }
    public void displayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: " + salary);
    }
    public static void Main()
    {
        EmployeeRecords employee = new EmployeeRecords(101, "IT", 75000.00);
        employee.displayEmployeeDetails();
        employee.SetSalary(80000.00); //modifying private variable using method
        Manager manager = new Manager(102, "HR", 90000.00);
        manager.ShowemployeeID();
        manager.ShowDepartment();
    }




}