using System;
class LibManagement
{
    public static string LibraryName = "GaneshLal Lib";
    public string title;
    public string author;
    public readonly int isbn;

    public static void DisplayLibraryName()
    {
        Console.WriteLine("library name is:" + LibraryName);

    }
    public LibManagement(string title, string author, int isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;

    }
    public void DisplayDetails()
    {
        Console.WriteLine("title of book is:" + title);
        Console.WriteLine("author of book is" + author);
        Console.WriteLine("isbn number is" + isbn);
    }
    public static void Main()
    {
        LibManagement book1 = new LibManagement("the family Man", "Manoj Bajpai", 223);
        if (book1 is LibManagement)
        {
            book1.DisplayDetails();
        }


    }






}