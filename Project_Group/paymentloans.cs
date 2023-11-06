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

namespace Project_Group
{
    public partial class paymentloans : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");

        public paymentloans()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void paymentloans_Load(object sender, EventArgs e)
        {
            string datas = "select * from paymentloans";
            SqlCommand cmd = new SqlCommand(datas, sql);
            var da = new DataTable("employee");
            var test = new SqlDataAdapter(cmd);
            sql.Open();
            test.Fill(da);
            dataGridView1.DataSource = da;
            sql.Close();
            combox();
        }
       public void combox()
        {
            SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
            string datas = "select * from loans";
            SqlCommand cmd = new SqlCommand(datas, sql);
            SqlDataReader read;
            try
            {
                sql.Open();
                read = cmd.ExecuteReader();
                while (read.Read()) {

                    string loansid = read.GetInt32(0).ToString();

                    comboBox1.Items.Add(loansid);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                sql.Close();
               
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
            string datas = "select * from loans where loans_ID ='" + comboBox1.Text+"'; ";
            SqlCommand cmd = new SqlCommand(datas, sql);
            SqlDataReader read;
            try
            {
                sql.Open();
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string empid = read.GetString(1).ToString();
                    string amount = read.GetInt32(2).ToString();
                    textBox2.Text = empid;
                    textBox3.Text = amount;
                   
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                sql.Close();
               
            }
            }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dat = "insert into paymentloans (loans_ID ,emp_ID ,total ,date_pay) values (@loans_ID ,@emp_ID ,@total ,@date_pay)";
            SqlCommand cm = new SqlCommand(dat, sql);
            cm.Parameters.AddWithValue("@loans_ID", comboBox1.Text);
            cm.Parameters.AddWithValue("@emp_ID", textBox2.Text);
            cm.Parameters.AddWithValue("@total",textBox3.Text);
            cm.Parameters.AddWithValue("@date_pay", dateTimePicker1.Text);
            try
            {
                sql.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Data Masuk");
                string datas = "select * from paymentloans";
                SqlCommand cmd = new SqlCommand(datas, sql);
                var da = new DataTable("employee");
                var test = new SqlDataAdapter(cmd);
               
                test.Fill(da);
                dataGridView1.DataSource = da;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                sql.Close();
            }

        }
    }
}
