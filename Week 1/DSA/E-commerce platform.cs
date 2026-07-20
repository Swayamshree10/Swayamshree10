using System;
using System.Collections.Generic;

List<Product> products = new List<Product>()
{
    new Product(1, "Laptop", 55000),
    new Product(2, "Smartphone", 25000),
    new Product(3, "Headphones", 2000),
    new Product(4, "Keyboard", 1500),
    new Product(5, "Mouse", 800)
};

Console.Write("Enter product name to search: ");
string search = Console.ReadLine();

bool found = false;

foreach (Product product in products)
{
    if (product.Name.Equals(search, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("\nProduct Found:");
        product.Display();
        found = true;
        break;
    }
}

if (!found)
{
    Console.WriteLine("\nProduct not found.");
}

class Product
{
    public int Id;
    public string Name;
    public double Price;

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: ₹" + Price);
        Console.WriteLine();
    }
}
