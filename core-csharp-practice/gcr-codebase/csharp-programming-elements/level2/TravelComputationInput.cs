using System;

class TravelComputationInput
{
    static void Main()
    {
        // Taking traveller name
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        // Taking city names
        Console.Write("Enter from city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter to city: ");
        string toCity = Console.ReadLine();

        // Taking distances
        Console.Write("Enter distance from to via: ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance via to final city: ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Calculating total distance
        double totalDistance = fromToVia + viaToFinalCity;

        // Printing result
        Console.WriteLine("The total distance travelled by " + name + " from " + fromCity + " to " + toCity + " via " + viaCity + " is " + totalDistance);
    }
}
