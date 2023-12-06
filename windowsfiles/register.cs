using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_form
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append( "username:" + textBox1.Text+ "\n");
            sb.Append("enter mob no:" + textBox2.Text + "\n");
            sb.Append ("Enter class:" + textBox3.Text + "\n");
           
            string gender = null;
            if (radioButton1.Checked)
                gender = radioButton1.Text;
            else if (radioButton2.Checked)
                gender = radioButton2.Text;

            sb.Append("gender " + gender + "\n");
            sb.Append("emailid:" + textBox5.Text + "\n");
            string course = null;
            if (checkBox1.Checked)
                course = checkBox1.Text;
            if (checkBox2.Checked)
                course = course + " " + checkBox2.Text;

            sb.Append("course  " + course + "\n");
            sb.Append("Country " + comboBox1.Text + "\n");
            sb.Append("city" + comboBox2.Text + "\n");


            label10.Text = sb.ToString();
            label4.Text = numericUpDown1.Value.ToString();
            if (textBox1.Text == "Chetan" && textBox5.Text == "rautchetan866@gmail.com")
            {
                MessageBox.Show("login successfullllllllll");
                
                
            }
            else
            {
                MessageBox.Show("invalid incredentials");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";

            switch(comboBox1.Text)
            {
                case "india":
                    comboBox2.Items.Add("nagpur");
                    comboBox2.Items.Add("mumbai");
                    break;
                case "usa":
                    comboBox2.Items.Add("la");
                    comboBox2.Items.Add("california");
                    break;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }
    }
}
