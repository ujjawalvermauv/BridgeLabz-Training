
using System;

class Program
{
    static void Main()
    {
        TrafficManager manager = new TrafficManager();
        int choice;

        do
        {
            Console.WriteLine("\n1.Add Vehicle 2.Remove Vehicle 3.Display 0.Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter vehicle number: ");
                    manager.AddCar(Console.ReadLine());
                    break;
                case 2:
                    manager.RemoveCar();
                    break;
                case 3:
                    manager.DisplayStatus();
                    break;
            }
        } while (choice != 0);
    }
}
