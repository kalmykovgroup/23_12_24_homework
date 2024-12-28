using app.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace app.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            // Данные по умолчанию для таблицы Users
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "product 1", 
                } ,
                new Product
                {
                    Id = 2,
                    Name = "product 2", 
                } ,
                new Product
                {
                    Id = 3,
                    Name = "product 3", 
                } ,
                new Product
                {
                    Id = 4,
                    Name = "product 4", 
                } ,
                new Product
                {
                    Id = 5,
                    Name = "product 5", 
                } ,
                new Product
                {
                    Id = 6,
                    Name = "product 6", 
                } ,
                new Product
                {
                    Id = 7,
                    Name = "product 7", 
                } ,
                new Product
                {
                    Id = 8,
                    Name = "product 8", 
                } ,
                new Product
                {
                    Id = 9,
                    Name = "product 9", 
                } ,
                new Product
                {
                    Id = 10,
                    Name = "product 10", 
                } ,
                new Product
                {
                    Id = 11,
                    Name = "product 11", 
                } 
            );
        }
    }
}
