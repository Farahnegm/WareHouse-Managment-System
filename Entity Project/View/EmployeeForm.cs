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
    public partial class EmployeeForm : Form
    {
        private Employee currentEmployee;

        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            currentEmployee = employee;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Customer customerForm = new Customer(currentEmployee);
            customerForm.Show();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item ItemForm = new Item(currentEmployee);
            ItemForm.Show();
        }
    }
}
