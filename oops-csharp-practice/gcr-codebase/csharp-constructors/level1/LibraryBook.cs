using System;

public class LibraryBook
{
    private string title;
    private string author;
    private double price;
    private string availabilityStatus;

    ////  borrowbook()
    public void BorrowBook()
    {
        if (availabilityStatus == "Available")
        {
            availabilityStatus = "Borrowed";
            Console.WriteLine("You have successfully borrowed the book: " + title);
        }
        else
        {
            Console.WriteLine("Sorry, the book: " + title + " is currently not available.");
        }
    }
    // main method
    public static void Main()
    {
        // creating object using parameterized constructor
        LibraryBook book1 = new LibraryBook();
        book1.title = "The Alchemist";
        book1.author = "narendra modi";
        book1.price = 250.50;
        book1.availabilityStatus = "Available";

        // displaying book details before borrowing
        Console.WriteLine("Book Title: " + book1.title);
        Console.WriteLine("Book Author: " + book1.author);
        Console.WriteLine("Book Price: " + book1.price);
        Console.WriteLine("Availability Status: " + book1.availabilityStatus);
        Console.WriteLine();

        // borrowing the book
        book1.BorrowBook();

        // displaying book details after borrowing
        Console.WriteLine();
        Console.WriteLine("Updated Availability Status: " + book1.availabilityStatus);
    }



}