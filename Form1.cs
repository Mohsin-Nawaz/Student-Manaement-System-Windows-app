using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace register
{
    public partial class registration_form : Form
    {
        public registration_form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            string us = txtuser.Text;

            
        }

        private void registration_form_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");
            con.Open();
        }



        private void signupbtn_Click(object sender, EventArgs e)

        {

            /* if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtuser.Text != string.Empty)
             {
                 if (txtpassword.Text != txtconfirmpassword.Text)
                 {
                         MessageBox.Show("Password not matches please try again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                     else
                     {

                         MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     }
             }


             else
             {
                 MessageBox.Show("Please enter correct  value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/

            SqlCommand cmd;
            SqlDataReader dr;
            con.Open();

            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtuser.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {

                    cmd = new SqlCommand("SELECT * FROM   tbllogin where username='" + txtuser + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("INSERT INTO tbllogin values(@username,@password)", con);
                        cmd.Parameters.AddWithValue("username", txtuser.Text);
                        cmd.Parameters.AddWithValue("password", txtpassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            login registration = new login();
            registration.ShowDialog();
        }

        private void txtconfirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void signupformbtn_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpassword.Text= "";
            txtconfirmpassword.Text = "";
        }
    }
}
