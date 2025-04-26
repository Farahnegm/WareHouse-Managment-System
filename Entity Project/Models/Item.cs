using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entity_Project.Models.ItemWarehouse;

namespace Entity_Project.Models
{
    internal class Item
    {
        public int ItemId { get; set; }
        [MaxLength (10)]
        public string ItemName { get; set; }
        public string? UnitOfMeasure { get; set; }
        public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; } = new List<ItemWarehouse>();
        public ICollection<SupplyOrderItem> SupplyPermits { get; set; } = new List<SupplyOrderItem>();
        public ICollection<ReleaseOrderItem> ReleasePermits { get; set; } = new List<ReleaseOrderItem>();
        public ICollection<StockTransferItem> StockTransfers { get; set; } = new List<StockTransferItem>();
    }

}

