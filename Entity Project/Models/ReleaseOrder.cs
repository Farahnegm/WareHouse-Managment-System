using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Models
{
    internal class ReleaseOrder
    {
        public int ReleaseOrderID { get; set; }
        public string SuppilerName{ get; set; }
        public Supplier Supplier { get; set; }

        public string WarehouseName { get; set; }
        public Warehouse Warehouse { get; set; }
       
        public DateTime OrderDate { get; set; }
         public ICollection<ReleaseOrderItem> ReleaseOrderItems { get; set; }=new List<ReleaseOrderItem>();

    }
}
