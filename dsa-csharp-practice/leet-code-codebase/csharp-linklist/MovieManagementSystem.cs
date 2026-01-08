using System;

class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public MovieNode Prev, Next;

    public MovieNode(string t, string d, int y, double r)
    {
        Title = t;
        Director = d;
        Year = y;
        Rating = r;
    }
}

class MovieList
{
    private MovieNode head, tail;

    public void AddAtEnd(string t, string d, int y, double r)
    {
        MovieNode node = new MovieNode(t, d, y, r);

        if (head == null)
        {
            head = tail = node;
            return;
        }

        tail.Next = node;
        node.Prev = tail;
        tail = node;
    }

    public void RemoveByTitle(string t)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.Title == t)
            {
                if (temp == head) head = temp.Next;
                if (temp == tail) tail = temp.Prev;
                if (temp.Prev != null) temp.Prev.Next = temp.Next;
                if (temp.Next != null) temp.Next.Prev = temp.Prev;
                return;
            }
            temp = temp.Next;
        }
    }

    public void UpdateRating(string t, double r)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.Title == t)
            {
                temp.Rating = r;
                return;
            }
            temp = temp.Next;
        }
    }

    public void DisplayForward()
    {
        MovieNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Title + " " + temp.Rating);
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        MovieNode temp = tail;
        while (temp != null)
        {
            Console.WriteLine(temp.Title + " " + temp.Rating);
            temp = temp.Prev;
        }
    }
}

class Program
{
    static void Main()
    {
        MovieList m = new MovieList();
        m.AddAtEnd("Inception", "Nolan", 2010, 9);
        m.DisplayForward();
    }
}
