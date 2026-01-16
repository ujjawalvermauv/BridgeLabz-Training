
public class TrafficManager : ITrafficOperations
{
    private Roundabout roundabout = new Roundabout();
    private VehicleQueue queue = new VehicleQueue(5);

    public void AddCar(string number)
    {
        Vehicle v = new Vehicle(number);

        if (roundabout.IsEmpty())
        {
            roundabout.AddVehicle(v);
            System.Console.WriteLine("Vehicle entered roundabout");
        }
        else
        {
            queue.Enqueue(v);
            System.Console.WriteLine("Vehicle added to queue");
        }
    }

    public void RemoveCar()
    {
        roundabout.RemoveVehicle();
        Vehicle v = queue.Dequeue();
        if (v != null)
            roundabout.AddVehicle(v);
    }

    public void DisplayStatus()
    {
        roundabout.Display();
    }
}
