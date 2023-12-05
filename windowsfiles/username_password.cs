﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace username_password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append ("username:" + textBox1.Text + "\n");
            sb.Append("password:" + textBox2.Text + "\n");
            string gender = null;
            if (radioButton1.Checked)
            {
                gender= radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender= radioButton2.Text;
            }
            sb.Append("Gender : " + gender + "\n");
            
            if(checkBox1.Checked)
            {
                sb.Append("course : " + checkBox1.Text + "\n");
            }
            if(checkBox2.Checked)
            {
                sb.Append("Course : " + checkBox2.Text + "\n");
            }
            sb.Append("country:" +comboBox1.Text + "\n");
            sb.Append("city :" +comboBox2.Text +"\n");
            
            label7.Text=sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch(comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add ("mumbai");
                    comboBox2.Items.Add ("pune");
                    comboBox2.Items.Add ("nagpur");
                    break;
                case "America":
                    comboBox2.Items.Add("la");
                    comboBox2.Items.Add("pkmc");
                    break;
            }
        }
    }
}
