using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Models
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        [MaxLength(50)]
        public string CustomerName { get; set; }

        public string Mobile { get; set; }
        public string? Phone { get; set; }
        [Required]
        [EmailAddress]
       // [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        public string? Fax { get; set; }
        public string? Website { get; set; }

        
        public string? HashedPassword { get; set; }

        
        [NotMapped]
        public string Password { get; set; }

        [NotMapped]
        public string Cpassword { get; set; }
    }
}
 