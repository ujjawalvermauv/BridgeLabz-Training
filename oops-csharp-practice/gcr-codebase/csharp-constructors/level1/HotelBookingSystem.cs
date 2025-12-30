using System;
public class HotelBookingSystem
{
    //Foelds(attributes)
    private string customerName;
    private string roomType;
    private int numberOfNights;

    //default constructor
    public HotelBookingSystem()
    {
        customerName = "Guest";
        roomType = "Standard";
        numberOfNights = 1;
    }
    //parameterized constructor
    public HotelBookingSystem(string customerName, string roomType, int numberOfNights)
    {
        this.customerName = customerName;
        this.roomType = roomType;
        this.numberOfNights = numberOfNights;
    }
    //copy constructor
    public HotelBookingSystem(HotelBookingSystem h)
    {
        customerName = h.customerName;
        roomType = h.roomType;
        numberOfNights = h.numberOfNights;
    }
    //method to display booking details
    public void DisplayBookingDetails()
    {
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Number of Nights: " + numberOfNights);
    }
    //main method
    public static void Main()
    {
        //creating object using default constructor
        HotelBookingSystem booking1 = new HotelBookingSystem();
        //creating object using parameterized constructor
        HotelBookingSystem booking2 = new HotelBookingSystem("ujjawal", "Deluxe", 3);
        //creating object using copy constructor
        HotelBookingSystem booking3 = new HotelBookingSystem(booking2);

        //displaying booking details
        booking1.DisplayBookingDetails();
        Console.WriteLine();
        booking2.DisplayBookingDetails();
        Console.WriteLine();
        booking3.DisplayBookingDetails();
    }

}