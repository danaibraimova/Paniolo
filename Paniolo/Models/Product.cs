using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Paniolo.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; } 
        public string Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }

    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}