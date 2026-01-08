using System;
public interface IControllable
{
    void TurnOn();
    void TurnOff();
}
public class Appliance
{
    private string name;
    public Appliance(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }
    public void SetName(string name)
    {
        this.name = name;
    }


}
public class Light : Appliance, IControllable
{
    public Light(string name) : base(name) { }
    public void TurnOn()
    {
        System.Console.WriteLine(" light is turned ON." + GetName());
    }
    public void TurnOff()
    {
        System.Console.WriteLine(" light is turned OFF." + GetName());
    }
}
public class fan : Appliance, IControllable
{
    public fan(string name) : base(name) { }
    public void TurnOn()
    {
        System.Console.WriteLine("fan is turned ON." + GetName());
    }
    public void TurnOff()
    {
        System.Console.WriteLine("fan is turned OFF." + GetName());
    }
}
public class AC : Appliance, IControllable
{
    public AC(string name) : base(name) { }
    public void TurnOn()
    {
        System.Console.WriteLine(" AC is turned ON." + GetName());
    }
    public void TurnOff()
    {
        System.Console.WriteLine(" AC is turned OFF." + GetName());
    }
}
class SmartHome
{
    public static void Main(string[] args)
    {
        Appliance livingRoomLight = new Light("Living Room");
        Appliance bedroomFan = new fan("Bedroom");
        Appliance kitchenAC = new AC("Kitchen");
        (livingRoomLight as IControllable).TurnOn();
        (bedroomFan as IControllable).TurnOn();
        (kitchenAC as IControllable).TurnOff();
        (livingRoomLight as IControllable).TurnOff();

    }

}