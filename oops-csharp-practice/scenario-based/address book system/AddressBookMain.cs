using System;

class AddressBookMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");

        // Get person details from console
        Person person = ConsoleUtility.GetPersonDetails();

        // Create address book utility
        AddressBookUtility addressBook = new AddressBookUtility();

        // Add contact
        addressBook.AddContact(person);
        Console.Write("Enter First Name to edit: ");
        string nameToEdit = Console.ReadLine();
        addressBook.EditContact(nameToEdit);
        Console.Write("Enter First Name to delete: ");
        string nameToDelete = Console.ReadLine();
        addressBook.DeleteContact(nameToDelete);


    }
}
