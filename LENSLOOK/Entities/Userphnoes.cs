using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Userphnoes
    {
        [Key]
        [ForeignKey("users")]
        public int UID { get; set; }
        public Users users { get; set; }
        
        [Key]
        [DataType(DataType.PhoneNumber)]
        public string Uphone { get; set; } 
       
    }
}
