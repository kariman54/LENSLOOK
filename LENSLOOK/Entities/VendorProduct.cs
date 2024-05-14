using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class VendorProduct
    {
        [Key]
        [ForeignKey("products")]
        public int PID { get; set; }
        public Products products { get; set; }

        [Key]
        [ForeignKey("Vendors")]
        public int VID { get; set; }
        public Vendors Vendors { get; set; }

       
    }
}
