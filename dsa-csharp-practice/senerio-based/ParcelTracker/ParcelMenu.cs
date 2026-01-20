using System;

namespace ParcelTracker
{
    class ParcelMenu
    {
        public static void Show()
        {
            ParcelUtility tracker = new ParcelUtility();
            int choice;

            do
            {
                Console.WriteLine("\n===== Parcel Tracker Menu =====");
                Console.WriteLine("1. Add Delivery Stage");
                Console.WriteLine("2. Add Custom Checkpoint After Stage");
                Console.WriteLine("3. Track Parcel");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter stage name: ");
                        string stage = Console.ReadLine();
                        tracker.AddStage(stage);
                        Console.WriteLine("Stage added successfully.");
                        break;

                    case 2:
                        Console.Write("Enter existing stage: ");
                        string existing = Console.ReadLine();

                        Console.Write("Enter new checkpoint stage: ");
                        string newStage = Console.ReadLine();

                        tracker.AddAfter(existing, newStage);
                        break;

                    case 3:
                        tracker.TrackParcel();
                        break;

                    case 4:
                        Console.WriteLine("Exiting Parcel Tracker...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
