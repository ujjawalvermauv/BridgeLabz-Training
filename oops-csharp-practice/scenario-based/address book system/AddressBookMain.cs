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
        //uc5
        List<AddressBook> addressBooks = new List<AddressBook>();
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();
        AddressBook book = new AddressBook(name);
        addressBooks.Add(book);
        Console.WriteLine("Address Book Created");
        //uc8 Ability to search Person in a City or State acrossthe multiple Address Book - Search Result
        Console.Write("Enter City to Search: ");
        string city = Console.ReadLine();
        for (int i = 0; i < addressBooks.Count; i++)
        {
            AddressBook book = addressBooks[i];

            for (int j = 0; j < book.Persons.Count; j++)
            {
                Person p = book.Persons[j];

                if (p.City == city)
                {
                    Console.WriteLine(p);
                }
            }
        }




    }
}
