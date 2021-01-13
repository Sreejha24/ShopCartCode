using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order order { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product product { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
