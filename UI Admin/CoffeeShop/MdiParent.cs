using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class MdiParent : Form
    {
        public MdiParent()
        {
            InitializeComponent();
        }

        private void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm f2 = new RegisterForm();
            f2.MdiParent = this;
            f2.Show();
        }

        private void adminFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMainForm f3 = new AdminMainForm();
            f3.MdiParent = this;
            f3.Show();
        }

        private void registrationFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CashierForm f4 = new CashierForm();
            f4.MdiParent    = this;
            f4.Show();
        }
    }
}
