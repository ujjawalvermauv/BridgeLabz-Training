using System;
class ShoppingCart
{
    public string ProductName;
    public readonly int productID;
    public int price;
    public int quantity;
    public static double discountRate = 0.1; // 10% discount
    public ShoppingCart(string ProductName, int price, int quantity, int productID)
    {

        this.ProductName = ProductName;
        this.price = price;
        this.quantity = quantity;
        this.productID = productID;
    }
    public static void UpdateDiscount(double newRate)
    {
        discountRate = newRate;
    }
    public static void Main()
    {
        Console.WriteLine("Initial Discount Rate: " + discountRate);
        Console.WriteLine("Enter new discount rate:");
        double newRate = double.Parse(Console.ReadLine());
        UpdateDiscount(newRate);
        ShoppingCart cart1 = new ShoppingCart("Lays Chips", 50, 2, 666);
        ShoppingCart cart2 = new ShoppingCart("Coca Cola", 30, 3, 655);

        if (cart1 is ShoppingCart)
        {
            Console.WriteLine("Product ID " + cart1.productID);
            Console.WriteLine("Product: " + cart1.ProductName);
            Console.WriteLine("Price: " + cart1.price);
            Console.WriteLine("Quantity: " + cart1.quantity);
            Console.WriteLine("Discount Rate: " + discountRate);
        }
        if (cart2 is ShoppingCart)
        {
            Console.WriteLine("Product ID " + cart2.productID);
            Console.WriteLine("Product: " + cart1.ProductName);
            Console.WriteLine("Price: " + cart1.price);
            Console.WriteLine("Quantity: " + cart1.quantity);
            Console.WriteLine("Discount Rate: " + discountRate);
        }
    }





}