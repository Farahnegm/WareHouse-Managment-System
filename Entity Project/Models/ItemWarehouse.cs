using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Models
{
    internal class ItemWarehouse
    {
        
            public int ItemId { get; set; }
            public virtual Item Item { get; set; } 

            public int WarehouseId { get; set; }
            public virtual Warehouse Warehouse { get; set; } 

            public int Quantity { get; set; } 

            

        }
    }

