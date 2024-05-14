using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Vendors
    {
        [Key]
        public int VID { get; set; } 
        
        public string VName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string VEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string VPassword { get; set; }
        public ICollection<VendorPhone> VendorPhones { get; set; } = new HashSet<VendorPhone>();
        public ICollection<VendorProduct> vendorProducts { get; set; } = new HashSet<VendorProduct>();
    }
}
