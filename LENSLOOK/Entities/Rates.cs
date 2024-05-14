using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Rates
    {
        [Key]
        [ForeignKey("User")]
        public int UID { get; set; }
        public Users Users { get; set; }

        [Key]
        [ForeignKey("Doctor")]
        public int DID { get; set; }
        public Doctors Doctors { get; set; }

        public decimal Rate { get; set; }
    }
}
