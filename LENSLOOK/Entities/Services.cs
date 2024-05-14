using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Services
    {
        [Key]
        public int SID { get; set; }

        [Required]
        [StringLength(100)]
        public string SName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal SPrice { get; set; }

        [StringLength(1000)]
        public string SDescription { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
    }
}
