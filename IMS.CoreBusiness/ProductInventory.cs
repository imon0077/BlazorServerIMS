using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public class ProductInventory
    {
        public int Productid { get; set; }
        public Product Product { get; set; } = new Product();
        
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; } = new Inventory();

        //this property is the one which we can not just add nvaigation properties from propduct to inventory and vice versa
        public float InventoryQuantity { get; set; }

    }
}
