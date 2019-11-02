using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiyFrameworkCore2.Models
{
    public static class SeedData
    {

        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product() { Name = "Product 1", Description = "Prodcut Description 1 ", Price = 200, Category = "Category 1" },
                    new Product() { Name = "Product 2", Description = "Prodcut Description 2 ", Price = 100, Category = "Category 1" },
                    new Product() { Name = "Product 3", Description = "Prodcut Description 3 ", Price = 300, Category = "Category 1" },
                    new Product() { Name = "Product 4", Description = "Prodcut Description 4 ", Price = 400, Category = "Category 2" },
                    new Product() { Name = "Product 5", Description = "Prodcut Description 5 ", Price = 500, Category = "Category 2" },
                    new Product() { Name = "Product 6", Description = "Prodcut Description 6 ", Price = 600, Category = "Category 2" },
                    new Product() { Name = "Product 7", Description = "Prodcut Description 7 ", Price = 700, Category = "Category 2" },
                    new Product() { Name = "Product 8", Description = "Prodcut Description 8 ", Price = 800, Category = "Category 2" },
                    new Product() { Name = "Product 9", Description = "Prodcut Description 9 ", Price = 900, Category = "Category 2" },
                    new Product() { Name = "Product 10", Description = "Prodcut Description 10 ", Price = 1000, Category = "Category 1" },
                    new Product() { Name = "Product 11", Description = "Prodcut Description 11 ", Price = 1200, Category = "Category 1" },
                    new Product() { Name = "Product 12", Description = "Prodcut Description 12 ", Price = 1300, Category = "Category 1" },
                    new Product() { Name = "Product 13", Description = "Prodcut Description 13 ", Price = 1400, Category = "Category 1" }
                     );
                context.SaveChanges();
            }

        }
    }
}
