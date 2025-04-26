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
    public partial class Customer : Form
    {
        private Employee currentUser;

        public Customer(Employee user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void LoadData()
        {
            using (var context = new AppDbContext())
            {
                var data = context.Customers
                    .Select(s => new
                    {

                        s.CustomerName,
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

        public void AddCustomer(RoleType currentUserRole)
        {
            try
            { 
                if (currentUserRole == RoleType.Admin || currentUserRole == RoleType.Employee)
                {
                    
                    using (var context = new AppDbContext())
                    {
                        var customer = new Models.Customer
                        {
                            CustomerName = textBox1.Text,
                            Mobile = textBox2.Text,
                            Phone = textBox3.Text,
                            Email = textBox4.Text,
                            Fax = textBox5.Text,
                            Website = textBox6.Text,
                        };

                        context.Customers.Add(customer);
                        context.SaveChanges();
                    }

                    Invoke(new Action(() => LoadData()));
                    MessageBox.Show("Customer added successfully!");
                }
                else
                {
                    MessageBox.Show("You don't have permission to add a customer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        public void Search(RoleType currentUserRole)
        {
        if(currentUserRole == RoleType.Admin|| currentUserRole == RoleType.Employee)
            {

                using (var context = new AppDbContext())
                {
                    IQueryable<Models.Customer> query = context.Customers;

                    if (int.TryParse(SearchtextBox.Text, out int CustomerID))
                    {
                        query = query.Where(w => w.CustomerID == CustomerID);
                    }
                    else
                    {
                        query = query.Where(w => w.CustomerName.Contains(SearchtextBox.Text));
                    }

                    var data = query.Select(w => new
                    {

                        w.CustomerName,
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
            else
            {
                MessageBox.Show("You don't have permission to add a customer.");
            }
            
        }

        public void UpdateCustomer(RoleType currentUserRole)
        {
            try
            {
                if (currentUserRole == RoleType.Admin)
                {
                    using (var context = new AppDbContext())
                    {
                        
                        var customer = context.Customers.FirstOrDefault(c =>
                            c.Mobile == textBox2.Text.Trim());

                        if (customer == null)
                        {
                            MessageBox.Show("Customer not found!");
                            return;
                        }

                        
                        customer.CustomerName = textBox1.Text.Trim();
                        customer.Mobile = textBox2.Text.Trim();
                        customer.Phone = textBox3.Text.Trim();
                        customer.Email = textBox4.Text.Trim();
                        customer.Fax = textBox5.Text.Trim();
                        customer.Website = textBox6.Text.Trim();

                       
                        context.SaveChanges();
                        LoadData();  
                        MessageBox.Show("Customer updated successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("You don't have permission to update a customer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + (ex.InnerException?.Message ?? ex.Message));
            }
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
              
            }
        }
        

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Search(currentUser.Role);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer(currentUser.Role);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateCustomer(currentUser.Role);
        }
    }
}
