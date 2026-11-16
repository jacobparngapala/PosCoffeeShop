using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CoffeeShop
{
    public partial class AdminMainForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; database=db_coffeshop; uid=root");
        MySqlCommand cmd = new MySqlCommand();
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d MMMM yyyy, hh:mm:ss:tt");
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                cmd.CommandText = "UPDATE ";
                this.Close();
            }
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            Inventorycs InventoryFrm = new Inventorycs();
            InventoryFrm.MdiParent = this.MdiParent;

            InventoryFrm.Show();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            Usermanagement UsermanagementFrm = new Usermanagement();
            UsermanagementFrm.MdiParent = this.MdiParent;

            UsermanagementFrm.Show();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuForm MenuFrm = new MenuForm();
            MenuFrm.MdiParent = this.MdiParent;

            MenuFrm.Show();
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            TransactionForm TransactionFrm = new TransactionForm();
            TransactionFrm.MdiParent = this.MdiParent;

            TransactionFrm.Show();
        }

        private void BtnInventoryReport_Click(object sender, EventArgs e)
        {
            InventoryReport InventoryreportFrm = new InventoryReport();
            InventoryreportFrm.MdiParent = this.MdiParent;

            InventoryreportFrm.Show();
        }

        private void BtnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport SalesreportFrm = new SalesReport();
            SalesreportFrm.MdiParent = this.MdiParent;

            SalesreportFrm.Show();
        }
    }
}
