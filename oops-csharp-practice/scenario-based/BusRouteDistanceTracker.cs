using System;
class BusRoteDistanceTracker
{
    public static void Main()
    {
        int totalDistance = 0;
        int stopDistance = 2;
        string choice = "y";
        while (choice == "y" || choice == "Y")
        {
            totalDistance += stopDistance;
            Console.WriteLine("Bus has traveled: " + totalDistance + " km");
            Console.WriteLine("Do you want to continue to the next stop? (y/n): ");
            choice = Console.ReadLine();
        }
        Console.WriteLine("Passenger got off.");
        Console.WriteLine("Final Distance Travelled: " + totalDistance + " km");








    }

}