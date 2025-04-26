using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Models
{
    internal class ReleaseOrderItem
    {
        public int ReleaseOrderID { get; set; }
        public ReleaseOrder ReleaseOrder { get; set; }
        public int ItemID { get; set; }
        public ItemWarehouse Item { get; set; }// hy3rf el warehouse mn el itemwarehouse
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }
            
    }
}
