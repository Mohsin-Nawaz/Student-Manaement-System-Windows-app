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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader dr;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");
            con.Open();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            //      registration_form u = new registration_form();
            //      Console.WriteLine(u);
            //string user = txtUserName.Text;
            //     string pass = txtPassword.Text;

            /*    if(user == "m"  && pass == "1")
                 {
                     this.Hide();
                     crud c = new crud();

                     c.Show();
                 }
                 else
                 {
                     MessageBox.Show("password or username is incorrect...");
                 }*/
            con.Open();

            if (txtpassword.Text != string.Empty || txtuser.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from tbllogin where username='" + txtuser.Text + "' and password='" + txtpassword.Text + "'", con);

            

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                this.Hide();
                crud c = new crud();
                c.ShowDialog();
            }
            else
            {
                dr.Close();
                MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   

             else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

           


        

        private void createaccountbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration_form f = new registration_form();
            f.Show();


        }
    }
}
