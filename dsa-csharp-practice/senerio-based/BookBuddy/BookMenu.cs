using System;
using System.Collections.Concurrent;
using System.Xml.Serialization;

// Displays the book menu and handles user interaction
public class BookMenu
{
    IBookManager bookManager;

    public void ShowMenu()
    {
        int choice;
        bookManager = new BookManagerUtility();
        do
        {
            System.Console.WriteLine("1 Add Book");
            System.Console.WriteLine("2 : sort books alphabetically");
            System.Console.WriteLine("3 : search by author");
            System.Console.WriteLine("4:display books");
            System.Console.WriteLine("5: exit");
            System.Console.WriteLine("");
            Console.Write("Enter Your Choice : ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    bookManager.AddBook();
                    break;
                case 2:
                    bookManager.SortBooksAlphabetically();
                    break;
                case 3:
                    bookManager.SearchByAuthor();
                    break;
                case 4:
                    bookManager.DisplayBooks();
                    break;
                case 5:
                    System.Console.WriteLine("exit");
                    break;
                default:
                    System.Console.WriteLine("WRONG CHOICE");
                    break;
            }
        } while (choice != 5);
    }
}
