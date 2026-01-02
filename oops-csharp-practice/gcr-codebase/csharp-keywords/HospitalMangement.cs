using System;
class HospitalManagement
{
    public static string HospitalName = "Fortis Noida ";
    public string PatientName;
    public int PatientAge;
    public string Ailment;
    public static int TotalPatients = 0; // static field
    public readonly string PatientID;// readonly field
    //constructor
    public HospitalManagement(string PatientName, int PatientAge, string Ailment, string PatientID)
    {
        this.PatientName = PatientName;
        this.PatientAge = PatientAge;
        this.Ailment = Ailment;
        this.PatientID = PatientID;
        TotalPatients++;
    }
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + TotalPatients);

    }
    public void DisplayPatientInfo()
    {
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Patient ID: " + PatientID);
        Console.WriteLine("Patient Name: " + PatientName);
        Console.WriteLine("Patient Age: " + PatientAge);
        Console.WriteLine("Ailment: " + Ailment);
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        HospitalManagement patient1 = new HospitalManagement("Ujjawal", 30, "Flu", "P001");
        HospitalManagement patient2 = new HospitalManagement("Harsh", 25, "Cold", "P002");
        HospitalManagement.GetTotalPatients();// static method call
        if (patient1 is HospitalManagement)
        {
            patient1.DisplayPatientInfo();
        }
        if (patient2 is HospitalManagement)
        {
            patient2.DisplayPatientInfo();
        }


    }




}