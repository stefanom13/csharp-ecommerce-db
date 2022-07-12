using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_ecommerce_db
{
    public class EcommerceContext : DbContext
    {
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<order_product> OrdersProducts { get; set; }
        public DbSet<Products> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-ecommerce;Integrated Security=True");
        }
    }
}
