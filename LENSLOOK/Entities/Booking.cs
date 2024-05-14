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
    internal class Booking
    {
        [ForeignKey("Users")]
        public int UID { get; set; }
        public Users Users { get; set; }

        [ForeignKey("Doctors")]
        public int DID { get; set; }
        public Doctors Doctors { get; set; }

        [ForeignKey("Services")]
        public int SID { get; set; }
        public Services Services { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(100)]
        public string Location { get; set; }
    }
}
