using System;

public class LibraryManagementSystem
{
    // Store book data in arrays
    private string[] titles = { "Java", "C++", "Python", "JavaScript", "C#" };
    private string[] authors = {
        "James Gosling",
        "Bjarne Stroustrup",
        "Guido van Rossum",
        "Brendan Eich",
        "Anders Hejlsberg"
    };
    private string[] status = {
        "Available",
        "Available",
        "Available",
        "Available",
        "Available"
    };

    // Display all books
    public void DisplayBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        for (int i = 0; i < titles.Length; i++)
        {
            Console.WriteLine(
                "Title: " + titles[i] +
                ", Author: " + authors[i] +
                ", Status: " + status[i]
            );
        }
    }

    // Search book by partial title
    public void SearchBook(string partialTitle)
    {
        Console.WriteLine("\nSearch Results for \"" + partialTitle + "\":");
        bool found = false;

        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].IndexOf(partialTitle, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine(
                    "Title: " + titles[i] +
                    ", Author: " + authors[i] +
                    ", Status: " + status[i]
                );
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No books found.");
        }
    }

    // Check out a book
    public void CheckoutBook(string titleName)
    {
        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].Equals(titleName, StringComparison.OrdinalIgnoreCase))
            {
                if (status[i] == "Available")
                {
                    status[i] = "Checked Out";
                    Console.WriteLine("Book \"" + titles[i] + "\" has been checked out.");
                }
                else
                {
                    Console.WriteLine("Book \"" + titles[i] + "\" is already checked out.");
                }
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    // Return a book
    public void ReturnBook(string titleName)
    {
        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].Equals(titleName, StringComparison.OrdinalIgnoreCase))
            {
                status[i] = "Available";
                Console.WriteLine("Book \"" + titles[i] + "\" has been returned.");
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    // Main Method
    public static void Main(string[] args)
    {
        LibraryManagementSystem library = new LibraryManagementSystem();

        library.DisplayBooks();

        library.SearchBook("Java");

        library.CheckoutBook("Java");

        library.DisplayBooks();

        library.ReturnBook("Java");

        library.DisplayBooks();
    }
}
