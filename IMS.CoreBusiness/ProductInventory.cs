using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public class ProductInventory
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        
        public int InventoryId { get; set; }
        public Inventory? Inventory { get; set; }

        //this property is the one which we can not just add nvaigation properties from propduct to inventory and vice versa
        public float InventoryQuantity { get; set; }

    }
}
