using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


public class Product
{
    [Key]
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryDB;Trusted_Connection=True;TrustServerCertificate=True");
    }
}


class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            
            context.Database.EnsureCreated();

            
            if (!context.Products.Any())
            {
                context.Products.Add(new Product
                {
                    ProductName = "Laptop",
                    Quantity = 10,
                    Price = 55000
                });

                context.Products.Add(new Product
                {
                    ProductName = "Mouse",
                    Quantity = 50,
                    Price = 800
                });

                context.Products.Add(new Product
                {
                    ProductName = "Keyboard",
                    Quantity = 30,
                    Price = 1500
                });

                context.SaveChanges();
            }

            
            Console.WriteLine("Retail Inventory System");
            Console.WriteLine("-----------------------");

            foreach (var product in context.Products)
            {
                Console.WriteLine($"ID: {product.ProductId}");
                Console.WriteLine($"Name: {product.ProductName}");
                Console.WriteLine($"Quantity: {product.Quantity}");
                Console.WriteLine($"Price: ₹{product.Price}");
                Console.WriteLine();
            }
        }
    }
}