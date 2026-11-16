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
    public partial class AdminTabForm : Form
    {
        public AdminTabForm()
        {
            InitializeComponent();
            LoadForm(new AdminMainForm(), tabPage1);
        }
        
        private void LoadForm(Form childForm, TabPage tab)
        {
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            tab.Controls.Add(childForm);
            childForm.Show();
        }
        private void TabForm_Load(object sender, EventArgs e)
        {

        }
    }
}
