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

namespace Entity_Project.Forms
{
    public partial class WareHouse : Form
    {
        private Employee currentUser;

        public WareHouse(Employee user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void LoadData()
        {
            using (var context = new AppDbContext())
            {
                var data = context.Warehouses
                    .Select(w => new
                    {
                        w.WarehouseID,
                        w.WarehouseName,
                        w.WarehouseLocation,
                        w.ResponsiblePersonId
                    })
                    .ToList();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = data;
                dataGridView2.Refresh();

            }
        }

        public void AddWarehouse(RoleType currentUserRole)
        {
            try
            {
                if (currentUserRole == RoleType.Admin)
                {
                    using (var context = new AppDbContext())
                    {
                        int newId;
                        if (!int.TryParse(textBox6.Text.Trim(), out newId))
                        {
                            MessageBox.Show("Invalid Warehouse ID. Please enter a valid number.");
                            return;
                        }

                      
                        newId += 1;


                        var warehouse = new Models.Warehouse
                        {
                            WarehouseID = newId,
                            WarehouseName = textBox2.Text,
                            WarehouseLocation = textBox3.Text
                        };



                        if (int.TryParse(textBox4.Text, out int responsiblePersonId))
                            warehouse.ResponsiblePersonId = responsiblePersonId;


                        context.Warehouses.Add(warehouse);
                        context.SaveChanges();
                    }

                    // Refresh DataGridView after adding
                    Invoke(new Action(() => LoadData()));
                    MessageBox.Show("Warehouse added successfully!");
                }
            }
            

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException?.Message ?? ex.Message);
            }

        }
        public void Search(RoleType currentUserRole)
        {
            if (currentUserRole == RoleType.Admin) {
                using (var context = new AppDbContext())
                {
                    IQueryable<Warehouse> query = context.Warehouses; // faster than context.Warehouses.ToList() w estkhdmha hena el awl 3lshan mt3mlsh kol el data flmemory el awl


                    if (int.TryParse(textBox5.Text, out int warehouseId))
                    {

                        query = query.Where(w => w.WarehouseID == warehouseId);
                    }
                    else
                    {

                        query = query.Where(w => w.WarehouseName.Contains(textBox5.Text));
                    }


                    var data = query.Select(w => new
                    {
                        w.WarehouseID,
                        w.WarehouseName,
                        w.WarehouseLocation,
                        w.ResponsiblePersonId
                    }).ToList();


                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = data;
                    dataGridView2.Refresh();
                }
            }
                
        }

        public void UpdateWarehouse(RoleType currentUserRole)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    
                    if (!int.TryParse(textBox6.Text.Trim(), out int warehouseId))
                    {
                        MessageBox.Show("Invalid Warehouse ID. Please enter a valid number.");
                        return;
                    }

                    // Find the warehouse by ID
                    var warehouse = context.Warehouses.FirstOrDefault(w => w.WarehouseID == warehouseId);

                    if (warehouse == null)
                    {
                        MessageBox.Show("Warehouse not found! Please enter a valid ID.");
                        return;
                    }

                  
                    warehouse.WarehouseName = textBox2.Text.Trim();
                    warehouse.WarehouseLocation = textBox3.Text.Trim();

                    
                    if (int.TryParse(textBox4.Text.Trim(), out int responsiblePersonId))
                    {
                        warehouse.ResponsiblePersonId = responsiblePersonId;
                    }

                    // Save changes
                    context.SaveChanges();

                    // Refresh UI
                    LoadData();

                    MessageBox.Show("Warehouse updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WareHouse_Load(object sender, EventArgs e)
        {

        }

        private void WareHouse_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Button(object sender, EventArgs e)
        {
            AddWarehouse(currentUser.Role);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                textBox6.Text = row.Cells["WarehouseID"].Value.ToString();
                textBox2.Text = row.Cells["WarehouseName"].Value.ToString();
                textBox3.Text = row.Cells["WarehouseLocation"].Value.ToString();
                textBox4.Text = row.Cells["ResponsiblePersonId"].Value?.ToString() ?? ""; // Handle null values
            }


            LoadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
                Search(currentUser.Role);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           UpdateWarehouse(currentUser.Role);
        }
    }
}
