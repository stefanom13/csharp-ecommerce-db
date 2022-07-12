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
    [Table("Products")]
    public class Products
    {
       
        [Key]
        [Column("Id")]
        public int ProductId { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Required]
        [Column("Price")]
        public decimal Price { get; set; }

        public List<Orders> OrderProduct { get; set; }
       

    }
    
}
