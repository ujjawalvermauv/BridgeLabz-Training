using System;

interface IInsurable // Interface for insurance-related operations
{
    void CalculateInsurance(); // Method to calculate insurance
    double GetInsuranceDetails();// Method to get insurance details

}
abstract class Vehicle
{
    private int vehicleNumber; // Encapsulated property for vehicle number
    private string vehicleType; // Encapsulated property for vehicle type
    protected double rentalRate; // Protected field for rental rate
    public string VehicleType // Getter and Setter for vehicle type
    {
        get { return vehicleType; }
        set { vehicleType = value; }
    }
    public int VehicleNumber // Getter and Setter for vehicle number
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public abstract void CalculateRentalCost(int days); // Abstract method for rental cost calculation
}
class car : Vehicle, IInsurable
{
    private int policyNumber;
    public car(int number, string type, double rate, int policyNum)
    {
        VehicleNumber = number;
        VehicleType = type;
        rentalRate = rate;
        policyNumber = policyNum;
    }
    public override void CalculateRentalCost(int days)
    {
        double totalCost = rentalRate * days;
        Console.WriteLine("Total Rental Cost for Car: " + totalCost);
    }
    public void CalculateInsurance()
    {
        Console.WriteLine("Calculating insurance for Car with Policy Number: " + policyNumber);
    }
    public double GetInsuranceDetails()
    {
        return rentalRate * 0.05; // 5% of rental rate as insurance
    }

}
class bike : Vehicle, IInsurable
{
    private int policyNumber;
    public bike(int number, string type, double rate, int policyNum)
    {
        VehicleNumber = number;
        VehicleType = type;
        rentalRate = rate;
        policyNumber = policyNum;
    }
    public override void CalculateRentalCost(int days)
    {
        double totalCost = rentalRate * days;
        Console.WriteLine("Total Rental Cost for Bike: " + totalCost);
    }
    public void CalculateInsurance()
    {
        Console.WriteLine("Calculating insurance for Bike with Policy Number: " + policyNumber);
    }
    public double GetInsuranceDetails()
    {
        return rentalRate * 0.03; // 3% of rental rate as insurance
    }

}
class Truck : Vehicle, IInsurable
{
    private int policyNumber;
    public Truck(int number, string type, double rate, int policyNum)
    {
        VehicleNumber = number;
        VehicleType = type;
        rentalRate = rate;
        policyNumber = policyNum;
    }
    public override void CalculateRentalCost(int days)
    {
        double totalCost = rentalRate * days;
        Console.WriteLine("Total Rental Cost for Truck: " + totalCost);
    }
    public void CalculateInsurance()
    {
        Console.WriteLine("Calculating insurance for Truck with Policy Number: " + policyNumber);
    }
    public double GetInsuranceDetails()
    {
        return rentalRate * 0.07; // 7% of rental rate as insurance
    }

}
class vehicleRentalSystem
{
    static void Main()
    {
        Vehicle myCar = new car(101, "Sedan", 50.0, 12345);
        myCar.CalculateRentalCost(5);
        IInsurable carInsurance = (IInsurable)myCar;
        carInsurance.CalculateInsurance();
        Console.WriteLine("Car Insurance Cost: " + carInsurance.GetInsuranceDetails());

        Vehicle myBike = new bike(202, "Sport", 20.0, 67890);
        myBike.CalculateRentalCost(3);
        IInsurable bikeInsurance = (IInsurable)myBike;
        bikeInsurance.CalculateInsurance();
        Console.WriteLine("Bike Insurance Cost: " + bikeInsurance.GetInsuranceDetails());

        Vehicle myTruck = new Truck(303, "Pickup", 80.0, 11223);
        myTruck.CalculateRentalCost(7);
        IInsurable truckInsurance = (IInsurable)myTruck;
        truckInsurance.CalculateInsurance();
        Console.WriteLine("Truck Insurance Cost: " + truckInsurance.GetInsuranceDetails());
    }
}