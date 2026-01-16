using System;

class Program
{
    static void Main()
    {
        IBrowserManager browser = new BrowserUtility();
        int choice;
        do
        {
            Console.WriteLine(" BrowserBuddy");
            Console.WriteLine("1. Visit New URL");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Display History");
            Console.WriteLine("5. Close Tab");
            Console.WriteLine("6. Restore Closed Tab");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter URL: ");
                    string url = Console.ReadLine();
                    browser.Visit(url);
                    break;

                case 2:
                    browser.Back();
                    break;

                case 3:
                    browser.Forward();
                    break;

                case 4:
                    browser.DisplayHistory();
                    break;

                case 5:
                    browser.CloseTab();
                    break;

                case 6:
                    browser.RestoreTab();
                    break;

                case 0:
                    Console.WriteLine("Exit BrowserBuddy");
                    break;

                default:
                    Console.WriteLine("Invalid choice....!");
                    break;
            }

        } while (choice != 0);
    }
}
