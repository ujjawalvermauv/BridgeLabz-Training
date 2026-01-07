using System;

// Interface
interface IGPS
{
    void UpdateLocation();
}

// Abstract class
abstract class Vehicle
{
    protected int vehicleId;
    protected string driverName;
    protected double ratePerKm;

    public Vehicle(int id, string driver, double rate)
    {
        vehicleId = id;
        driverName = driver;
        ratePerKm = rate;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleId);
        Console.WriteLine("Driver Name: " + driverName);
    }
}

// Car class
class Car : Vehicle, IGPS
{
    public Car(int id, string driver)
        : base(id, driver, 15) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public void UpdateLocation()
    {
        Console.WriteLine("Car location updated");
    }
}

// Bike class
class Bike : Vehicle, IGPS
{
    public Bike(int id, string driver)
        : base(id, driver, 8) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public void UpdateLocation()
    {
        Console.WriteLine("Bike location updated");
    }
}

// Auto class
class Auto : Vehicle, IGPS
{
    public Auto(int id, string driver)
        : base(id, driver, 10) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public void UpdateLocation()
    {
        Console.WriteLine("Auto location updated");
    }
}

// Main class
class RideApp
{
    static void Main()
    {
        Vehicle v1 = new Car(1, "Ramesh");
        Vehicle v2 = new Bike(2, "Suresh");
        Vehicle v3 = new Auto(3, "Mahesh");

        Console.WriteLine("Car Fare: " + v1.CalculateFare(10));
        Console.WriteLine("Bike Fare: " + v2.CalculateFare(10));
        Console.WriteLine("Auto Fare: " + v3.CalculateFare(10));
    }
}
