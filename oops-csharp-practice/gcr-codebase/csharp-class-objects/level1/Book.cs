using System;
public class Book
{
    // Fields (Attributes)
    private string title;
    private string author;
    private string price;

    // Constructor
    public Book(string title, string author, string price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }
    //method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("title name:" + title);
        Console.WriteLine("author name:" + author);
        Console.WriteLine("price:" + price);

    }
    // Main method to test the Book class
    public static void Main(string[] args)
    {
        // Creating an instance of the Book class
        Book myBook = new Book("Stranger Things", "Duffer brothers", "R-299");
        Book newBook = new Book("The Family Man", "Manoj bajpai", "R-700");

        // Displaying book details
        myBook.DisplayDetails();
        newBook.DisplayDetails();
    }

}