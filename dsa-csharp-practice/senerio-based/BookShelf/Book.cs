public class Book
{
    private string title;
    private string author;
    private string genre;
    private string isbn;

    public Book(string title, string author, string genre, string isbn)
    {
        this.title = title;
        this.author = author;
        this.genre = genre;
        this.isbn = isbn;
    }

    public string Genre => genre;
    public string ISBN => isbn;

    public override string ToString()
    {
        return title + " by " + author + " [ISBN: " + isbn + "]";
    }
}
