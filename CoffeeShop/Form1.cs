using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BAWALYAN = new ErrorProvider();
            BAWALYAN.ContainerControl = this;

            PASSWORDNGANI.UseSystemPasswordChar = true;

        }
        MySqlConnection conn = new MySqlConnection("server = localhost; database = db_coffeshop; uid = root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        string selectedRole = "";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PASSWORDNGANI.UseSystemPasswordChar = !PAKITAMO.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";

            ADMINNGANI.Image = Properties.Resources.admin_brown__1_;
            CASHIERNGANI.Image = Properties.Resources.cashier_creme__1_;
        }

        private void CASHIERNGANI_Click(object sender, EventArgs e)
        {
            selectedRole = "Cashier";

            ADMINNGANI.Image = Properties.Resources.admin_creme__1_;
            CASHIERNGANI.Image = Properties.Resources.cashier_brown__1_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAWALYAN.Clear();

            string username = USNGANI.Text;
            string password = PASSWORDNGANI.Text;

            if(username == "")
            {
                MessageBox.Show("Please enter your Username");
                BAWALYAN.SetError(USNGANI, "Please enter your Username");
            }

            if (password == "")
            {
                MessageBox.Show("Please enter your Password");
                BAWALYAN.SetError(PASSWORDNGANI, "Please enter your Password");
            }

            MySqlDataReader dr;
            DataSet ds = new DataSet();

            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd.CommandText = "SELECT * FROM user_data WHERE Username = @user AND Password = @pass AND UserType = @utype";
            cmd.Connection = conn;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user", USNGANI.Text);
            cmd.Parameters.AddWithValue("@pass", PASSWORDNGANI.Text);
            cmd.Parameters.AddWithValue("@utype", selectedRole);
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                string role = dr[3].ToString();
                MessageBox.Show("Login Successful!");

                if (role == "Admin")
                {
                    AdminMainForm form1 = new AdminMainForm();  
                    form1.MdiParent = this.MdiParent;

                    form1.Show();
                }
                else if (role == "Cashier")
                {
                    CashierForm form2 = new CashierForm();
                    form2.MdiParent= this.MdiParent;

                    form2.Show();
                }
            }
            else
            {
                MessageBox.Show("No Record found.");
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.MdiParent = this.MdiParent;

            form.Show();
            this.Hide();
        }
    }
}
