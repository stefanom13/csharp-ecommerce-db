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
    [Table("order_products")]
    public class order_product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("product_id")]
        public int ProductId { get; set; }
        public Products Product { get; set; }
        [Required]
        [Column("order_id")]
        public int OrderId { get; set; }
        public Orders Order { get; set; }
        [Required]
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
