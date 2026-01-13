//Utility class implementing IBookManager interface
using System;

public class BookManagerUtility : IBookManager
{
    private string[] books = new string[100]; // Array to store books
    private int count = 0;

    public void AddBook()
    {
        if (count >= books.Length)
        {
            Console.WriteLine("Bookshelf is full. Cannot add more books.");
            return;
        }
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();
        Console.Write("Enter book author: ");
        string author = Console.ReadLine();
        Book newBook = new Book(title, author);
        books[count++] = newBook.ToString();
    }

    public void SortBooksAlphabetically()
    {
        for(int i = 0; i < count - 1; i++)
        {
            for(int j = i + 1; j < count; j++)
            {
                string bookA = books[i].Split('-')[0];
                string bookB = books[j].Split('-')[0];
                if(string.Compare(bookA, bookB) > 0)
                {
                    string temp = books[i];
                    books[i] = books[j];
                    books[j] = temp;
                }
            }
        }
        Console.WriteLine("Books sorted alphabetically");
    }

    public void SearchByAuthor()
    {
        Console.Write("Enter author name to search: ");
        string author = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            string AuthorNameInBook = books[i].Split('-')[1];
            string bookAuthor = AuthorNameInBook;

            if (AuthorNameInBook.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(books[i]);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine(" No books found by " + author);
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Your Bookshelf:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(books[i]);
        }
    }
}
