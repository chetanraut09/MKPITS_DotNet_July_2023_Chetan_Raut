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

namespace login_form_mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = " server = TNL21885300-B\\SQLEXPRESS;integrated security=true;database=logintable";
        
      

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(str);

            try
            {
                con.Open();
                string qr = " select count(*) from userr where username=@username and passwords=@passwords";

                SqlCommand command = new SqlCommand(qr, con);
                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@passwords", textBox2.Text);


                int cnt = Convert.ToInt32(command.ExecuteScalar());

                if (cnt>0)
                {
                    MessageBox.Show("login successfully");
                    panel1.Visible = false;
                    menuStrip1.Visible = true;
                }
                else
                {
                    MessageBox.Show("invalid credentials , please try again ");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
