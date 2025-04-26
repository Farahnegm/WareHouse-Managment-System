using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Entity_Project.Models.ItemWarehouse;



namespace Entity_Project.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<SupplyOrder> SupplyOrders { get; set; }
        public DbSet<SupplyOrderItem> SupplyOrderItems { get; set; }
        public DbSet<ReleaseOrder> ReleaseOrders { get; set; }
        public DbSet<ReleaseOrderItem> ReleaseOrderItems { get; set; }
        public DbSet<StockTransfer> StockTransfers { get; set; }
        public DbSet<StockTransferItem> StockTransferItems { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ItemWarehouse> ItemWarhouses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json").Build();
            var connectionString = config.GetSection("ConnectionStrings")["DefaultConnection"];
            optionsBuilder.UseSqlServer(connectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Stock Transfer - Warehouse Relationships
            modelBuilder.Entity<StockTransfer>()
                .HasOne(st => st.SourceWarehouse)
                .WithMany(w => w.SourceTransfers)
                .HasForeignKey(st => st.SourceWarehouseID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockTransfer>()
                .HasOne(st => st.DestinationWarehouse)
                .WithMany(w => w.DestinationTransfers)
                .HasForeignKey(st => st.DestinationWarehouseID)
                .OnDelete(DeleteBehavior.Restrict);



            // ✅ Composite Keys
            modelBuilder.Entity<ReleaseOrderItem>().HasKey(roi => new { roi.ReleaseOrderID, roi.ItemID });
            modelBuilder.Entity<SupplyOrderItem>().HasKey(soi => new { soi.SupplyOrderID, soi.ItemID });
            modelBuilder.Entity<StockTransferItem>().HasKey(sti => new { sti.stockTransferID, sti.ItemId });
            modelBuilder.Entity<ItemWarehouse>().HasKey(iw => new { iw.ItemId, iw.WarehouseId });

            modelBuilder.Entity<SupplyOrderItem>()
            .HasOne(i => i.Item)
            .WithMany()
            .HasForeignKey(f => new {f.WarehouseId, f.ItemID})
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SupplyOrder>()
           .HasOne(i => i.Warehouse)
           .WithMany()
           .HasForeignKey(f => f.WarehouseName)
           .HasPrincipalKey(w => w.WarehouseName)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SupplyOrder>()
           .HasOne(so => so.Supplier)
           .WithMany()
           .HasForeignKey(so => so.SupplierName)
           .HasPrincipalKey(i => i.SupplierName)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ItemWarehouse>()
      .HasKey(iw => new { iw.ItemId, iw.WarehouseId });

            modelBuilder.Entity<ItemWarehouse>()
            .HasOne(iw => iw.Item)
            .WithMany(i => i.ItemWarehouses)
            .HasForeignKey(iw => iw.ItemId)
            .OnDelete(DeleteBehavior.Cascade); 


            modelBuilder.Entity<ItemWarehouse>()
                .HasOne(iw => iw.Warehouse)
                .WithMany(w => w.ItemWarehouses)
                .HasForeignKey(iw => iw.WarehouseId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReleaseOrder>()
       .HasOne(ro => ro.Supplier)
       .WithMany(s=>s.ReleaseOrders)
       .HasForeignKey(ro => ro.SuppilerName)
       .HasPrincipalKey(s => s.SupplierName)
       .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ReleaseOrder>()
         .HasOne(i => i.Warehouse)
         .WithMany()
         .HasForeignKey(f => f.WarehouseName)
         .HasPrincipalKey(w => w.WarehouseName)
         .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<ReleaseOrderItem>()
                .HasOne(i=> i.Item)
                .WithMany()
                .HasForeignKey( f => new { f.WarehouseId, f.ItemID } )
                .OnDelete(DeleteBehavior.Restrict);

     //       modelBuilder.Entity<ReleaseOrderItem>()
     //.HasOne(roi => roi.ReleaseOrder)
     //.WithMany()
     //.HasForeignKey(f => new { f.ReleaseOrderID, f.ItemID }) 
     //.OnDelete(DeleteBehavior.Restrict); 



            modelBuilder.Entity<StockTransferItem>()
                .HasOne(sti => sti.Transfer)
                .WithMany(st => st.StoreTransferItems)
                .HasForeignKey(sti => sti.stockTransferID)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Employee>()
                .Property(u => u.Role)
                .HasConversion<string>();// to ensure the roletype store in db as int


            modelBuilder.Entity<Supplier>()
           .Property(s => s.SupplierName)
           .HasMaxLength(50)
           .IsRequired();
        }
   
    }
}
