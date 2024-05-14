using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Products
    {
        [Key]
        public int PID { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        [Required]
        [StringLength(50)]
        public string LensType { get; set; }

        [Required]
        [StringLength(50)]
        public string FrameType { get; set; }

        [Required]
        [StringLength(50)]
        public string Size { get; set; }

        [Required]
        [StringLength(100)]
        public string Brand { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal PPrice { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }
        [Required]
        [StringLength(500)]
        public string PDescription { get; set; }
        public ICollection<VendorProduct> vendorProducts { get; set; } = new HashSet<VendorProduct>();
        public ICollection<Reviews> Reviews { get; set; } = new HashSet<Reviews>();
        public ICollection<OrderProduct> OrderProduct { get; set; } = new HashSet<OrderProduct>();

    }
}
