abstract class WarehouseItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public abstract void Display();
}

class Electronics : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine("Electronics: " + Name + ", Qty: " + Quantity);
    }
}

class Groceries : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine("Grocery: " + Name + ", Qty: " + Quantity);
    }
}

class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void ShowItems()
    {
        foreach (T item in items)
        {
            item.Display();
        }
    }
}
class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();

        Electronics e1 = new Electronics
        {
            Name = "Laptop",
            Quantity = 5
        };

        Electronics e2 = new Electronics
        {
            Name = "Mobile",
            Quantity = 10
        };

        electronicsStorage.AddItem(e1);
        electronicsStorage.AddItem(e2);

        electronicsStorage.ShowItems();
    }
}
