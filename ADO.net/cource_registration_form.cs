using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cource_registration_form
{
    public partial class Form1 : Form
    {
        string strcon = "server = TNL21885300-B\\SQLEXPRESS; integrated security = true; database = cource_registration_form";

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tablenation order by nation_id ", con);
                ds = new DataSet();
                da.Fill(ds, "tablenation");
                comboBox1.DataSource = ds.Tables["tablenation"];
                comboBox1.DisplayMember = "nation_name";
                comboBox1.ValueMember = "nation_id";

            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                //   MessageBox.Show("nation id " + comboBox1.SelectedValue.ToString());
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablestate  where nation_id=@nation_id", con);
                    da.SelectCommand.Parameters.AddWithValue("@nation_id", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablestate");
                    comboBox2.DataSource = ds.Tables["tablestate"];
                    comboBox2.DisplayMember = "state_name";
                    comboBox2.ValueMember = "state_id";

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                //   MessageBox.Show("nation id " + comboBox1.SelectedValue.ToString());
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablecity  where state_id=@state_id", con);
                    da.SelectCommand.Parameters.AddWithValue("@state_id", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablecity");
                    comboBox3.DataSource = ds.Tables["tablecity"];
                    comboBox3.DisplayMember = "city_name";
                    comboBox3.ValueMember = "city_id";

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

        }

        enum category { Student , IT_proffetional}
        enum Gender { Male , Female , Other}
        category cat;
        Gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                MessageBox.Show("fullname cant be empty");
            }
            else
            {
                if(radioButton1.Checked)
                {
                    cat = category.Student;
                }
                else if (radioButton2.Checked)
                {
                    cat = category.IT_proffetional;
                }
                MessageBox.Show("category:" + cat);

                if(radioButton3.Checked)
                {
                    gen=Gender.Male;
                }
                else if ( radioButton4.Checked)
                {
                    gen=Gender.Female;

                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cat = category.IT_proffetional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
                // calculatefees();
            }
            
        }

        public void CalculateFess()
        {
          
        }



private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalculateFess();
        }
    }
}
