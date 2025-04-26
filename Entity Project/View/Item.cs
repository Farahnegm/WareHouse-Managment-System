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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Entity_Project.Forms
{
    public partial class Item : Form
    {
        private Employee currentUser;

        public Item(Employee user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void LoadData()
        {
            using (var context = new AppDbContext())
            {
                var data = context.Items
                    .Select(s => new
                    {

                        s.ItemName,
                        s.UnitOfMeasure,

                    })
                    .ToList();

                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
        }

        public void AddItem(RoleType currentUserRole)
        {
            try
            {
                if (currentUserRole == RoleType.Admin || currentUserRole == RoleType.Employee)
                {
                    using (var context = new AppDbContext())
                    {

                        var item = new Models.Item
                        {

                            ItemName = textBox1.Text,
                            UnitOfMeasure = textBox2.Text,



                        };
                        context.Items.Add(item);
                        context.SaveChanges();
                    }

                    // Refresh DataGridView after adding
                    Invoke(new Action(() => LoadData()));
                    MessageBox.Show("Item added successfully!");
                }
            }
                   

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException?.Message ?? ex.Message);
            }

        }
        public void Search(RoleType currentUserRole)
        {
            if (currentUserRole == RoleType.Admin || currentUserRole == RoleType.Employee)
            {
                using (var context = new AppDbContext())
                {
                    IQueryable<Models.Item> query = context.Items;

                    if (int.TryParse(textBox3.Text, out int ItemId))
                    {
                        query = query.Where(w => w.ItemId == ItemId);
                    }
                    else
                    {
                        query = query.Where(w => w.ItemName.Contains(textBox3.Text));
                    }

                    var data = query.Select(i => new
                    {
                        i.ItemId,
                        i.ItemName,
                        i.UnitOfMeasure,

                    }).ToList();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = data;
                    dataGridView1.Refresh();
                }
            }
                
        }

        public void updateItem(RoleType currentUserRole)
        {
            try
            {
                if (currentUserRole == RoleType.Admin || currentUserRole == RoleType.Employee)
                {
                    using (var context = new AppDbContext())
                    {


                        int itemId;
                        if (!int.TryParse(label4.Text.Trim(), out itemId))
                        {
                            MessageBox.Show("Invalid Item ID!");
                            return;
                        }

                        var item = context.Items.FirstOrDefault(i => i.ItemId == itemId);
                        if (item == null)
                        {
                            MessageBox.Show("Item not found!");
                            return;
                        }

                        // Update fields
                        item.ItemName = textBox1.Text.Trim();
                        item.UnitOfMeasure = textBox2.Text.Trim();

                        // Save changes to the database
                        context.SaveChanges();
                        LoadData(); // Refresh the DataGridView
                        MessageBox.Show("Item updated successfully!");
                    }
                }
            }
                
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem(currentUser.Role);
        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Using column index instead of column names (safer)
                label4.Text = row.Cells[0].Value?.ToString() ?? "";
                textBox1.Text = row.Cells[1].Value?.ToString() ?? "";
                textBox2.Text = row.Cells[2].Value?.ToString() ?? "";



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateItem(currentUser.Role);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Search(currentUser.Role);
        }
    }
}
