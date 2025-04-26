using System.Linq;
using Entity_Project.Forms;
using Entity_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using Org.BouncyCastle.Crypto.Generators;

namespace Entity_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public RoleType? CheckUser()
        {
            using (var db = new AppDbContext())
            {
                db.Employees.Load();
                db.Suppliers.Load();
                db.Customers.Load();

                string userEmail = EmailtextBox.Text;
                string password = PasswordtextBox.Text;

                if (string.IsNullOrEmpty(userEmail))
                {
                    MessageBox.Show("Please enter your Email");
                    return null;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter your Password");
                    return null;
                }

               
                var employee = db.Employees.FirstOrDefault(e => e.Email == userEmail);
                if (employee != null && !string.IsNullOrEmpty(employee.HashedPassword))
                {
                    if (BCrypt.Net.BCrypt.Verify(password, employee.HashedPassword))
                    {
                        MessageBox.Show($"Login Successful! Welcome, {employee.Name}");

                        if (employee.Role == RoleType.Admin)
                        {
                            AdminForm adminForm = new AdminForm(employee);
                            adminForm.Show();
                        }
                        else if (employee.Role == RoleType.Employee)
                        {
                            EmployeeForm employeeForm = new EmployeeForm(employee);
                            employeeForm.Show();
                        }

                        this.Hide();
                        return employee.Role;
                    }
                }

                
                var customer = db.Customers.FirstOrDefault(c => c.Email == userEmail);
                if (customer != null && !string.IsNullOrEmpty(customer.HashedPassword))
                {
                    if (BCrypt.Net.BCrypt.Verify(password, customer.HashedPassword))
                    {
                        MessageBox.Show($"Login Successful! Welcome, {customer.CustomerName}");
                        return null;
                    }
                }

                // Check Supplier
                var supplier = db.Suppliers.FirstOrDefault(s => s.Email == userEmail);
                if (supplier != null && !string.IsNullOrEmpty(supplier.HashedPassword))
                {
                    if (BCrypt.Net.BCrypt.Verify(password, supplier.HashedPassword))
                    {
                        MessageBox.Show($"Login Successful! Welcome, {supplier.SupplierName}");
                        return null;
                    }
                }

                // Check if the email exists but password is incorrect
                if (db.Customers.Any(c => c.Email == userEmail) ||
                    db.Suppliers.Any(s => s.Email == userEmail) ||
                    db.Employees.Any(e => e.Email == userEmail))
                {
                    MessageBox.Show("Incorrect password. Please try again.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("User not found!\nWould you like to create a new account?",
                                                          "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        register registerForm = new register();
                        registerForm.Show();
                    }
                }

                return null;
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckUser();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
            this.Close();
        }
    }
}
