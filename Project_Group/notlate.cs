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
    public partial class notlate : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
        public notlate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notlate_Load(object sender, EventArgs e)
        {
            string data = "select statusatt.emp_ID, employee.emp_name, statusatt.status_Emp, statusatt.time_in from statusatt inner join employee on statusatt.emp_ID = employee.emp_ID where status_Emp = 'Ontime'";
            SqlCommand cmd = new SqlCommand(data, sql);
            var da = new DataTable("statusatt");
            var test = new SqlDataAdapter(cmd);
            test.Fill(da);
            dataGridView1.DataSource = da;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
