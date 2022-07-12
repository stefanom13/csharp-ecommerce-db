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
    [Table("Orders")]
    //[Index(nameof(Email), IsUnique = true)]
    public class Orders
    {
        
        
        [Key]
        [Column("Id")]
        public int OrderId { get; set; }

        [Required]
        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("Amount")]
        public string Amount { get; set; }

        [Column("Avaible")]
        public bool Status { get; set; }

        //[ForeignKey]
        [Column("Customer_Id")]
        public int CustomerId { get; set; }

        //relazione 1 a M
        public Customers Customer { get; set; }

        //relazione M a M
        public List<Products> ProductOrder { get; set; }

        public Orders(int customerId, DateTime date, bool status)
        {
            CustomerId = customerId;
            Date = date;
            Status = status;
        }
        public void StampaInfo()
        {
            Console.WriteLine($"\nId: {OrderId}");
            Console.WriteLine($"Customer id: {CustomerId}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Status: {Status}");
        }

    }
}
