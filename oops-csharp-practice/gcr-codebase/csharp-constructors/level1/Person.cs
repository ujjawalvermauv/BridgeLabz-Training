using System;
public class Person
{
    //fields(attributes)
    private string name;
    private int age;
    private string address;
    //parameterized constructor
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }
    //copy constructor
    public Person(Person p)
    {
        name = p.name;
        age = p.age;
        address = p.address;
    }

    //method to display person details
    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Address: " + address);
    }
    //main method
    public static void Main()
    {
        //creating object using parameterized constructor
        Person person1 = new Person("Ujjawal", 24, "Pune");
        //creating object using copy constructor
        Person person2 = new Person(person1);

        //displaying person details
        person1.DisplayDetails();
        Console.WriteLine();
        person2.DisplayDetails();
    }


}