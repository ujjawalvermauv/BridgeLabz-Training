using System;
using System.Collections.Generic;

class Customer
{
    public string Name;
    public List<string> Items;

    public Customer(string name, List<string> items)
    {
        Name = name;
        Items = items;
    }
}

class SmartCheckout
{
    Queue<Customer> customerQueue = new Queue<Customer>();
    Dictionary<string, int> priceMap = new Dictionary<string, int>();
    Dictionary<string, int> stockMap = new Dictionary<string, int>();

    // Add item details
    public void AddItem(string item, int price, int stock)
    {
        priceMap[item] = price;
        stockMap[item] = stock;
    }

    // Add customer to queue
    public void AddCustomer(Customer customer)
    {
        customerQueue.Enqueue(customer);
        Console.WriteLine("Customer added to queue: " + customer.Name);
    }

    // Process billing
    public void ProcessCustomer()
    {
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("No customers in queue");
            return;
        }

        Customer customer = customerQueue.Dequeue();
        Console.WriteLine("\nProcessing customer: " + customer.Name);

        int totalBill = 0;

        foreach (string item in customer.Items)
        {
            if (priceMap.ContainsKey(item) && stockMap[item] > 0)
            {
                totalBill += priceMap[item];
                stockMap[item] = stockMap[item] - 1;
            }
            else
            {
                Console.WriteLine("Item unavailable: " + item);
            }
        }

        Console.WriteLine("Total Bill: " + totalBill);
    }
}

class Program
{
    static void Main()
    {
        SmartCheckout checkout = new SmartCheckout();

        // Add items to store
        checkout.AddItem("Milk", 50, 10);
        checkout.AddItem("Bread", 30, 5);
        checkout.AddItem("Eggs", 10, 20);

        // Create customers
        Customer c1 = new Customer("Amit", new List<string> { "Milk", "Bread" }
        );

        Customer c2 = new Customer("Riya", new List<string> { "Eggs", "Milk", "Eggs" }
        );

        // Add customers to queue
        checkout.AddCustomer(c1);
        checkout.AddCustomer(c2);

        // Process billing
        checkout.ProcessCustomer();
        checkout.ProcessCustomer();
    }
}
