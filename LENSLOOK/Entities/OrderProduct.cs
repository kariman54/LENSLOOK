using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class OrderProduct
    {
        [Key]
        [ForeignKey("products")]
        public int PID { get; set; }
        public Products products { get; set; }

        [Key]
        [ForeignKey("Orders")]
        public int OID { get; set; }
        public Orders Orders { get; set; }

    }
}
