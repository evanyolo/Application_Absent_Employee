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
using System.Threading;

namespace Project_Group
{
    public partial class Form1 : Form
    {
         SqlConnection con = new SqlConnection("Data Source=EvnyolsGF63\\SQLEXPRESS;Initial Catalog=UasVisprog;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (user.Text == string.Empty)
            {
                MessageBox.Show("Enter the username");
            }
            else if (pass.Text == string.Empty)
            {
                MessageBox.Show("Enter the password");
            }
        
            
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Admins where username = @username and passwords = @passwords", con);
                cmd.Parameters.AddWithValue("@username", user.Text);           
                cmd.Parameters.AddWithValue("@passwords", pass.Text);
                SqlDataAdapter dapt = new SqlDataAdapter(cmd);
                DataTable dts = new DataTable();
                dapt.Fill(dts);

                if(dts.Rows.Count > 0) {
                    MessageBox.Show("login Successfully");
                    homepage home = new homepage();

                    home.Show();
                }
           
            
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            user.Text = string.Empty;
            pass.Text = string.Empty;

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pass_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
