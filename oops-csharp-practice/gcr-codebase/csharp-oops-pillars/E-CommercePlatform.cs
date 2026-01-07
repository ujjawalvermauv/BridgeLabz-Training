using System;
interface ITaxable
{
    double CalculateTax(); // Method to calculate tax
    double GetTaxDetails(); // Method to get tax details
}
abstract class Product
{
    private string productId; // Encapsulated property for product ID
    private string productName; // Encapsulated property for product name
    protected double price; // Protected field for product price
    public abstract void CalculateDiscount(); // Abstract method for discount calculation
    public string ProductId // Getter and Setter for product ID
    {
        get { return productId; }
        set { productId = value; }
    }
    public string ProductName // Getter and Setter for product name
    {
        get { return productName; }
        set { productName = value; }
    }
    public void DisplayFinalPrice()
    { // Method to display final price after discount and tax
        double tax = 0;

        if (this is ITaxable)
        {
            tax = ((ITaxable)this).CalculateTax();
        }

        Console.WriteLine("Product ID: " + ProductId);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Final Price after Discount and Tax: " + (price + tax));
    }



}
class Electronics : Product, ITaxable
{
    private double discount;
    public Electronics(string id, string name, double price)
    {
        ProductId = id;
        ProductName = name;
        this.price = price;
    }
    public override void CalculateDiscount()
    {
        discount = price * 0.1; // 10% discount
        price -= discount;
    }
    public double CalculateTax()
    {
        return price * 0.15; // 15% tax
    }
    public double GetTaxDetails()
    {
        return CalculateTax();
    }
}
class Clothing : Product, ITaxable
{
    private double discount;
    public Clothing(string id, string name, double price)
    {
        ProductId = id;
        ProductName = name;
        this.price = price;
    }
    public override void CalculateDiscount()
    {
        discount = price * 0.2; // 20% discount
        price -= discount;
    }
    public double CalculateTax()
    {
        return price * 0.05; // 5% tax
    }
    public double GetTaxDetails()
    {
        return CalculateTax();
    }
}
class Groceries : Product, ITaxable
{
    private double discount;
    public Groceries(string id, string name, double price)
    {
        ProductId = id;
        ProductName = name;
        this.price = price;
    }
    public override void CalculateDiscount()
    {
        discount = price * 0.05; // 5% discount
        price -= discount;
    }
    public double CalculateTax()
    {
        return 0; // No tax on groceries
    }
    public double GetTaxDetails()
    {
        return CalculateTax();
    }
}
class ECommercePlatform
{
    static void Main()
    {
        Product laptop = new Electronics("E001", "Laptop", 1000);
        laptop.CalculateDiscount();
        laptop.DisplayFinalPrice();

        Product tshirt = new Clothing("C001", "T-Shirt", 50);
        tshirt.CalculateDiscount();
        tshirt.DisplayFinalPrice();

        Product apple = new Groceries("G001", "Apple", 2);
        apple.CalculateDiscount();
        apple.DisplayFinalPrice();
    }
}



