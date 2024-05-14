using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Orders
    {
        [Key]
        public int OID { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public decimal price { get; set; }
        [ForeignKey("Delivery")]
        public int? DelID { get; set; }
        [ForeignKey("Users")]
        public int? UID { get; set; }
        public ICollection<OrderProduct> OrderProduct { get; set; } = new HashSet<OrderProduct>();
    }
}
