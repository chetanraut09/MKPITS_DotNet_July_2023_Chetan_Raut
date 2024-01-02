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

namespace userss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server = TNL21885300-B\\SQLEXPRESS; integrated security = true; database = userss";
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                MessageBox.Show("Connection Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string constr = "server=TNL21885300-B\\SQLEXPRESS\\sqlexpress;integrated security=true;database=userss";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "insert into users values('" + textBox1.Text + "','" + textBox2.Text + "')";

                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record inserted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "server=TNL21885300-B\\SQLEXPRESS\\sqlexpress;integrated security=true;database=userss";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "update users set password='" + textBox2.Text + "' where username='" + textBox1.Text + "'";

                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record updated successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = "server=TNL21885300-B\\SQLEXPRESS\\sqlexpress;integrated security=true;database=userss";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "delete from  users where username='" + textBox1.Text + "' or password ='" + textBox2.Text + "'";

                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record deleted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }


    }
}



