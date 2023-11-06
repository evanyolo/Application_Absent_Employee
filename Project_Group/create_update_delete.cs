using CrystalDecisions.Windows.Forms;
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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;


namespace Project_Group
{
    public partial class create_update_delete : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
        string gender;
       
        public create_update_delete()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void create_update_delete_Load(object sender, EventArgs e)
        {
            string datas = "select * from employee";
            SqlCommand cmd = new SqlCommand(datas, sql);
            var da = new DataTable("employee");
            var test = new SqlDataAdapter(cmd);
            test.Fill(da);
            dataGridView1.DataSource = da;

        }
        public void grid_refresh(){
            SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from employee", sql);
            DataSet ds = new DataSet();
            da.Fill(ds,"employee");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "employee";
            sql.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = "F";
            }
            else
            {
                gender = "M";
            }
            string dat = "insert into employee (emp_ID, emp_Name, emp_phone , emp_gender ,emp_email , dob, emp_role)" +
               "values (@emp_ID, @emp_Name, @emp_phone , @emp_gender , @emp_email , @dob, @emp_role)";
            SqlCommand cm = new SqlCommand(dat, sql);
            cm.Parameters.AddWithValue("@emp_ID", txt1.Text);
            cm.Parameters.AddWithValue("@emp_Name", txt2.Text);
            cm.Parameters.AddWithValue("@emp_phone", txt3.Text);
            cm.Parameters.AddWithValue("@emp_gender", gender);
            cm.Parameters.AddWithValue("@emp_email", txt5.Text);
            cm.Parameters.AddWithValue("@dob",dateTimePicker1.Text);
            cm.Parameters.AddWithValue("@emp_role", txt7.Text);
            try
            {
                sql.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Data sudah masuk");
                grid_refresh();
                txt1.Text = string.Empty;
                txt2.Text = string.Empty;
                txt3.Text = string.Empty;
                txt5.Text = string.Empty;
                gender = string.Empty;
                txt7.Text = string.Empty;
            } catch {
                MessageBox.Show("Data tidak ke tambah");
                grid_refresh();
            }
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = "F";
            }
            else
            {
                gender = "M";
            }
            string update = "UPDATE employee SET " +
                "emp_ID = @emp_ID, emp_Name = @emp_Name, emp_gender = @emp_gender, emp_email = @emp_email, emp_phone=@emp_phone, dob = @dob, emp_role= @emp_role WHERE emp_ID = @emp_ID";
            SqlCommand upd = new SqlCommand(update, sql);
            upd.Parameters.AddWithValue("@emp_ID", txt1.Text);
            upd.Parameters.AddWithValue("@emp_Name", txt2.Text);
            upd.Parameters.AddWithValue("@emp_phone", txt3.Text);
            upd.Parameters.AddWithValue("@emp_gender", gender);
            upd.Parameters.AddWithValue("@emp_email", txt5.Text);
            upd.Parameters.AddWithValue("@dob", dateTimePicker1.Text);
            upd.Parameters.AddWithValue("@emp_role", txt7.Text);
            sql.Open();
            int row = upd.ExecuteNonQuery();
            sql.Close();
            if(row > 0)
            {
                MessageBox.Show("Data karyawan berhasil di update");
                grid_refresh();
                txt1.Text = string.Empty;
                txt2.Text = string.Empty;
                txt3.Text = string.Empty;
               
                txt5.Text = string.Empty;
                gender = string.Empty;
                txt7.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Data karyawan gagal di update");
                grid_refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
            string delete = "delete from employee where emp_ID = @emp_ID";
            SqlCommand del = new SqlCommand(delete, sql);
            del.Parameters.AddWithValue("@emp_ID", txt1.Text);
            sql.Open();
            int row = del.ExecuteNonQuery();
            sql.Close();
            if (row > 0)
            {
                MessageBox.Show("Data karyawan berhasil dihapus!");
                grid_refresh();
                txt1.Text = string.Empty;
                txt2.Text = string.Empty;
                txt3.Text = string.Empty;
                txt5.Text = string.Empty;
                gender = string.Empty;
                txt7.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Data karyawan berhasil gagal di hapus");
                grid_refresh();

            }
           
               
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txt1.Text = dataGridView1.Rows[e.RowIndex].Cells["emp_ID"].FormattedValue.ToString();
                txt2.Text = dataGridView1.Rows[e.RowIndex].Cells["emp_Name"].FormattedValue.ToString();
                txt3.Text = dataGridView1.Rows[e.RowIndex].Cells["emp_phone"].FormattedValue.ToString();
                string gender = dataGridView1.Rows[e.RowIndex].Cells["emp_gender"].FormattedValue.ToString();
                txt5.Text = dataGridView1.Rows[e.RowIndex].Cells["emp_email"].FormattedValue.ToString();

                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["dob"].FormattedValue.ToString();
                txt7.Text = dataGridView1.Rows[e.RowIndex].Cells["emp_role"].FormattedValue.ToString();
                if (gender == "F")
                {
                    radioButton1.Checked = true; 
                }
                else if (gender == "M")
                {
                    radioButton2.Checked = true; 
                }
                else
                {
                    
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }  
            }
            else
            {
                MessageBox.Show("Wrong click");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                gender = "F";
            }
            else if (radioButton2.Checked == true)
            {
                gender = "M";
            }
            printdata genders = new printdata();
            printgenders gen = new printgenders();
            genders.SetParameterValue("gender", gender);
            gen.crystalReportViewer1.ReportSource = genders;
            gen.Show();
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            crys1 role = new crys1();
            report2 report2 = new report2();
            role.SetParameterValue("role", txt7.Text);
            report2.crystalReportViewer2.ReportSource = role;
            report2.Show();
            txt7.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt3.Text = string.Empty;
            txt5.Text = string.Empty;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            dateTimePicker1.Text = string.Empty;
            txt7.Text = string.Empty;
        }
    }
}
