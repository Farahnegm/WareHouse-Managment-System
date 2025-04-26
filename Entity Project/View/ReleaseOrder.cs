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
    public partial class ReleaseOrder : Form
    {
        
        public ReleaseOrder()
        {
            InitializeComponent();
        }
       
        public void AddItem()
        {
            using (var db = new AppDbContext())
            {
                db.Warehouses.Load();
                var warehouse = db.Warehouses.FirstOrDefault(w => w.WarehouseName == textBox2.Text);

                if (warehouse != null)
                {
                    db.ItemWarhouses.Load();
                    var itemWarehouse = db.ItemWarhouses
                        .FirstOrDefault(iw => iw.Item.ItemName == textBox3.Text && iw.WarehouseId == warehouse.WarehouseID);

                    if (itemWarehouse != null)
                    {
                        int requestedQuantity = int.Parse(textBox4.Text);
                        if (itemWarehouse.Quantity >= requestedQuantity)
                        {
                            itemWarehouse.Quantity -= requestedQuantity;

                            
                            var releaseOrder = db.ReleaseOrders
                                .OrderByDescending(ro => ro.OrderDate)
                                .FirstOrDefault(ro => ro.OrderDate.Date == DateTime.Now.Date);

                            if (releaseOrder == null)
                            {
                                
                                releaseOrder = new Models.ReleaseOrder
                                {
                                    SuppilerName= textBox1.Text,
                                    WarehouseName= warehouse.WarehouseName,
                                    OrderDate = DateTime.Now
                                };

                                db.ReleaseOrders.Add(releaseOrder);
                                db.SaveChanges(); 
                            }

                         
                            ReleaseOrderItem newOrderItem = new ReleaseOrderItem
                            {
                                ReleaseOrderID = releaseOrder.ReleaseOrderID,  
                                ItemID = itemWarehouse.ItemId,
                                WarehouseId = warehouse.WarehouseID,
                                Quantity = requestedQuantity
                            };

                            db.ReleaseOrderItems.Add(newOrderItem);
                            db.SaveChanges();

                            MessageBox.Show("Item successfully added to release order!");
                        }
                        else
                        {
                            MessageBox.Show("No stock available.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item not found in the specified warehouse.");
                    }
                }
                else
                {
                    MessageBox.Show("Warehouse not found!");
                }
            }
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddItem();


        }

        private void ReleaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
