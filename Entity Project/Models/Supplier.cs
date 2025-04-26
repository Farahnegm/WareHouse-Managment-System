using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Models
{
    internal class Supplier
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierID { get; set; }
        [MaxLength(50)]
        public string SupplierName { get; set; }
     
        public string Mobile { get; set; }
        public string? Phone { get; set; }
        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        [MaxLength(100)]
        public string? Fax { get; set; }
        [MaxLength(20)]
        public string? Website { get; set; }
        
        public string? HashedPassword { get; set; }

        // ❌ These should NOT be required because they are not mapped
        [NotMapped]
        public string Password { get; set; }

        [NotMapped]
        public string Cpassword { get; set; }
        public ICollection<SupplyOrder> SupplyOrders { get; set; }  = new List<SupplyOrder>();
        public ICollection<StockTransfer> StoreTransfers { get; set; } = new List<StockTransfer>(); 
        public ICollection<ReleaseOrder> ReleaseOrders { get; set; } = new List<ReleaseOrder>();
        public ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
    }
}
