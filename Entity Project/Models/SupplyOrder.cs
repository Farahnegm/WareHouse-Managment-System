using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Project.Forms;

namespace Entity_Project.Models
{
    internal class SupplyOrder
    {
        public int SupplyOrderID { get; set; }
       
        public string SupplierName { get; set; }
        public Supplier Supplier { get; set; }
        public string WarehouseName { get; set; }
        public Warehouse Warehouse { get; set; }
     
        public DateTime OrderDate { get; set; }

        public ICollection<SupplyOrderItem> SupplyOrderItems { get; set; }
      
    }
}
