using System;

class AddressBookMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");

        IAddressBook addressBook = new AddressBookUtility();

        addressBook.AddContact();

        Console.Write("Do you want to edit contact? (yes/no): ");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "yes")
        {
            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();
            addressBook.EditContact(name);
        }
    }
}
