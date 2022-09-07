using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace register
{
    public partial class crud : Form
    {
        public crud()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void loginformbtn_Click(object sender, EventArgs e)
        {

        }

        private void crud_Load(object sender, EventArgs e)
        {
          
            getstudentsrecord();
        }

        private void getstudentsrecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");
             SqlCommand cmd = new SqlCommand("SELECT * FROM student",con);
            DataTable data = new DataTable();
           
            con.Open();

SqlDataReader s = cmd.ExecuteReader();
            data.Load(s);
            con.Close();

             studentrecorddatagridview.DataSource = data;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtstudentid.Text = studentrecorddatagridview.SelectedRows[0].Cells[1].Value.ToString();
            txtstudentname.Text = studentrecorddatagridview.SelectedRows[0].Cells[2].Value.ToString();
            txtstudentcnic.Text = studentrecorddatagridview.SelectedRows[0].Cells[3].Value.ToString();
            txtstudentregno.Text = studentrecorddatagridview.SelectedRows[0].Cells[4].Value.ToString();
            txtstudentmobile.Text = studentrecorddatagridview.SelectedRows[0].Cells[5].Value.ToString();
           

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO student (student_id,Student_Name,Student_CNIC,Student_RegNo,Student_Mobile,Student_Cgpa) VALUES (@student_id,@Student_Name,@Student_CNIC,@Student_RegNo,@Student_Mobile,@Student_Cgpa)", con);
                  cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@student_id", txtstudentid.Text);
                cmd.Parameters.AddWithValue("@Student_Name", txtstudentname.Text);
                cmd.Parameters.AddWithValue("@Student_CNIC", txtstudentcnic.Text);
                cmd.Parameters.AddWithValue("@Student_RegNo", txtstudentregno.Text);
                cmd.Parameters.AddWithValue("@Student_Mobile", txtstudentmobile.Text);
                cmd.Parameters.AddWithValue("@Student_Cgpa", txtstudentcgpa.Text);


                con.Open();
               cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New student is successfully saved in  database ", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getstudentsrecord();
            }
           
        }

        private bool IsValid()
        {
            if(txtstudentname.Text == string.Empty)
            {
                MessageBox.Show("student name is required ", "failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

      

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE student SET student_id=@student_id,Student_Name=@Student_Name, Student_CNIC=@Student_CNIC, Student_RegNo=@Student_RegNo,Student_Mobile=@Student_Mobile, Student_Cgpa=@Student_Cgpa WHERE student_id=@student_id", con);
            cmd.Parameters.AddWithValue("@student_id",txtstudentid.Text);
            cmd.Parameters.AddWithValue("@Student_Name", txtstudentname.Text);
            cmd.Parameters.AddWithValue("@Student_CNIC", txtstudentcnic.Text);
            cmd.Parameters.AddWithValue("@Student_RegNo", txtstudentregno.Text);
            cmd.Parameters.AddWithValue("@Student_Mobile", txtstudentmobile.Text);
            cmd.Parameters.AddWithValue("@Student_Cgpa", txtstudentcgpa.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            txtstudentid.Text = "";
            txtstudentname.Text = "";
            txtstudentcnic.Text = "";
            txtstudentregno.Text = "";
            txtstudentmobile.Text = "";
            txtstudentcgpa.Text = "";

            MessageBox.Show("Successfully Updated data!!");
            getstudentsrecord();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE student WHERE student_id=@student_id ", con);
            cmd.Parameters.AddWithValue("@student_id", int.Parse(txtstudentid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            txtstudentid.Text = "";
            txtstudentname.Text = "";
            txtstudentcnic.Text = "";
            txtstudentregno.Text = "";
            txtstudentmobile.Text = "";
            txtstudentcgpa.Text = "";

            MessageBox.Show("Successfully Deleted data!!");
            getstudentsrecord();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=student;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE student_id=@student_id ", con);
            cmd.Parameters.AddWithValue("@student_id", int.Parse(txtstudentid.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentrecorddatagridview.DataSource = dt;
        }
    }
}
