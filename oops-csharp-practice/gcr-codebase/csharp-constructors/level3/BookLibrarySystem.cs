using System;
public class BookLibrarySystem
{
    public long ISBN;
    protected string title;
    private string author;
    public BookLibrarySystem(long ISBN, string title, string author) //constructor
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }
    public void SetAuthor(string author) // method to modify private variable
    {
        this.author = author;
    }
    public string GetAuthor() // method to access private variable
    {
        return author;
    }
    class EBook : BookLibrarySystem // derived class
    {
        public EBook(long ISBN, string title, string author) : base(ISBN, title, author) // calling base class constructor
        {

        }
        public void ShowTitle() // method to access protected variable
        {
            Console.WriteLine("E-Book Title: " + title);
        }
        public void ShowISBN() // method to access public variable
        {
            Console.WriteLine("E-Book ISBN: " + ISBN);
        }
    }
    public void DisplayBookDetails() // method to display book details
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
    public static void Main()
    {
        BookLibrarySystem book = new BookLibrarySystem(9780131103627, "The C Programming Language", "Brian W. Kernighan");
        book.DisplayBookDetails();
        book.SetAuthor("Dennis M. Ritchie"); // modifying private variable using method
        EBook ebook = new EBook(9780131101630, "The C Programming Language - EBook", "Brian W. Kernighan");
        ebook.ShowTitle(); // accessing protected variable using derived class method
        ebook.ShowISBN(); // accessing public variable using derived class method
    }








}