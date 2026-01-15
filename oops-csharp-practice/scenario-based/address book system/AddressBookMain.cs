using system;
class AddressBookMain
{
    static void Main(string [] args)
    {
        System.Console.WriteLine("wellcome to Address Book Program ");
        Contact person = new Contact();
        Console.Write("First Name: ");
        person.FirstName = Console.ReadLine();
        AddressBook book = new AddressBook();
        book.AddContact(person);
    }
    
}