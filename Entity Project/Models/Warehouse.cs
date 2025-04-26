using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entity_Project.Models.ItemWarehouse;

namespace Entity_Project.Models
{
    internal class Warehouse
    {
       [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarehouseID { get; set; }
        [MaxLength(10)]
        public string WarehouseName { get; set; }
        [MaxLength(20)]
        public string WarehouseLocation { get; set; }

       
        public int? ResponsiblePersonId { get; set; }
        public Employee? ResponsiblePerson { get; set; }


        public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; } = new List<ItemWarehouse>();
        public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
        public ICollection<SupplyOrder> SupplyOrders { get; set; } = new List<SupplyOrder>();
        public ICollection<ReleaseOrder> ReleaseOrders { get; set; } = new List<ReleaseOrder>();
        
        public ICollection<StockTransfer> SourceTransfers { get; set; } = new List<StockTransfer>();
      
        public ICollection<StockTransfer> DestinationTransfers { get; set; } = new List<StockTransfer>();
     
    }
}

