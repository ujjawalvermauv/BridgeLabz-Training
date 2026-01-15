using System;


class AddressBook : IAddressBook
{
public void AddContact(Contact contact)
{
Console.WriteLine("Contact Added:");
Console.WriteLine(contact);
}
public void EditContact(string firstName,Contact updated)
    {
        if(firstName == updated.FirstName)
        {
            System.Console.WriteLine("Contact Updated");
            System.Console.WriteLine(updated);
        }
    }
}