using EFCoreIntro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreIntro.Data
{
    // DbContext = representing a session within the database
    internal class BookContext : DbContext
    {
        // DbSet maps to a database table
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // obviously in production environment these shouldn't be hardcoded or used like this
            //optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5555;Database=postgres;User Id=postgres;Password=admin;");
            //below is for containerized postgresql
            optionsBuilder.UseNpgsql("User ID=postgres;Password=admin;Host=localhost;Port=5555;Database=postgres;");
        }
    }
}
