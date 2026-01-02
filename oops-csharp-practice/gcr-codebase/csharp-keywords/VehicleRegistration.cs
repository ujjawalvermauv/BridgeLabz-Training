using System;
class VehicleRegistration
{
    public static int RegistrationFee = 500;
    public string ownerName;
    public readonly int RegistrationNumber;
    public string vehicleType;
    public static void UpdateRegistrationFee(int newFee)
    {
        RegistrationFee = newFee;
    }
    public VehicleRegistration(string ownerName, string vehicleType, int RegistrationNumber)
    {
        this.ownerName = ownerName;
        this.RegistrationNumber = RegistrationNumber;
        this.vehicleType = vehicleType;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Number: " + RegistrationNumber);
        Console.WriteLine("Registration Fee: " + RegistrationFee);
    }
    public static void Main()
    {
        VehicleRegistration alto = new VehicleRegistration("Ujjawal Verma", "Car", 12345);
        VehicleRegistration bike = new VehicleRegistration("Amit Kumar", "Motorbike", 67890);
        // using static method to update registration fee
        VehicleRegistration.UpdateRegistrationFee(600);
        // using 'is' operator before displaying details    
        if (alto is VehicleRegistration)
        {
            Console.WriteLine("\nAlto Vehicle Details:");
            alto.DisplayDetails();
        }
        if (bike is VehicleRegistration)
        {
            Console.WriteLine("\nBike Vehicle Details:");
            bike.DisplayDetails();
        }

    }





}