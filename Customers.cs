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
    [Table("Customers")]
    [Index(nameof(Email), IsUnique = true)]
    public class Customers
    {
        
        [Key]
        [Column("Id")]
        public int CustomerId { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("Surname")]

        public string Surname { get; set; }

        [Column("customer_email")]
        public string Email { get; set; }

        //relazione 1 a M
        public List<Orders> Order { get; set; }

    }
}
