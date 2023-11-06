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
    public partial class addloan : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");

        public addloan()
        {
            InitializeComponent();
        }


        private void addloan_Load(object sender, EventArgs e)
        {
            string dat = "select emp_ID, emp_Name from employee";
            SqlCommand cm = new SqlCommand(dat, sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand= cm;
            DataTable dataTable= new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DataRow row = dataTable.NewRow();
            dataTable.Rows.InsertAt(row,0);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "emp_ID";
            comboBox1.ValueMember = "emp_ID";

            string data = "select * from loans";
            SqlCommand cmd = new SqlCommand(data, sql);
            var da = new DataTable("loans");
            var test = new SqlDataAdapter(cmd);
            test.Fill(da);
            dataGridView1.DataSource = da;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datas = "insert into loans (emp_ID, how_many, descs)" +
                "values (@emp_ID, @how_many, @descs)";
            SqlCommand cmd = new SqlCommand(datas, sql);
            cmd.Parameters.AddWithValue("emp_ID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@how_many",textBox1.Text);
            cmd.Parameters.AddWithValue("@descs", textBox2.Text);
            try
            {
                sql.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("the loans already sent.");
                comboBox1.Text = string.Empty;
                textBox1.Text =string.Empty;
                textBox2.Text = string.Empty;
                refresh();
            }catch(Exception ex)
            {
                MessageBox.Show("the loans cannot be sent");
                MessageBox.Show(ex.Message);
                refresh();
                sql.Close();
            }
        }
        public void refresh()
        {
            SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from loans", sql);
            DataSet ds = new DataSet();
            da.Fill(ds,"loans");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "loans";
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string update ="update loans set " +
                "emp_ID = @emp_ID, how_many = @how_many, descs = @descs where loans_ID=@loans_ID ";
            SqlCommand upd = new SqlCommand(update, sql);
            upd.Parameters.AddWithValue("emp_ID", comboBox1.Text);
            upd.Parameters.AddWithValue("@how_many", textBox1.Text);
            upd.Parameters.AddWithValue("@descs", textBox2.Text);

            sql.Open();
            int row = upd.ExecuteNonQuery();
            sql.Close();
            if(row > 0)
            {
                MessageBox.Show("Request is already modify");
                refresh();
            }
            else
            {
                MessageBox.Show("The request failed modify");
                refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["emp_ID"].FormattedValue.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["how_many"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["descs"].FormattedValue.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string del = "delete from employee where emp_ID = @emp_ID";
            SqlCommand dele = new SqlCommand(del, sql);
            dele.Parameters.AddWithValue("@emp_ID", textBox1.Text);
            sql.Open();
            int row = dele.ExecuteNonQuery();
            sql.Close();
            if(row > 0)
            {
                MessageBox.Show("Data karyawan berhasil dihapus!");
                refresh();
            }
            else
            {
                MessageBox.Show("Data karyawan berhasil gagal di hapus");
                refresh();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
