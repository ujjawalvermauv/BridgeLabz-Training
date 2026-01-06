using System;

//Abstraction: Interface for Billing
interface IPayable
{
    void GenerateBill();
}

//Base Class: Common Patient concepts
class Patient
{
    // Encapsulation: Property to manage Name
    public string Name { get; set; }
    public Patient(string name)
    {
        Name = name;
    }

    // Polymorphism: Virtual method to be customized by child classes
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Patient: " + Name);
    }
}

// Inheritance: InPatient is a Patient
class InPatient : Patient, IPayable
{
    public int DaysStayed { get; set; }

    public InPatient(string name, int days) : base(name)
    {
        DaysStayed = days;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("In-Patient: " + Name + " | Days: " + DaysStayed);
    }

    public void GenerateBill()
    {
        int total = DaysStayed * 200; // Example: 200 per day
        Console.WriteLine("Total Bill: " + total);
    }
}

// 4. Inheritance: OutPatient is a Patient
class OutPatient : Patient, IPayable
{
    public OutPatient(string name) : base(name) { }
    public void GenerateBill()
    {
        Console.WriteLine("Total Bill: Fixed Fee 50");
    }
}

// MAIN Execution
class HospitalSystem
{
    static void Main()
    {
        InPatient p1 = new InPatient("Amar", 4);
        OutPatient p2 = new OutPatient("Maxy");
        p1.DisplayInfo();
        p1.GenerateBill();
        Console.WriteLine("");
        p2.DisplayInfo();
        p2.GenerateBill();
    }
}