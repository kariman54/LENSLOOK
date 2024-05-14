using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Doctorsphones
    {
        [Key]
        [ForeignKey("Doctors")]
        public int DID { get; set; }
        public Doctors Doctors { get; set; }
        [Key]
        public string Dphone { get; set; }
       
    }
}
