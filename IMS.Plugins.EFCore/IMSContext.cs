﻿using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore
{
    public class IMSContext :DbContext
    {
        public IMSContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding data inventory
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { InventoryId = 1, InventoryName = "Gas Engine", Price = 1000, Quantity = 1 },
                new Inventory { InventoryId = 2, InventoryName = "Body", Price = 400, Quantity = 1},
                new Inventory { InventoryId = 3, InventoryName = "Wheels", Price = 100, Quantity = 4},
                new Inventory { InventoryId = 4, InventoryName = "Seat", Price = 50, Quantity = 5},
                new Inventory { InventoryId = 5, InventoryName = "Electric Engine", Price = 800, Quantity = 2 },
                new Inventory { InventoryId = 6, InventoryName = "Battery", Price = 400, Quantity = 5 }
            );

            //seeding data product
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Gas Car", Price = 20000, Quantity = 1 },
                new Product { ProductId = 2, ProductName = "Electric Car", Price = 15000, Quantity = 1 }
            );
        }
    }
}
