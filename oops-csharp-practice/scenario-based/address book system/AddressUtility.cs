public class AddressUtility : IAddressBook
{
    private ContactPerson contact;
    public void AddNewContact()
    {
        

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        Console.Write("Enter State: ");
        string state = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        string phone = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        contact = new ContactPerson(firstName, lastName, address, city, state, phone, email);
        Console.WriteLine("\nContact Added Successfully!");
        Console.WriteLine(contact);


        
    }
    // UC-2 Edit Contact
    public void EditContact(string firstName)
    {
        if (contact != null && contact.GetFirstName().Equals(firstName))
        {
            Console.Write("Enter New City: ");
            contact.SetCity(Console.ReadLine());

            Console.Write("Enter New Phone Number: ");
            contact.SetPhoneNumber(Console.ReadLine());

            Console.WriteLine("\nContact Updated!");
            Console.WriteLine(contact);
        }
        else
        {
            Console.WriteLine("\nContact Not Found!");
        }
    }



    
}
