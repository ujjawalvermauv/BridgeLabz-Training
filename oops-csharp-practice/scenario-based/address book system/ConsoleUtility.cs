using System;

class ConsoleUtility
{
    // Take person details from console
    public static Person GetPersonDetails()
    {
        Person person = new Person();

        Console.Write("Enter First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();

        Console.Write("Enter Address: ");
        person.Address = Console.ReadLine();

        Console.Write("Enter City: ");
        person.City = Console.ReadLine();

        Console.Write("Enter State: ");
        person.State = Console.ReadLine();

        Console.Write("Enter Zip: ");
        person.Zip = Console.ReadLine();

        Console.Write("Enter Phone: ");
        person.Phone = Console.ReadLine();

        Console.Write("Enter Email: ");
        person.Email = Console.ReadLine();

        return person;
    }
}
