using System;

public class Book
{
    //attribute
    private string title;
    private string author;
    private double price;


    //parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }
    //default constructor
    public Book()
    {
        title = "unknown";
        author = "unknown";
        price = 0.0;
    }
    //method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Book Author: " + author);
        Console.WriteLine("Book Price: " + price);
    }
    //main method 
    public static void Main()
    {
        //creating object using parameterized constructor
        Book book1 = new Book("The family man", "Manoj Bajpai", 300.77);
        //creating object using default constructor
        Book book2 = new Book();

        //displaying book details
        book1.DisplayDetails();
        Console.WriteLine();
        book2.DisplayDetails();
    }

}