using System;

public class Roundabout
{
    private Vehicle tail;

    // Proper expression-bodied METHOD
    public bool IsEmpty()
    {
        return tail == null;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        if (vehicle == null)
        {
            Console.WriteLine("Invalid vehicle!");
            return;
        }

        if (tail == null)
        {
            tail = vehicle;
            tail.Next = tail; // circular link
        }
        else
        {
            vehicle.Next = tail.Next;
            tail.Next = vehicle;
            tail = vehicle;
        }
    }

    public void RemoveVehicle()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Roundabout empty!");
            return;
        }

        // Only one vehicle
        if (tail.Next == tail)
        {
            Console.WriteLine("Vehicle exited: " + tail.VehicleNumber);
            tail = null;
        }
        else
        {
            Vehicle head = tail.Next;
            Console.WriteLine("Vehicle exited: " + head.VehicleNumber);
            tail.Next = head.Next;
        }
    }

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Roundabout empty!");
            return;
        }

        Vehicle temp = tail.Next;

        do
        {
            Console.Write(temp.VehicleNumber + " -> ");
            temp = temp.Next;
        }
        while (temp != tail.Next);

        Console.WriteLine("(Back to Start)");
    }
}
