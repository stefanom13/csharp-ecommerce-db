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
    internal class Products
    {
        [Table("Products")]
        public class Prodotti
        {
            [Key]
            public int ProductId { get; set; }

            [Required]
            public string Name { get; set; }

            public string Description { get; set; }

            [Required]
            public string Price { get; set; }
        }
    }
}
