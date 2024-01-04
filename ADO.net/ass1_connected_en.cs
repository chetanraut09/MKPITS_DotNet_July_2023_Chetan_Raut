using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass1_connected_en
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=TNL21885300-B\\SQLEXPRESS;integrated security=true;database=prodd";
        SqlConnection con = null;
        SqlCommand command = null;

        private void button1_Click(object sender, EventArgs e)
        {
            productclass p = new productclass();
            string result = p.InsertProduct(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text));

            label5.Text = result;
            cleartext();
        }
        public void cleartext()
        {
            textBox1.Clear();
            textBox2 .Clear();
            textBox3 .Clear();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productclass p = new productclass();
            string result = p.UpdateProduct(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text));

            label5.Text = result;
            cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            productclass p = new productclass();
            string result = p.DeleteProduct(Convert.ToInt32(textBox1.Text));

            label5.Text = result;
            cleartext();
        }
    }
}
