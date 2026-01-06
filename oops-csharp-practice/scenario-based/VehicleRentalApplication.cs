using System;

//Interface: Common behavior for all rentable items
interface IRentable {
    void CalculateRent(int days);
}

//Base Class: Common Vehicle concepts
class Vehicle {
    // Access Modifier: Protected (Visible to Car/Bike, but hidden from Main)
    protected string regNumber;
    protected int dailyRate;

    public Vehicle(string reg, int rate) {
        regNumber = reg;
        dailyRate = rate;
    }
}

//Inheritance: Car inherits from Vehicle
class Car : Vehicle, IRentable {
    public Car(string reg, int rate) : base(reg, rate) { }

    public void CalculateRent(int days) {
        int total = dailyRate * days;
        Console.WriteLine("Car " + regNumber + " Rent for " + days + " days: " + total);
    }
}

// Inheritance: Bike inherits from Vehicle
class Bike : Vehicle, IRentable {
    public Bike(string reg, int rate) : base(reg, rate) { }

    public void CalculateRent(int days) {
        int total = dailyRate * days;
        Console.WriteLine("Bike " + regNumber + " Rent for " + days + " days: " + total);
    }
}
class RentalSystem {
    static void Main() {
        Car myCar = new Car("CAR-4", 100);
        Bike myBike = new Bike("BIKE-11", 30);
        myCar.CalculateRent(3);  
        myBike.CalculateRent(5);
    }
}