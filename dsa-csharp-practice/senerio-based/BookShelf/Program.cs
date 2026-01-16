
class Program
{
    static void Main()
    {
        ILibraryService service = new LibraryService();

        while (true)
        {
            System.Console.WriteLine("\n1. Add Book\n2. Display Library\n3. Exit");
            int choice = int.Parse(System.Console.ReadLine());

            if (choice == 1)
            {
                System.Console.Write("Title: ");
                string title = System.Console.ReadLine();
                System.Console.Write("Author: ");
                string author = System.Console.ReadLine();
                System.Console.Write("Genre: ");
                string genre = System.Console.ReadLine();
                System.Console.Write("ISBN: ");
                string isbn = System.Console.ReadLine();

                service.AddBook(new Book(title, author, genre, isbn));
            }
            else if (choice == 2)
            {
                service.DisplayLibrary();
            }
            else
            {
                break;
            }
        }
    }
}
