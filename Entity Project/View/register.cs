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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();

        }
        public void Usertype()
        {
            // Hide fields by default
            Phone.Visible = false;
            phonetextBox.Visible = false;
            Mobile.Visible = false;
            MobiletextBox.Visible = false;
            Fax.Visible = false;
            FaxtextBox.Visible = false;
            WebsitetextBox.Visible = false;
            Website.Visible = false;
            EmployeecomboBox.Visible = false;
            label1.Visible = false;

            if (comboBox1.SelectedItem == null)
                return;

            string selectedItem = comboBox1.SelectedItem.ToString();
            if (selectedItem == "Customer" || selectedItem == "Supplier")
            {
                Phone.Visible = true;
                phonetextBox.Visible = true;
                Mobile.Visible = true;
                MobiletextBox.Visible = true;
                Fax.Visible = true;
                FaxtextBox.Visible = true;
                WebsitetextBox.Visible = true;
                Website.Visible = true;
            }
            else if (selectedItem == "Employee")
            {
                comboBox1.Visible = false;
                label7.Visible = false;
                Phone.Visible = true;
                phonetextBox.Visible = true;
                EmployeecomboBox.Visible = true;
                label1.Visible = true;

              
                if (EmployeecomboBox.Items.Count == 0)
                {
                    EmployeecomboBox.Items.Add(RoleType.Admin.ToString());
                    EmployeecomboBox.Items.Add(RoleType.Employee.ToString());
                }
            }
        }

        private void RegisterUser(string userType)
        {
            using (var db = new AppDbContext())
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(passwordd.Text); // Hash password

                if (userType == "Supplier")
                {
                    var newSupplier = new Models.Supplier
                    {
                        SupplierName = firstName.Text + " " + LastName.Text,
                        Phone = phonetextBox.Text,
                        Mobile = MobiletextBox.Text,
                        Email = EmailtextBox.Text,
                        Website = WebsitetextBox.Text,
                        Fax = FaxtextBox.Text,
                        HashedPassword = hashedPassword // Save hashed password
                    };

                    db.Suppliers.Add(newSupplier);
                }
                else if (userType == "Customer")
                {
                    var newCustomer = new Models.Customer
                    {
                        CustomerName = firstName.Text + " " + LastName.Text,
                        Phone = phonetextBox.Text,
                        Mobile = MobiletextBox.Text,
                        Email = EmailtextBox.Text,
                        Website = WebsitetextBox.Text,
                        Fax = FaxtextBox.Text,
                        HashedPassword = hashedPassword // Save hashed password
                    };

                    db.Customers.Add(newCustomer);
                }
                else if (userType == "Employee")
                {
                    RoleType selectedRole = (RoleType)Enum.Parse(typeof(RoleType), EmployeecomboBox.SelectedItem.ToString());

                    var newEmployee = new Employee
                    {
                        Name = firstName.Text + " " + LastName.Text,
                        Phone = phonetextBox.Text,
                        Email = EmailtextBox.Text,
                        HashedPassword = hashedPassword, 
                        Role = selectedRole
                    };

                    db.Employees.Add(newEmployee);
                }

                db.SaveChanges();
                MessageBox.Show($"{userType} registered successfully!");
            }
        }

        private bool checkPass()
        {
            string password = passwordd.Text;
            string confirmPassword = Cpasswordd.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            if (password.Length < 8 ||
                !password.Any(char.IsUpper) ||      // At least one uppercase letter
                !password.Any(char.IsLower) ||      // At least one lowercase letter
                !password.Any(char.IsDigit) ||      // At least one digit
                !password.Any(ch => "!@#$%^&*()_+[]{}|;:'\",.<>?/`~".Contains(ch))) // At least one special character
            {
                MessageBox.Show("Password must be at least 8 characters long and include:\n" +
                                "• An uppercase letter\n" +
                                "• A lowercase letter\n" +
                                "• A digit\n" +
                                "• A special character (!@#$%^&*)");
                return false;
            }

            return true;
        }

        



        private void register_Load(object sender, EventArgs e)
        {
            Phone.Visible = false;
            phonetextBox.Visible = false;
            Mobile.Visible = false;
            MobiletextBox.Visible = false;
            Fax.Visible = false;
            FaxtextBox.Visible = false;
            WebsitetextBox.Visible = false;
            Website.Visible = false;
            EmployeecomboBox.Visible = false;
            label1.Visible = false;


            List<string> list = new List<string> { "Customer", "Employee", "Supplier" };
            comboBox1.Items.AddRange(list.ToArray());

        }

        private void Mobile_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usertype();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void MobiletextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkPass())  // Validate password first
            {
                return;
            }

            string userType = null;

            if (comboBox1.SelectedItem != null)
            {
                userType = comboBox1.SelectedItem.ToString();
            }
            else if (EmployeecomboBox.Visible && EmployeecomboBox.SelectedItem != null)
            {
                userType = "Employee";
            }

            if (userType != null)
            {
                RegisterUser(userType);
            }
            else
            {
                MessageBox.Show("Please select a valid user type before registering.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
