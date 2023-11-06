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
    public partial class attandanceall : Form
    {
        string absen;
        SqlConnection sql = new SqlConnection
           ("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
        public attandanceall()
        {
            InitializeComponent();
        }

        private void attandanceall_Load(object sender, EventArgs e)
        {
            string data = "select statusatt.emp_ID, employee.emp_name, statusatt.status_Emp, " +
                "statusatt.description, statusatt.time_in from statusatt " +
                "inner join employee on statusatt.emp_ID = employee.emp_ID";
            SqlCommand cmd = new SqlCommand(data, sql);
            var da = new DataTable("statusatt");
            var test = new SqlDataAdapter(cmd);
            test.Fill(da);
            dataGridView1.DataSource = da;


            SqlCommand cm = new SqlCommand("select distinct status_Emp from statusatt;", sql);
            SqlDataAdapter dats = new SqlDataAdapter(cm);
            dats.SelectCommand = cm;
            DataTable dt = new DataTable();
            dats.Fill(dt);
            comboBox1.DisplayMember= "status_Emp";
            comboBox1.ValueMember= "status_Emp";
            comboBox1.DataSource = dt;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            attendance cr3 = new attendance();
            cr3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if(comboBox1.SelectedIndex == 0)
            {
                absen = "Late";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                absen = "NotPresent";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                absen = "Ontime";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                absen = "Permission";
            }
            printattadancespesi print = new printattadancespesi();
            reportattandance report = new reportattandance();
            report.SetParameterValue("statusmasuk",absen);
            print.crystalReportViewer1.ReportSource = report;
            print.Show();
        }
    }
}
