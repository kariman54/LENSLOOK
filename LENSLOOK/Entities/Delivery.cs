using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Delivery
    {
        [Key]
        public int DelID { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public string DeliveryCompany { get; set; }

        [Required]
        public string DeliveryPassword { get; set; }
        public ICollection<Orders> Order { get; set; } = new HashSet<Orders>();
    }
}
