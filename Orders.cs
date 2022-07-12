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
    internal class Orders
    {
        [Table("Orders")]
        //[Index(nameof(Email), IsUnique = true)]
        public class Order
        {
            [Key]
            public int OrderId { get; set; }

            [Required]
            public string Date { get; set; }

            public string Amount { get; set; }

            [Column("Avaible")]
            public bool Status { get; set; }
        }
    }
}
