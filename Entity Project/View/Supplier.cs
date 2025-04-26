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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (var context = new Models.AppDbContext())
            {
                var data = context.Suppliers
                    .Select(s => new
                    {
                        s.SupplierID,
                        s.SupplierName,
                        s.Mobile,
                        s.Phone,
                        s.Email,
                        s.Fax,
                        s.Website
                    })
                    .ToList();

                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
        }

        public void AddSupplier()
        {
            try
            {
                using (var context = new Models.AppDbContext())
                {
                    int newId = context.Suppliers.Any()
                ? context.Suppliers.Max(s => s.SupplierID) + 1 // value if true 
                      : 1;// value if false
                    var supplier = new Models.Supplier
                    {
                        SupplierID = newId,
                        SupplierName = textBox2.Text,
                        Mobile = textBox3.Text,
                        Phone = textBox4.Text,
                        Email = textBox5.Text,
                        Fax = textBox6.Text,
                        Website = textBox7.Text,


                    };
                    context.Suppliers.Add(supplier);
                    context.SaveChanges();
                }

                // Refresh DataGridView after adding
                Invoke(new Action(() => LoadData()));
                MessageBox.Show("Supplier added successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException?.Message ?? ex.Message);
            }

        }
        public void Search()
        {
            using (var context = new AppDbContext())
            {
                IQueryable<Models.Supplier> query = context.Suppliers;

                if (int.TryParse(textBox8.Text, out int supplierID))
                {
                    query = query.Where(w => w.SupplierID == supplierID);
                }
                else
                {
                    query = query.Where(w => w.SupplierName.Contains(textBox8.Text));
                }

                var data = query.Select(w => new
                {
                    w.SupplierID,
                    w.SupplierName,
                    w.Mobile,
                    w.Phone,
                    w.Email,
                    w.Fax,
                    w.Website
                }).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
        }

        public void UpdateSupplier()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // Validate SupplierID
                    if (!int.TryParse(textBox1.Text, out int supplierID))
                    {
                        MessageBox.Show("Invalid Supplier ID. Please select a record first.");
                        return;
                    }

                    var supplier = context.Suppliers.FirstOrDefault(s => s.SupplierID == supplierID);
                    if (supplier == null)
                    {
                        MessageBox.Show("Supplier not found!");
                        return;
                    }

                    // Update supplier details
                    supplier.SupplierName = textBox2.Text.Trim();
                    supplier.Mobile = textBox3.Text.Trim();
                    supplier.Phone = textBox4.Text.Trim();
                    supplier.Email = textBox5.Text.Trim();
                    supplier.Fax = textBox6.Text.Trim();
                    supplier.Website = textBox7.Text.Trim();

                    // Save changes
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Supplier updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSupplier();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateSupplier();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Using column index instead of column names (safer)
                textBox1.Text = row.Cells[0].Value?.ToString() ?? "";
                textBox2.Text = row.Cells[1].Value?.ToString() ?? "";
                textBox3.Text = row.Cells[2].Value?.ToString() ?? "";
                textBox4.Text = row.Cells[3].Value?.ToString() ?? "";
                textBox5.Text = row.Cells[4].Value?.ToString() ?? "";
                textBox6.Text = row.Cells[5].Value?.ToString() ?? "";
                textBox7.Text = row.Cells[6].Value?.ToString() ?? "";
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }
    }
}
