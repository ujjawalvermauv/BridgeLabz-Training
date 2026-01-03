using System;
public class VehicleRegistration
{
    public string ownerName;// Instance Variable
    public string vehicleType;// Instance Variable
    public static int registrationFee = 500; // Class Variable
    public VehicleRegistration(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName; // Using 'this' keyword to resolve ambiguity
        this.vehicleType = vehicleType;
    }
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
        Console.WriteLine();
    }
    public static void UpdateRegistrationFee(int newFee)
    { //A class method UpdateRegistrationFee() to update the registration fee.

        registrationFee = newFee;
    }
    public static void Main()
    {
        VehicleRegistration vehicle1 = new VehicleRegistration("Ujjawal Verma", "Car");
        VehicleRegistration vehicle2 = new VehicleRegistration("Amit Kumar", "Motorbike");
        // using static method to update registration fee
        VehicleRegistration.UpdateRegistrationFee(600);
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }




}