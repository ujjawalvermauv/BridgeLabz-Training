using System;

class BookNode
{
    public int Id;
    public string Title;
    public bool Available;
    public BookNode Prev;
    public BookNode Next;

    public BookNode(int id, string title) // Constructor
    {
        Id = id;
        Title = title;
        Available = true;
    }
}

class Library
{
    private BookNode head; // Points to the first book
    private BookNode tail; // Points to the last book

    public void AddBook(int id, string title) // Add book to the end
    {
        BookNode book = new BookNode(id, title); // Create new book node

        if (head == null)
        {
            head = tail = book;
            return;
        }

        tail.Next = book;
        book.Prev = tail;
        tail = book;
    }

    public void Display() // Display all books
    {
        BookNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("ID: " + temp.Id + ", Title: " + temp.Title + ", Available: " + temp.Available);
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        Library lib = new Library();
        lib.AddBook(1, "C#");
        lib.AddBook(2, "DSA");
        lib.Display();
    }
}
