using System;
using System.Collections.Generic;

namespace BabyClothingStore
{
    class BabyDress
    {
        public int Size { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public BabyDress(int size, string color, string brand, double price)
        {
            Size = size;
            Color = color;
            Brand = brand;
            Price = price;
        }

        public override string ToString()
        {
            return $"Size: {Size}, Color: {Color}, Brand: {Brand}, Price: ${Price}";
        }
    }
    class ShoppingCart
    {
        private List<BabyDress> cart = new List<BabyDress>();
        public void AddDressToCart(BabyDress dress)
        {
            cart.Add(dress);
            Console.WriteLine($"{dress} has been added to the cart.");
        }

        public void RemoveDressFromCart(int size)
        {
            BabyDress dressToRemove = cart.Find(d => d.Size == size);
            if (dressToRemove != null)
            {
                cart.Remove(dressToRemove);
                Console.WriteLine($"Dress with size {size} has been removed from the cart.");
            }
            else
            {
                Console.WriteLine($"No dress with size {size} found in the cart.");
            }
        }
        public void DisplayCart()
        {
            if (cart.Count > 0)
            {
                Console.WriteLine("Cart contains:");
                foreach (var dress in cart)
                {
                    Console.WriteLine(dress);
                }
            }
            else
            {
                Console.WriteLine("Your cart is empty.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            int choice;

            do
            {
                Console.WriteLine("\nSample Input/Output 1:");
                Console.WriteLine("1. Add dress to cart");
                Console.WriteLine("2. Remove dress from cart");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add a dress to the cart
                        Console.Write("Enter the dress size: ");
                        int size = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the dress color: ");
                        string color = Console.ReadLine();
                        Console.Write("Enter the dress brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Enter the dress price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        BabyDress dress = new BabyDress(size, color, brand, price);
                        cart.AddDressToCart(dress);
                        break;

                    case 2:
                        // Remove a dress from the cart
                        Console.Write("Enter the size of the dress to remove: ");
                        int removeSize = Convert.ToInt32(Console.ReadLine());
                        cart.RemoveDressFromCart(removeSize);
                        break;

                    case 3:
                        // Exit
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
                cart.DisplayCart();

            } while (choice != 3);
        }
    }
}