using System;

public class ProductInventory
{
    public string productName; // Instance Variable

    public int price; // Instance Variable

    public static int totalProducts;  // Class Variable
    public ProductInventory(string productName, int price)
    {
        this.productName = productName; // Using 'this' keyword to resolve ambiguity
        this.price = price;
        totalProducts++; // Incrementing class variable
    }
    public void DisplayEmployeeDetails() //An instance method DisplayProductDetails() to display the details of a product.
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: " + price);

    }
    public static void DisplayTotalProducts()
    { //A class method DisplayTotalProducts() to show the total number of products created.

        Console.WriteLine("Total Products: " + totalProducts);
    }
    public static void Main()
    {
        ProductInventory product1 = new ProductInventory("Laptop", 80000);
        ProductInventory product2 = new ProductInventory("Smartphone", 50000);
        product1.DisplayEmployeeDetails();
        product2.DisplayEmployeeDetails();
        ProductInventory.DisplayTotalProducts();



    }







}