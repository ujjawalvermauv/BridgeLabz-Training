using System;
public class CarRental
{
    //Fields (attributes)
    private string customerName;
    private string carModel;
    private int rentalDays;
    //parameterised constructor(rental details)
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }
    //default constructor
    public CarRental()
    {
        customerName = "Guest";
        carModel = "Standard";
        rentalDays = 1;
    }
    //calculate the total rental cost
    public double CalculateRentalCost(double dailyRate)
    {
        return rentalDays * dailyRate;
    }
    //display rental details
    public void DisplayRentalDetails(double dailyRate)
    {
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Rental Days: " + rentalDays);
        Console.WriteLine("Total Rental Cost: " + CalculateRentalCost(dailyRate));
    }
    //main method
    public static void Main()
    {
        //creating object using parameterized constructor
        CarRental rental1 = new CarRental("ujjawal", "Toyota", 5);
        CarRental rental2 = new CarRental("harsh", "Honda", 3);

        //displaying rental details
        rental1.DisplayRentalDetails(50); //assuming daily rate is 50
        Console.WriteLine();
        rental2.DisplayRentalDetails(60); //assuming daily rate is 60
    }


}