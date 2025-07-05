using Microsoft.EntityFrameworkCore;
using Retailstore.relationship;
using System;

namespace Retailstore
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            
            using var context = new Appdbcontext();
            // Retreiving All Products
             Console.WriteLine("All Products:");
             var prod = await context.Product.ToListAsync();
             foreach (var p in prod)
             {
                 Console.WriteLine($"Name: {p.Name}- Price: {p.Price}");
             }
             //Find By ID
             Console.WriteLine(Environment.NewLine+"Find Product By ID:");
             var prodID=await context.Product.FindAsync(2);
             Console.WriteLine($"Found: {prodID.Name} - Price: {prodID.Price}");

             //First or Default
             Console.WriteLine(Environment.NewLine+"First or Default Product:");
             var expensive=await context.Product.FirstOrDefaultAsync(p => p.Price > 5000);
             Console.WriteLine($"Expensive Product: {expensive.Name} - Price: {expensive.Price}");


          
        }
    }
}
