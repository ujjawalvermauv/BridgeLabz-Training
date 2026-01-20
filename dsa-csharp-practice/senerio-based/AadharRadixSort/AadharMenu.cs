using System;

namespace AadharRadixSort
{
    class AadharMenu
    {
        public static void Show()
        {
            AadharUtility service = new AadharUtility();
            int choice;

            do
            {
                Console.WriteLine("\n===== Aadhar Radix Sort Menu =====");
                Console.WriteLine("1. Add Aadhar Number");
                Console.WriteLine("2. Sort Aadhar Numbers (Radix Sort)");
                Console.WriteLine("3. Search Aadhar (Binary Search)");
                Console.WriteLine("4. Display All");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter 12-digit Aadhar: ");
                        string num = Console.ReadLine();
                        service.AddAadhar(num);
                        break;

                    case 2:
                        service.RadixSort();
                        Console.WriteLine("Sorted successfully (stable).");
                        break;

                    case 3:
                        Console.Write("Enter Aadhar to search: ");
                        string search = Console.ReadLine();
                        int index = service.BinarySearch(search);

                        if (index != -1)
                            Console.WriteLine("Found at index: " + index);
                        else
                            Console.WriteLine("Not found.");
                        break;

                    case 4:
                        service.Display();
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 5);
        }
    }
}
