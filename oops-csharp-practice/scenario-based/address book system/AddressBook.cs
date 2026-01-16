using System.Collections.Generic;

class AddressBook
{
    public string Name { get; set; }
    public List<Person> Persons { get; set; }

    public AddressBook(string name)
    {
        Name = name;
        Persons = new List<Person>();
    }
}
