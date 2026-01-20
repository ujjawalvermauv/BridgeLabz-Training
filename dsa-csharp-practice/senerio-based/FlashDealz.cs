using System;

class Product
{
    public string Name;
    public int Discount;

    public Product(string name, int discount)
    {
        Name = name;
        Discount = discount;
    }
}

class FlashDealz
{
    // Quick Sort method (sorting by discount in desc order)
    static void QuickSort(Product[] products, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(products, low, high);

            QuickSort(products, low, pivotIndex - 1);
            QuickSort(products, pivotIndex + 1, high);
        }
    }

    // Partition logic
    static int Partition(Product[] products, int low, int high)
    {
        int pivot = products[high].Discount;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            // For descending order (highest discount first)
            if (products[j].Discount > pivot)
            {
                i++;
                Swap(products, i, j);
            }
        }

        Swap(products, i + 1, high);
        return i + 1;
    }

    // Swap 
    static void Swap(Product[] products, int i, int j)
    {
        Product temp = products[i];
        products[i] = products[j];
        products[j] = temp;
    }

    // Main method
    static void Main()
    {
        Product[] products =
        {
            new Product("Laptop", 40),
            new Product("Mobile", 60),
            new Product("Headphones", 25),
            new Product("Smart Watch", 50),
            new Product("Camera", 30)
        };

        Console.WriteLine("Before Sorting:");
        Display(products);
        QuickSort(products, 0, products.Length - 1);
        Console.WriteLine("\nAfter Sorting (Top Discounts First):");
        Display(products);
        Console.ReadLine();
    }

    // Display products
    static void Display(Product[] products)
    {
        foreach (Product p in products)
        {
            Console.WriteLine(p.Name + " - " + p.Discount + "% OFF");
        }

    }
}
