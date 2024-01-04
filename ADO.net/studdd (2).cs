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

namespace studdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            studddclass s = new studddclass();
            string g = null;
            if (radioButton1.Checked)
            {
                g = "male";

            }
            if (radioButton2.Checked)
            {
                g = "femail";
            }

            string h = null;
            if (checkBox1.Checked)
            {
                h = "music";

            }
            if (checkBox2.Checked)
            {
                if (h != null)
                {
                    h = h + " " + "reading";
                }
                else
                {
                    h = "reading";
                }
            }
            string result = s.InserStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            studddclass s = new studddclass();
            string g = null;
            if (radioButton1.Checked)
            {
                g = "male";

            }
            if (radioButton2.Checked)
            {
                g = "femail";
            }

            string h = null;
            if (checkBox1.Checked)
            {
                h = "music";

            }
            if (checkBox2.Checked)
            {
                if (h != null)
                {
                    h = h + " " + "reading";
                }
                else
                {
                    h = "reading";
                }
            }
            string result = s.UpdateStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            studddclass s = new studddclass();
            string g = null;
            if (radioButton1.Checked)
            {
                g = "male";

            }
            if (radioButton2.Checked)
            {
                g = "femail";
            }

            string h = null;
            if (checkBox1.Checked)
            {
                h = "music";

            }
            if (checkBox2.Checked)
            {
                if (h != null)
                {
                    h = h + " " + "reading";
                }
                else
                {
                    h = "reading";
                }
            }
            string result = s.DeleteStudent(Convert.ToInt32(textBox1.Text), textBox2.Text);
            label7.Text = result;
            cleartext();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            List<student> li = new List<student>();

            studddclass stud = new studddclass();

            //RollNo
            li = stud.searchstudent(Convert.ToInt32(textBox1.Text));

            //StudentName
            textBox2.Text = li[0].name;

            //Gender
            string Gender = li[0].gender;

            if (Gender == "Male")
            {
                radioButton1.Checked = true;

            }
            if (Gender == "Female")
            {
                radioButton2.Checked = true;
            }

            //hobby
            string Hobby = li[0].hobby;

            if (Hobby == "Reading" && Hobby == "Music")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }
            if (Hobby == "Reading")
            {
                checkBox1.Checked = true;
            }
            if (Hobby == "Music")
            {
                checkBox2.Checked = true;
            }

            //City
            comboBox1.Text = li[0].city;

            //DOB
            dateTimePicker1.Text = li[0].dob;
        }

    }
}
