using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Project.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                    table.UniqueConstraint("AK_Suppliers_SupplierName", x => x.SupplierName);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WarehouseLocation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ResponsiblePersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseID);
                    table.UniqueConstraint("AK_Warehouses_WarehouseName", x => x.WarehouseName);
                    table.ForeignKey(
                        name: "FK_Warehouses_Employees_ResponsiblePersonId",
                        column: x => x.ResponsiblePersonId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "ItemWarhouses",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemWarhouses", x => new { x.ItemId, x.WarehouseId });
                    table.ForeignKey(
                        name: "FK_ItemWarhouses_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemWarhouses_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseOrders",
                columns: table => new
                {
                    ReleaseOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuppilerName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseOrders", x => x.ReleaseOrderID);
                    table.ForeignKey(
                        name: "FK_ReleaseOrders_Suppliers_SuppilerName",
                        column: x => x.SuppilerName,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierName");
                    table.ForeignKey(
                        name: "FK_ReleaseOrders_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID");
                    table.ForeignKey(
                        name: "FK_ReleaseOrders_Warehouses_WarehouseName",
                        column: x => x.WarehouseName,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockTransfers",
                columns: table => new
                {
                    StockTransferID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SourceWarehouseID = table.Column<int>(type: "int", nullable: false),
                    DestinationWarehouseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransfers", x => x.StockTransferID);
                    table.ForeignKey(
                        name: "FK_StockTransfers_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockTransfers_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockTransfers_Warehouses_DestinationWarehouseID",
                        column: x => x.DestinationWarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransfers_Warehouses_SourceWarehouseID",
                        column: x => x.SourceWarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierWarehouse",
                columns: table => new
                {
                    SuppliersSupplierID = table.Column<int>(type: "int", nullable: false),
                    WarehousesWarehouseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierWarehouse", x => new { x.SuppliersSupplierID, x.WarehousesWarehouseID });
                    table.ForeignKey(
                        name: "FK_SupplierWarehouse_Suppliers_SuppliersSupplierID",
                        column: x => x.SuppliersSupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierWarehouse_Warehouses_WarehousesWarehouseID",
                        column: x => x.WarehousesWarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyOrders",
                columns: table => new
                {
                    SupplyOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: true),
                    WarehouseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyOrders", x => x.SupplyOrderID);
                    table.ForeignKey(
                        name: "FK_SupplyOrders_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID");
                    table.ForeignKey(
                        name: "FK_SupplyOrders_Suppliers_SupplierName",
                        column: x => x.SupplierName,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplyOrders_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID");
                    table.ForeignKey(
                        name: "FK_SupplyOrders_Warehouses_WarehouseName",
                        column: x => x.WarehouseName,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseOrderItems",
                columns: table => new
                {
                    ReleaseOrderID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseOrderItems", x => new { x.ReleaseOrderID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_ReleaseOrderItems_ItemWarhouses_WarehouseId_ItemID",
                        columns: x => new { x.WarehouseId, x.ItemID },
                        principalTable: "ItemWarhouses",
                        principalColumns: new[] { "ItemId", "WarehouseId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReleaseOrderItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReleaseOrderItems_ReleaseOrders_ReleaseOrderID",
                        column: x => x.ReleaseOrderID,
                        principalTable: "ReleaseOrders",
                        principalColumn: "ReleaseOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockTransferItems",
                columns: table => new
                {
                    stockTransferID = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransferItems", x => new { x.stockTransferID, x.ItemId });
                    table.ForeignKey(
                        name: "FK_StockTransferItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockTransferItems_StockTransfers_stockTransferID",
                        column: x => x.stockTransferID,
                        principalTable: "StockTransfers",
                        principalColumn: "StockTransferID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplyOrderItems",
                columns: table => new
                {
                    SupplyOrderID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyOrderItems", x => new { x.SupplyOrderID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_SupplyOrderItems_ItemWarhouses_WarehouseId_ItemID",
                        columns: x => new { x.WarehouseId, x.ItemID },
                        principalTable: "ItemWarhouses",
                        principalColumns: new[] { "ItemId", "WarehouseId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplyOrderItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyOrderItems_SupplyOrders_SupplyOrderID",
                        column: x => x.SupplyOrderID,
                        principalTable: "SupplyOrders",
                        principalColumn: "SupplyOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemWarhouses_WarehouseId",
                table: "ItemWarhouses",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseOrderItems_ItemID",
                table: "ReleaseOrderItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseOrderItems_WarehouseId_ItemID",
                table: "ReleaseOrderItems",
                columns: new[] { "WarehouseId", "ItemID" });

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseOrders_SuppilerName",
                table: "ReleaseOrders",
                column: "SuppilerName");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseOrders_WarehouseID",
                table: "ReleaseOrders",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseOrders_WarehouseName",
                table: "ReleaseOrders",
                column: "WarehouseName");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransferItems_ItemId",
                table: "StockTransferItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransfers_DestinationWarehouseID",
                table: "StockTransfers",
                column: "DestinationWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransfers_ItemId",
                table: "StockTransfers",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransfers_SourceWarehouseID",
                table: "StockTransfers",
                column: "SourceWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransfers_SupplierID",
                table: "StockTransfers",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierWarehouse_WarehousesWarehouseID",
                table: "SupplierWarehouse",
                column: "WarehousesWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrderItems_ItemID",
                table: "SupplyOrderItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrderItems_WarehouseId_ItemID",
                table: "SupplyOrderItems",
                columns: new[] { "WarehouseId", "ItemID" });

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrders_SupplierID",
                table: "SupplyOrders",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrders_SupplierName",
                table: "SupplyOrders",
                column: "SupplierName");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrders_WarehouseID",
                table: "SupplyOrders",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrders_WarehouseName",
                table: "SupplyOrders",
                column: "WarehouseName");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_ResponsiblePersonId",
                table: "Warehouses",
                column: "ResponsiblePersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ReleaseOrderItems");

            migrationBuilder.DropTable(
                name: "StockTransferItems");

            migrationBuilder.DropTable(
                name: "SupplierWarehouse");

            migrationBuilder.DropTable(
                name: "SupplyOrderItems");

            migrationBuilder.DropTable(
                name: "ReleaseOrders");

            migrationBuilder.DropTable(
                name: "StockTransfers");

            migrationBuilder.DropTable(
                name: "ItemWarhouses");

            migrationBuilder.DropTable(
                name: "SupplyOrders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
