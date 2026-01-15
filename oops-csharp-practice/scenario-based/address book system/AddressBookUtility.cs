using System;

class AddressBookUtility : IAddressBook
{
    // Add single contact
    public void AddContact(Person person)
    {
        Console.WriteLine("Contact added successfully");
        Console.WriteLine(person); // Calls ToString()
    }
    public void EditContact(string firstName)
    {
        if (storedPerson != null && storedPerson.FirstName == firstName)
        {
            Console.Write("Enter new City: ");
            storedPerson.City = Console.ReadLine();

            Console.WriteLine("Contact updated");
            Console.WriteLine(storedPerson);
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }
    public void DeleteContact(string firstName){ // for delete
    if (storedPerson != null && storedPerson.FirstName == firstName)
    {
        storedPerson = null;
        Console.WriteLine("Contact deleted");
    }
    else
    {
        Console.WriteLine("Contact not found");
    }
    }
    class AddressBookUtility : IAddressBook{ // store multiple contact using list
    private List<Person> persons = new List<Person>();

    public void AddContact(Person person)
    {
        persons.Add(person);
        Console.WriteLine("Contact added");
    }
}
}
