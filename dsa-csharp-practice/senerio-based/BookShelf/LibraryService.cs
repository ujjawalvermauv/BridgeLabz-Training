
public class LibraryService : ILibraryService
{
    private MyHashMap library = new MyHashMap();
    private MyHashSet isbnSet = new MyHashSet();

    public void AddBook(Book book)
    {
        if (isbnSet.Contains(book.ISBN))
        {
            System.Console.WriteLine("Duplicate ISBN not allowed");
            return;
        }

        BookLinkedList list = library.PutIfAbsent(book.Genre);
        list.Add(book);
        isbnSet.Add(book.ISBN);

        System.Console.WriteLine("Book Added Successfully");
    }

    public void RemoveBook(string isbn)
    {
        System.Console.WriteLine("Remove feature demo");
    }

    public void DisplayLibrary()
    {
        library.DisplayAll();
    }
}
