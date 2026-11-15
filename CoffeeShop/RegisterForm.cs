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
    public partial class RegisterForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; database=db_coffeshop; uid=root");
        MySqlCommand cmd = new MySqlCommand();
        public RegisterForm()
        {
            InitializeComponent();
        }


        string userType = "";
        private void comboBoxValidation()
        {
            if (cmbBoxUsertype.SelectedIndex == 0)
            {
                userType = cmbBoxUsertype.Text;
            }
            else if (cmbBoxUsertype.SelectedIndex == 1)
            {
                userType = cmbBoxUsertype.Text;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text))
            {
                errorProvider1.SetError(txtBoxUsername, "Empty Value");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                errorProvider1.SetError(txtBoxPassword, "Empty Value");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text))
            {
                errorProvider1.SetError(txtBoxConfirmPassword, "Empty Value");
                isValid = false;
            }
            else if (txtBoxPassword.Text != txtBoxConfirmPassword.Text)
            {
                errorProvider1.SetError(txtBoxConfirmPassword, "Confirm Password do not match");
                isValid = false;
            }

            if (cmbBoxUsertype.SelectedIndex == 0)
            {
                userType = cmbBoxUsertype.Text;
            }
            else if (cmbBoxUsertype.SelectedIndex == 1)
            {
                userType = cmbBoxUsertype.Text;
            }
            else
            {
                errorProvider1.SetError(cmbBoxUsertype, "Please select a User Type");
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            try
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO user_data (username, password, usertype) VALUES (@user, @pass, @utype)";
                cmd.Connection = conn;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user", txtBoxUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtBoxPassword.Text);
                cmd.Parameters.AddWithValue("@utype", userType);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Account registered successfully!");

                Form1 form = new Form1();
                form.MdiParent = this.MdiParent;
                form.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
