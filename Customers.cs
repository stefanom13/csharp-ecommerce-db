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
    internal class Customers
    {
        [Table("Customers")]
        [Index(nameof(Email), IsUnique = true)]
        public class Customer
        {
            [Key]
            public int CustomerId { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public string Surname { get; set; }

            [Column("customer_email")]
            public string Email { get; set; }
        }
    }
}
