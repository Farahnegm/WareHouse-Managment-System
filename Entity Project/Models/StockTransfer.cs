using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Models
{
    internal class StockTransfer
    {
        public int StockTransferID { get; set; }
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }

        [ForeignKey("ItemId")]
        public  int ItemId {get; set; } 
        public virtual Item Item { get; set; }

       
        public int SourceWarehouseID { get; set; }
        public virtual Warehouse SourceWarehouse { get; set; }

       
        public int DestinationWarehouseID { get; set; }
        public virtual Warehouse DestinationWarehouse { get; set; }

       
        public virtual ICollection<StockTransferItem> StoreTransferItems { get; set; } = new List<StockTransferItem>();




    }
}
