using System;

// Superclass
class Book
{
    public string Title;
    public int PublicationYear;

    public Book(string title, int year)
    {
        Title = title;
        PublicationYear = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

// Subclass
class Author : Book
{
    public string Name;
    public string Bio;

    public Author(string title, int year, string name, string bio)
        : base(title, year)
    {
        Name = name;
        Bio = bio;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Author Bio: " + Bio);
    }
}

class LibrarySystem
{
    static void Main()
    {
        Author book = new Author("Avengers Endgame", 2008, "Robert d junior", "Software engineering expert");

        book.DisplayInfo();
    }
}
