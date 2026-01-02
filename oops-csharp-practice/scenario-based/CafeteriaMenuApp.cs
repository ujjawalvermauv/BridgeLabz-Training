using System;

class CafeteriaMenuApp
{
    // Store 10 fixed menu items
    static string[] menuItems = new string[]
    {
        "Veg Sandwich",
        "Chicken Burger",
        "Pasta",
        "Pizza",
        "French Fries",
        "Coffee",
        "Tea",
        "Cold Drink",
        "Ice Cream",
        "Chocolate Cake"
    };

    static void Main(string[] args)
    {
        // Display menu
        DisplayMenu();

        // Take user input
        Console.Write("\nEnter item index to order: ");
        int index = Convert.ToInt32(Console.ReadLine());

        // Get selected item
        string selectedItem = GetItemByIndex(index);

        // Display result
        if (selectedItem != null)
        {
            Console.WriteLine("You ordered: " + selectedItem);
        }
        else
        {
            Console.WriteLine("Invalid item index!");
        }
    }

    // Method to display menu
    static void DisplayMenu()
    {
        Console.WriteLine("----- Cafeteria Menu -----");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine(i + " - " + menuItems[i]);
        }
    }

    // Method to get item by index
    static string GetItemByIndex(int index)
    {
        if (index >= 0 && index < menuItems.Length)
        {
            return menuItems[index];
        }
        return null;
    }
}
