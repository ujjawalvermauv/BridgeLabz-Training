using System;

class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public string BookingTime;
    public TicketNode Next;

    public TicketNode(int id, string customer, string movie, int seat, string time)
    {
        TicketId = id;
        CustomerName = customer;
        MovieName = movie;
        SeatNumber = seat;
        BookingTime = time;
        Next = null;
    }
}

class TicketSystem
{
    private TicketNode head;
    private int count = 0;

    // Add ticket at end
    public void AddTicket(int id, string customer, string movie, int seat, string time)
    {
        TicketNode node = new TicketNode(id, customer, movie, seat, time);
        count++;

        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }

        TicketNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }

    // Remove ticket by ID
    public void RemoveTicket(int id)
    {
        if (head == null) return;

        TicketNode curr = head;
        TicketNode prev = null;

        do
        {
            if (curr.TicketId == id)
            {
                if (prev != null)
                {
                    prev.Next = curr.Next;
                }
                else
                {
                    TicketNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                count--;
                return;
            }
            prev = curr;
            curr = curr.Next;

        } while (curr != head);
    }

    // Search by customer name
    public void SearchByCustomer(string name)
    {
        if (head == null) return;

        TicketNode temp = head;
        do
        {
            if (temp.CustomerName == name)
                PrintTicket(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    // Search by movie name
    public void SearchByMovie(string movie)
    {
        if (head == null) return;

        TicketNode temp = head;
        do
        {
            if (temp.MovieName == movie)
                PrintTicket(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    // Display all tickets
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No Tickets Booked");
            return;
        }

        TicketNode temp = head;
        do
        {
            PrintTicket(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    // Count tickets
    public void CountTickets()
    {
        Console.WriteLine("Total Tickets Booked: " + count);
    }

    // Helper method
    private void PrintTicket(TicketNode t)
    {
        Console.WriteLine("ID: " + t.TicketId + ", Customer: " + t.CustomerName + ", Movie: " + t.MovieName + ", Seat: " + t.SeatNumber + ", Time: " + t.BookingTime);
    }
}

class Program
{
    static void Main()
    {
        TicketSystem ts = new TicketSystem();

        ts.AddTicket(1, "Aman", "Inception", 12, "10:00 AM");
        ts.AddTicket(2, "Riya", "Inception", 15, "10:05 AM");
        ts.AddTicket(3, "Karan", "Avatar", 20, "10:10 AM");

        Console.WriteLine("All Tickets:");
        ts.Display();

        Console.WriteLine("\nSearch by Movie:");
        ts.SearchByMovie("Inception");

        Console.WriteLine("\nRemoving Ticket ID 2");
        ts.RemoveTicket(2);

        Console.WriteLine("\nAfter Removal:");
        ts.Display();

        ts.CountTickets();
    }
}
