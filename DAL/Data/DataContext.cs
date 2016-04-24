using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Pass the name of connection string in the web.config
        /// or
        /// Explicitly declare the connection string to DB
        /// </summary>
        public DataContext()
            : base("DefaultConnection")
        {

        }

        /// <summary>
        /// Entities need to be persisted, declared here 
        /// i.e. physical tables of the DB
        /// </summary>
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
    }
}
