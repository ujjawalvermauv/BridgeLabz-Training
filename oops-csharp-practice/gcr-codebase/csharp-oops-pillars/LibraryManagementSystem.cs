using System;

// Interface for reserving items
interface IReservable
{
    void ReserveItem();        // Reserve the item
    bool CheckAvailability();  // Check if item is available
}

// Abstract class for library items
abstract class LibraryItem
{
    private int itemId;          // Encapsulation
    private string title;
    private string author;

    protected bool isAvailable = true;

    // Properties
    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    // Constructor
    public LibraryItem(int id, string title, string author)
    {
        ItemId = id;
        Title = title;
        Author = author;
    }

    // Concrete method
    public void GetItemDetails()
    {
        Console.WriteLine("ID: " + ItemId);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
    }

    // Abstract method
    public abstract int GetLoanDuration();
}

// Book class
class Book : LibraryItem, IReservable
{
    public Book(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // 14 days
    }

    public void ReserveItem()
    {
        isAvailable = false;
        Console.WriteLine("Book reserved");
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// Magazine class
class Magazine : LibraryItem, IReservable
{
    public Magazine(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // 7 days
    }

    public void ReserveItem()
    {
        isAvailable = false;
        Console.WriteLine("Magazine reserved");
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// DVD class
class DVD : LibraryItem, IReservable
{
    public DVD(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; // 3 days
    }

    public void ReserveItem()
    {
        isAvailable = false;
        Console.WriteLine("DVD reserved");
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// Main class
class LibrarySystem
{
    static void Main()
    {
        // Polymorphism
        LibraryItem item1 = new Book(101, "C# Basics", "John cena");
        LibraryItem item2 = new Magazine(102, "Tech Monthly", "Roman Reigns");
        LibraryItem item3 = new DVD(103, "Learning OOP", "The Rock");

        item1.GetItemDetails();
        Console.WriteLine("Loan Duration: " + item1.GetLoanDuration() + " days\n");

        item2.GetItemDetails();
        Console.WriteLine("Loan Duration: " + item2.GetLoanDuration() + " days\n");

        item3.GetItemDetails();
        Console.WriteLine("Loan Duration: " + item3.GetLoanDuration() + " days\n");

        // Interface usage
        IReservable reserveItem = (IReservable)item1;
        reserveItem.ReserveItem();
        Console.WriteLine("Available: " + reserveItem.CheckAvailability());
    }
}
