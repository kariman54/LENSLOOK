using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Doctors
    {
        [Key]
        public int DID { get; set; }

        [Required]
        [StringLength(50)]
        public string? DFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string DLastName { get; set; }

        [Required]
        [StringLength(10)]
        public string DGender { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.Password)]
        public string Dpassword { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string DEmail { get; set; }

        public int Experience { get; set; }

        [StringLength(100)]
        public string Specialization { get; set; }

        public int NumberOfAppointments { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        public ICollection<Doctorsphones> DoctorPhones { get; set; } = new HashSet<Doctorsphones>();
        public ICollection<Rates> Rates { get; set; } = new HashSet<Rates>();
        public ICollection<Users> Users { get; set; } = new HashSet<Users>();
        public ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
    }
      

}
