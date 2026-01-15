using System;


class AddressBook : IAddressBook
{
public void AddContact(Contact contact)
{
Console.WriteLine("Contact Added:");
Console.WriteLine(contact);
}
}