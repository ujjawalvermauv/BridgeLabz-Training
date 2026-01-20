using System;

namespace ParcelTracker
{
    class ParcelUtility : IParcelTracker
    {
        private ParcelNode head;

        public void AddStage(string stage)
        {
            ParcelNode node = new ParcelNode(stage);

            if (head == null)
            {
                head = node;
                return;
            }

            ParcelNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = node;
        }

        public void AddAfter(string existingStage, string newStage)
        {
            ParcelNode temp = head;

            while (temp != null)
            {
                if (temp.Stage == existingStage)
                {
                    ParcelNode node = new ParcelNode(newStage);
                    node.Next = temp.Next;
                    temp.Next = node;
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Stage not found.");
        }

        public void TrackParcel()
        {
            if (head == null)
            {
                Console.WriteLine("Parcel lost! No tracking available.");
                return;
            }

            ParcelNode temp = head;
            Console.Write("Tracking Path: ");

            while (temp != null)
            {
                Console.Write(temp + " -> ");
                temp = temp.Next;
            }

            Console.WriteLine("END");
        }
    }
}
