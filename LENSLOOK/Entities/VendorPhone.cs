using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class VendorPhone
    {
        [Key]
        [ForeignKey("vendors")]
        public int VID { get; set; }
        public Vendors vendors { get; set; }

        [Key]
        [DataType(DataType.PhoneNumber)]
        public string Vphone { get; set; }
    }
}
