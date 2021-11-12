using EFAndAsenkronWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFAndAsenkronWebAPI.Data
{
    public class InnovaDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public InnovaDbContext(DbContextOptions<InnovaDbContext> options):base(options)
        {
            //this.Database.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired()
                                                                .HasMaxLength(150);

            //TODO 1: Veritabanını oluşturduktan sonra, ilişki kurma gösterilecek

            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(pr => pr.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderDetail>().HasKey("OrderId", "ProductId");

            modelBuilder.Entity<Order>().HasMany(o => o.OrderDetails)
                                        .WithOne(od => od.Order)
                                        .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<Product>().HasMany(p => p.Orders)
                                          .WithOne(od => od.Product)
                                          .HasForeignKey(od => od.ProductId);


                                          



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\Mssqllocaldb; Database=innovaDb; Integrated Security=yes");

            
        }
    }
}
