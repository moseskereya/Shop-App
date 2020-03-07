using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class ProductContext : DbContext 
    {
        public ProductContext () : base("ProductContext")
        {}

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}