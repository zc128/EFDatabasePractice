using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDatabasePractice.Models;
using Microsoft.EntityFrameworkCore;

 
namespace EFDatabasePractice.Context
{
    public class EcommerceShopContext : DbContext
    {
        public EcommerceShopContext()
        {
        }
        #region Constructors
        public EcommerceShopContext(DbContextOptions<EcommerceShopContext> options)
            : base(options)
        {}
        #endregion Constructors

        #region Properties
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Territory> Territories { get; set; }

        #endregion Properties

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().Property("Freight").HasColumnType("decimal").HasPrecision(18, 2);
            modelBuilder.Entity<OrderDetail>().Property("UnitPrice").HasColumnType("decimal").HasPrecision(18, 2);
            modelBuilder.Entity<Product>().Property("UnitPrice").HasColumnType("decimal").HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }

    }
}
