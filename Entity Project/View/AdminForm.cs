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
    public partial class AdminForm : Form
    {
        private Employee currentEmployee;

        public AdminForm(Employee employee)
        {
            InitializeComponent();
            currentEmployee = employee;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item itemForm = new Item(currentEmployee);
            itemForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WareHouse warehouseform = new WareHouse(currentEmployee);
            warehouseform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupplyOrder supplyOrder = new SupplyOrder(currentEmployee);
            supplyOrder.Show();
        }
    }
}
