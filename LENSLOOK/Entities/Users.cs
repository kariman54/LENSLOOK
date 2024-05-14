using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LENSLOOK.Entities
{
    internal class Users
    {
        [Key]
        public int UID { get; set; }

        [Required]
        [StringLength(50)]
        public string UFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string ULastName { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DOB.Year;
            if (DOB.Date > today.AddYears(-age)) age--;
            return age;
        }

        [Required]
        [StringLength(50)]
        public string URoleName { get; set; }

        [Required]
        [StringLength(10)]
        public string UGender { get; set; }

        public string? Report { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.Password)]
        public string Upassword { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string UEmail { get; set; }
        public ICollection<Userphnoes> UserPhones { get; set; } =new HashSet<Userphnoes>();
        public ICollection<Rates> Rates { get; set; } = new HashSet<Rates>();
        public ICollection<Doctors> Doctors { get; set; } = new HashSet<Doctors>();
        public ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
        public  ICollection<Orders> Orders { get; set; } = new HashSet<Orders>();
        public ICollection<Reviews> Reviews { get; set; } = new HashSet<Reviews>();
    }
}
