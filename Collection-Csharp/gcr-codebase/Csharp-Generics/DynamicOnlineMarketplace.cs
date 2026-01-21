class BookCategory { }
class ClothingCategory { }

class Product<T>
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Marketplace
{
    public static void ApplyDiscount<T>(Product<T> product, double percent)
    {
        product.Price -= product.Price * percent / 100;
    }
}
