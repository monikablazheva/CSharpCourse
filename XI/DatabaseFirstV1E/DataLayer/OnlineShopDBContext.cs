using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class OnlineShopDBContext : DbContext
    {
        public OnlineShopDBContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-AT94SBBO\SQLEXPRESS;Database=OnlineShopDBv1E;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer(@"Server=III-PC\SQLEXPRESS;Database=OnlineShopDBv1E;Trusted_Connection=True;");
            //base.OnConfiguring(optionsBuilder); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrdersProductsQuantities>().HasKey(opq => new { opq.OrderID, opq.ProductBarcode });
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrdersProductsQuantities> OPQs { get; set; }

    }
}
