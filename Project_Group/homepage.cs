using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Group
{
    public partial class homepage : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
        public homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void informationEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report report = new report();
            report.MdiParent= this;
            report.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_update_delete crud = new create_update_delete();
            crud.MdiParent = this;
            crud.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
                  
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Thank you to use this program, See You ;) ");
            Close();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salary_employee salary = new salary_employee();
            salary.MdiParent = this;
            salary.Show();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attandanceall attandanceall = new attandanceall();
            attandanceall.MdiParent = this;
            attandanceall.Show();

        }

        private void lateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void permissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            permission permission = new permission();
            permission.MdiParent = this;
            permission.Show();
        }

        private void notLateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notlate notlate = new notlate();
            notlate.MdiParent = this;
            notlate.Show();
        }

        private void lateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            late late = new late();
            late.MdiParent = this;
            late.Show();
        }

        private void takingLoansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addloan addloan = new addloan();
            addloan.MdiParent = this;
            addloan.Show();
        }

        private void paidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loans cr4 = new loans();
            ploans loan = new ploans();
            cr4.crystalReportViewer1.ReportSource = loan;
            cr4.MdiParent = this;
            cr4.Show();
        }

        private void paymentLoansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paymentloans pm = new paymentloans();
            pm.MdiParent = this;
            pm.Show();

        }

        private void printFileEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
            sql.Open();
            string data = "select emp_ID, emp_Name, emp_phone, emp_gender,FORMAT(dob, 'MM-dd-yyyy') as 'Date of Birth', emp_role from employee";
            SqlCommand cmd = new SqlCommand(data,sql);
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            try
            {
                
                SaveFileDialog files = new SaveFileDialog();
                files.Filter = "Text Files|*.txt";
                files.Title = "Save Files";
                if (files.ShowDialog() == DialogResult.OK)
                {
                    string path = files.FileName;
                    using (StreamWriter tulis = new StreamWriter(path))
                    {
                        foreach(DataColumn col in dt.Columns)
                        {
                            tulis.Write(col.ColumnName.PadRight(16));
                            tulis.Write('\t');
                        }
                        tulis.WriteLine();
                        foreach (DataRow dr in dt.Rows)
                        {
                            foreach (var item in dr.ItemArray)
                            {
                                tulis.Write(item.ToString().PadRight(16));
                                tulis.Write("\t");
                            }
                            tulis.WriteLine();
                        }
                    }
                    MessageBox.Show("Your data has successfully print into File");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                sql.Close();
            }
        }

        private void printToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
            sql.Open();
            string data = "select employee.emp_ID, employee.emp_Name, salary.emp_role, salary.many_salary from employee inner join salary on employee.emp_role = salary.emp_role";
            SqlCommand cmd = new SqlCommand(data, sql);
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            try
            {
                SaveFileDialog files = new SaveFileDialog();
                files.Filter = "Text Files|*.txt";
                files.Title = "Save Files";
                if (files.ShowDialog() == DialogResult.OK)
                {
                    string path = files.FileName;
                    using (StreamWriter tulis = new StreamWriter(path))
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            tulis.Write(col.ColumnName.PadRight(16));
                            tulis.Write('\t');
                        }
                        tulis.WriteLine();
                        foreach (DataRow dr in dt.Rows)
                        {
                            foreach (var item in dr.ItemArray)
                            {
                                tulis.Write(item.ToString().PadRight(16));
                                tulis.Write("\t");
                            }
                            tulis.WriteLine();
                        }
                    }
                    MessageBox.Show("Your data has successfully print into File");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sql.Close();
            }
        }

        private void printFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sql.Open();
            string data = "select * from loans";
            SqlCommand cmd = new SqlCommand(data, sql);
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            try
            {

                SaveFileDialog files = new SaveFileDialog();
                files.Filter = "Text Files|*.txt";
                files.Title = "Save Files";
                if (files.ShowDialog() == DialogResult.OK)
                {
                    string path = files.FileName;
                    using (StreamWriter tulis = new StreamWriter(path))
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            tulis.Write(col.ColumnName.PadRight(16));
                            tulis.Write('\t');
                        }
                        tulis.WriteLine();
                        foreach (DataRow dr in dt.Rows)
                        {
                            foreach (var item in dr.ItemArray)
                            {
                                tulis.Write(item.ToString().PadRight(16));
                                tulis.Write("\t");
                            }
                            tulis.WriteLine();
                        }
                    }
                    MessageBox.Show("Your data has successfully print into File");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sql.Close();
            }
        }
    }
}
