using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Models
{
    public class Employee
    {  
            public int EmployeeId { get; set; }
        [MaxLength(10)]
            public string Name { get; set; }

            public string Phone { get; set; }
        [Required]
        [EmailAddress]
       // [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        public RoleType Role { get; set; }
        
        public string? HashedPassword { get; set; }

        // ❌ These should NOT be required because they are not mapped
        [NotMapped]
        public string Password { get; set; }

        [NotMapped]
        public string Cpassword { get; set; }
    }
    }

