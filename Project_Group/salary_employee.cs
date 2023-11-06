using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Group
{
    public partial class salary_employee : Form
    {
        string salarys;
        SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
        public salary_employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salary_employee_Load(object sender, EventArgs e)
        {
            string datas = "select employee.emp_ID, employee.emp_Name, salary.emp_role, salary.many_salary from employee inner join salary on employee.emp_role = salary.emp_role where employee.emp_role = 'staff'";
            SqlCommand cm = new SqlCommand(datas, sql);
            var da = new DataTable("employee");
            var test = new SqlDataAdapter(cm);
            test.Fill(da);
            dataGridView1.DataSource = da;
            
            string data = "select employee.emp_ID, employee.emp_Name, salary.emp_role, salary.many_salary from employee inner join salary on employee.emp_role = salary.emp_role where employee.emp_role = 'manager'";
            SqlCommand cd = new SqlCommand(data, sql);
            var d = new DataTable("employee");
            var t = new SqlDataAdapter(cd);
            t.Fill(d);
            dataGridView2.DataSource = d;

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                salarys = "staff";
            }
            else if (radioButton2.Checked == true)
            {
                salarys = "manager";
            }
            printsalary printsa = new printsalary();
            salary1 salary = new salary1();
            salary.SetParameterValue("salary", salarys);
            printsa.crystalReportViewer1.ReportSource = salary;
            printsa.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

