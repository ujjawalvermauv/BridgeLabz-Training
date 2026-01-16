
public class BookLinkedList
{
    private BookNode head;

    public void Add(Book book)
    {
        BookNode node = new BookNode(book);
        node.Next = head;
        head = node;
    }

    public bool Remove(string isbn)
    {
        BookNode curr = head, prev = null;

        while (curr != null)
        {
            if (curr.Data.ISBN == isbn)
            {
                if (prev == null) head = curr.Next;
                else prev.Next = curr.Next;
                return true;
            }
            prev = curr;
            curr = curr.Next;
        }
        return false;
    }

    public void Display()
    {
        BookNode temp = head;
        while (temp != null)
        {
            System.Console.WriteLine("   " + temp.Data);
            temp = temp.Next;
        }
    }
}
