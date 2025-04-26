using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Models
{
    internal class SupplyOrderItem
    {
        public int SupplyOrderID { get; set; }
        public SupplyOrder SupplyOrder { get; set; }
        public int ItemID { get; set; }
        public ItemWarehouse Item { get; set; }// hy3rf el warehouse mn el itemwarehouse
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        //public SupplyOrderItem()
        //{
        //    WarehouseId = SupplyOrder.Warehouse.WarehouseID;
        //}

    }
}
