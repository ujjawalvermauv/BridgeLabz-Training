using System;
class Employee
{
    // Attributes
    public string Name;
    public int ID;
    public double salary;
    public Employee(string name, int id, double salary) //constructor
    {
        Name = name;
        ID = id;
        this.salary = salary;
    }
    public virtual void DisplayDetails() //virtual method
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee ID: " + ID);
        Console.WriteLine("Employee Salary: " + salary);
    }

}
class Manager : Employee
{
    public int teamSize;
    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        this.teamSize = teamSize;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + teamSize);
    }



}
class Developer : Employee
{
    public string programminglanguage;
    public Developer(string name, int id, double salary, string programminglanguage) : base(name, id, salary)
    {
        this.programminglanguage = programminglanguage;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: " + Programminglanguage);
    }
}
class Intern : Employee
{
    public string InternshipDuration;
    public Intern(string name, int id, double salary, string InternshipDuration) : base(name, id, salary)
    {
        this.InternshipDuration = InternshipDuration;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + InternshipDuration);
    }
}
class EmployeeManagementSystem
{
    public static void Main()
    {
        Employee emp1 = new Manager("Amar", 101, 90000, 10);
        Employee emp2 = new Developer("Bobby", 102, 80000, "C#");
        Employee emp3 = new Intern("Gupta", 103, 30000, "6 months");

        emp1.DisplayDetails();
        Console.WriteLine();
        emp2.DisplayDetails();
        Console.WriteLine();
        emp3.DisplayDetails();
    }
}
