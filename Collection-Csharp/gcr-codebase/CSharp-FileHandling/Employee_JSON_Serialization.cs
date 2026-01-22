using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static void Main()
    {
        string path = "employees.json";

        List<Employee> employees = new List<Employee>
        {
            new Employee{Id=1, Name="Amit", Department="IT", Salary=50000},
            new Employee{Id=2, Name="Neha", Department="HR", Salary=45000}
        };

        string json = JsonSerializer.Serialize(employees);
        File.WriteAllText(path, json);

        var readEmployees = JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText(path));

        foreach (var emp in readEmployees)
        {
            Console.WriteLine($"{emp.Id} {emp.Name} {emp.Department} {emp.Salary}");
        }
    }
}
