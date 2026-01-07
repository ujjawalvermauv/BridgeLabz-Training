using System;

// Interface
interface IMedicalRecord
{
    void AddRecord();
    void ViewRecord();
}

// Abstract class
abstract class Patient
{
    protected int patientId;
    protected string name;
    protected int age;

    private string diagnosis; // Encapsulation

    public Patient(int id, string name, int age)
    {
        patientId = id;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

// InPatient class
class InPatient : Patient, IMedicalRecord
{
    public InPatient(int id, string name, int age)
        : base(id, name, age) { }

    public override double CalculateBill()
    {
        return 5000;
    }

    public void AddRecord()
    {
        Console.WriteLine("InPatient record added");
    }

    public void ViewRecord()
    {
        Console.WriteLine("Viewing InPatient record");
    }
}

// OutPatient class
class OutPatient : Patient, IMedicalRecord
{
    public OutPatient(int id, string name, int age)
        : base(id, name, age) { }

    public override double CalculateBill()
    {
        return 800;
    }

    public void AddRecord()
    {
        Console.WriteLine("OutPatient record added");
    }

    public void ViewRecord()
    {
        Console.WriteLine("Viewing OutPatient record");
    }
}

// Main class
class HospitalApp
{
    static void Main()
    {
        Patient p1 = new InPatient(1, "Aman", 30);
        Patient p2 = new OutPatient(2, "Riya", 25);

        p1.GetPatientDetails();
        Console.WriteLine("Bill: " + p1.CalculateBill());

        p2.GetPatientDetails();
        Console.WriteLine("Bill: " + p2.CalculateBill());
    }
}
