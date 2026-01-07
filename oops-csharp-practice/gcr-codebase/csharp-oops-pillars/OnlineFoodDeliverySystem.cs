using System;

// Interface
interface IDiscountable
{
    void ApplyDiscount();
}

// Abstract class
abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    public FoodItem(string name, double price, int quantity)
    {
        this.itemName = name;
        this.price = price;
        this.quantity = quantity;
    }

    // Abstract method
    public abstract double CalculateTotalPrice();

    // Normal method
    public void GetItemDetails()
    {
        Console.WriteLine("Item Name: " + itemName);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Quantity: " + quantity);
    }
}

// Veg Item
class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return price * quantity;
    }

    public void ApplyDiscount()
    {
        price = price - 10;
    }
}

// Non Veg Item
class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (price * quantity) + 30;
    }

    public void ApplyDiscount()
    {
        price = price - 5;
    }
}

// Main class
class FoodApp
{
    static void Main()
    {
        FoodItem f1 = new VegItem("Veg Burger", 100, 2);
        FoodItem f2 = new NonVegItem("Chicken Burger", 150, 1);

        f1.GetItemDetails();
        Console.WriteLine("Total Price: " + f1.CalculateTotalPrice());

        f2.GetItemDetails();
        Console.WriteLine("Total Price: " + f2.CalculateTotalPrice());
    }
}
