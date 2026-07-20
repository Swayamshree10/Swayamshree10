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


public class RetailDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=RetailStoreDB;Trusted_Connection=True;TrustServerCertificate=True");
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (var context = new RetailDbContext())
        {
            
            context.Database.EnsureCreated();

            if (!context.Products.Any())
            {
                context.Products.Add(new Product
                {
                    ProductName = "Laptop",
                    Quantity = 15,
                    Price = 60000
                });

                context.Products.Add(new Product
                {
                    ProductName = "Smartphone",
                    Quantity = 25,
                    Price = 25000
                });

                context.SaveChanges();
            }

            
            Console.WriteLine("Retail Store Products");
            Console.WriteLine("---------------------");

            foreach (var product in context.Products)
            {
                Console.WriteLine($"ID: {product.ProductId}");
                Console.WriteLine($"Product: {product.ProductName}");
                Console.WriteLine($"Quantity: {product.Quantity}");
                Console.WriteLine($"Price: ₹{product.Price}");
                Console.WriteLine();
            }
        }
    }
}