using System;
using System.Collections.Generic;

public class Boutique
{
    private Dictionary<string, int> threadStock;
    public Boutique()
    {
        threadStock = new Dictionary<string, int>()
        {
            {"Blanket", 10},
            {"Bedsheet",20 },
            {"Red", 100},
            {"Blue", 150},
            {"Green", 200}
        };
    }

   
    public bool PlaceOrder(string productName, int quantity)
    {
        if (threadStock.ContainsKey(productName))
        {
            if (threadStock[productName] >= quantity)
            {
                threadStock[productName] -= quantity;
                Console.WriteLine("Order placed successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Out of stock.");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Product not found.");
            return false;
        }
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        Boutique boutique = new Boutique();

        // Get user input
        Console.WriteLine("Enter the product name:");
        string productName = Console.ReadLine();

        Console.WriteLine("Enter the number of stocks:");
        if (int.TryParse(Console.ReadLine(), out int quantity))
        {
            // Place the order based on user input
            boutique.PlaceOrder(productName, quantity);
        }
        else
        {
            Console.WriteLine("Invalid quantity entered.");
        }
    }
}