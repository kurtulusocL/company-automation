using CompanyOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOtomasyon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SetPassword> SetPasswords { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<OrderControl> OrderControls { get; set; }
        public DbSet<ProductControl> ProductControls { get; set; }
    }
}
