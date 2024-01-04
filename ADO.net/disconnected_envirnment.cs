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

namespace disconnected_envirnment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con= new SqlConnection("server=TNL21885300-B\\SQLEXPRESS;integrated security=true;database=disconnected_ad0");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;

        private void button1_Click(object sender, EventArgs e)
        {
            da= new SqlDataAdapter( "select * from studddd", con);
            cb= new SqlCommandBuilder(da);
            //use the fill method of sqldataadapter to load data into dataset
            da.Fill(ds, "stud");
            dataGridView1.DataSource = ds.Tables["stud"];


        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                da.Update(ds.Tables["stud"]);
                MessageBox.Show("Record updated");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
    }
}
