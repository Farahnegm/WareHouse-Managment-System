using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entity_Project.Models;

using Microsoft.EntityFrameworkCore;


namespace Entity_Project.Forms
{
    public partial class SupplyOrder : Form
    {
        Models.SupplyOrder newSupplyOrder;
        private Employee currentUser;

        public SupplyOrder(Employee user)
        {
            InitializeComponent();
            currentUser = user;
        }

        public void supplyOrder(RoleType currentUserRole)
        {
            if (currentUserRole == RoleType.Admin || currentUserRole == RoleType.Employee)
            {
                using (var db = new AppDbContext())
                {
                    db.Items.Load();
                    db.Warehouses.Load();
                    List<Models.Item> items = db.Items.ToList();
                    int supplyOrderID;


                    var warehouse = db.Warehouses.FirstOrDefault(w => w.WarehouseName == textBox4.Text);
                    if (warehouse == null)
                    {
                        warehouse = new Models.Warehouse { WarehouseName = textBox4.Text };
                        db.Warehouses.Add(warehouse);
                        db.SaveChanges();
                    }


                    if (!int.TryParse(textBox3.Text, out supplyOrderID) || !db.SupplyOrders.Any(o => o.SupplyOrderID == supplyOrderID))
                    {
                        newSupplyOrder = new Models.SupplyOrder
                        {
                            SupplierName = textBox2.Text,
                            OrderDate = DateTime.Now,
                            WarehouseName = textBox4.Text,
                            Warehouse = warehouse,

                        };
                        db.SupplyOrders.Add(newSupplyOrder);
                        db.SaveChanges();
                        supplyOrderID = newSupplyOrder.SupplyOrderID;
                        textBox3.Text = supplyOrderID.ToString();
                    }


                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string itemName = row.Cells["Column3"].Value?.ToString()?.Trim() ?? "Unknown Item";
                            int quantity = Convert.ToInt32(row.Cells["Column2"].Value);

                            var item = db.Items.FirstOrDefault(i => i.ItemName == itemName);
                            if (item == null)
                            {
                                item = new Models.Item { ItemName = itemName, UnitOfMeasure = "Default" };
                                db.Items.Add(item);
                                db.SaveChanges();
                            }


                            var itemWarehouse = db.ItemWarhouses
                                 .FirstOrDefault(iw => iw.ItemId == item.ItemId && iw.WarehouseId == warehouse.WarehouseID);

                            if (itemWarehouse == null)
                            {
                                itemWarehouse = new Models.ItemWarehouse
                                {
                                    ItemId = item.ItemId,
                                    WarehouseId = warehouse.WarehouseID,
                                    Quantity = quantity
                                };
                                db.ItemWarhouses.Add(itemWarehouse);
                            }
                            else
                            {
                                itemWarehouse.Quantity += quantity;
                            }

                            db.SaveChanges();


                            row.Cells["Item"].Value = item.ItemId;


                            DateTime.TryParse(row.Cells["Column5"].Value?.ToString(), out DateTime prodDate);
                            DateTime.TryParse(row.Cells["Column6"].Value?.ToString(), out DateTime expDate);

                            var supplyOrderItem = new SupplyOrderItem
                            {
                                ItemID = item.ItemId,
                                Quantity = quantity,
                                ProductionDate = prodDate,
                                ExpirationDate = expDate,
                                SupplyOrderID = supplyOrderID,
                                WarehouseId = warehouse.WarehouseID
                            };

                            db.SupplyOrderItems.Add(supplyOrderItem);
                        }
                    }
                    db.SaveChanges();

                    button1.Text = "Pending";
                            button1.BackColor = Color.Yellow;
                            button1.ForeColor = Color.Black;

                            MessageBox.Show("Your Supply Order request has been sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            



        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns["Production Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["Expiration Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supplyOrder(currentUser.Role);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SupplyOrder_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
