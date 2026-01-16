
public class Vehicle
{
    private string vehicleNumber;
    public Vehicle Next;

    public Vehicle(string number)
    {
        vehicleNumber = number;
        Next = null;
    }

    public string VehicleNumber
    {
        get { return vehicleNumber; }
    }
}
