using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Reviews
    {
        [Key]
        [ForeignKey("User")]
        public int UID { get; set; }
        public Users Users { get; set; }

        [Key]
        [ForeignKey("products")]
        public int PID { get; set; }
        public Products products { get; set; }

        public decimal reviews { get; set; }
    }
}
