using System;

class ItemNode
{
    public int ItemId;
    public string ItemName;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(int id, string name, int qty, double price)
    {
        ItemId = id;
        ItemName = name;
        Quantity = qty;
        Price = price;
        Next = null;
    }
}

class Inventory
{
    private ItemNode head;

    // Add item at beginning
    public void AddItem(int id, string name, int qty, double price)
    {
        ItemNode node = new ItemNode(id, name, qty, price);
        node.Next = head;
        head = node;
    }

    // Remove item by ID
    public void RemoveItem(int id)
    {
        if (head == null) return;

        if (head.ItemId == id)
        {
            head = head.Next;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null && temp.Next.ItemId != id)
            temp = temp.Next;

        if (temp.Next != null)
            temp.Next = temp.Next.Next;
    }

    // Update quantity
    public void UpdateQuantity(int id, int qty)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                temp.Quantity = qty;
                return;
            }
            temp = temp.Next;
        }
    }

    // Calculate total inventory value
    public double TotalValue()
    {
        double sum = 0;
        ItemNode temp = head;

        while (temp != null)
        {
            sum += temp.Quantity * temp.Price;
            temp = temp.Next;
        }
        return sum;
    }

    // Display inventory
    public void Display()
    {
        ItemNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("ID: " + temp.ItemId + ", Name: " + temp.ItemName + ", Qty: " + temp.Quantity + ", Price: " + temp.Price);
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        Inventory inv = new Inventory();

        inv.AddItem(1, "Pen", 10, 5);
        inv.AddItem(2, "Book", 3, 100);
        inv.AddItem(3, "Notebook", 5, 50);

        Console.WriteLine("Inventory List:");
        inv.Display();

        Console.WriteLine("Updating Quantity of Item 1");
        inv.UpdateQuantity(1, 20);

        Console.WriteLine("After Update:");
        inv.Display();

        Console.WriteLine("\nTotal Inventory Value: " + inv.TotalValue());
    }
}
