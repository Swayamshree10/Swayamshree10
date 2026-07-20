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
                var products = new Product[]
                {
                    new Product { ProductName = "Laptop", Quantity = 10, Price = 55000 },
                    new Product { ProductName = "Mouse", Quantity = 50, Price = 800 },
                    new Product { ProductName = "Keyboard", Quantity = 30, Price = 1500 },
                    new Product { ProductName = "Monitor", Quantity = 20, Price = 12000 }
                };

                context.Products.AddRange(products);
                context.SaveChanges();

                Console.WriteLine("Initial data inserted successfully.\n");
            }
            else
            {
                Console.WriteLine("Data already exists.\n");
            }

            
            Console.WriteLine("Product List");
            Console.WriteLine("------------");

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