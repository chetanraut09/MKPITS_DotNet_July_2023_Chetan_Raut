﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_details_windowform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp = new Employee[3];
            int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                emp[cnt].Empname = textBox1.Text;
                emp[cnt].Empno = Convert.ToInt32(textBox2.Text);
                emp[cnt].Salary = Convert.ToDouble(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if (cnt == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("details of three employees accepted");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("employee details are: " + "\n");
            for(int i=0;i<3;i++)
            {
                sb.Append("-------------------------\n");
                sb.Append("employee name:" + emp[i].Empname + "\n");
                sb.Append("employee no: " + emp[i].Empno + "\n");
                sb.Append("employee salary : " + emp[i].Salary + "\n");
                sb.Append("-----------------------------------------\n");

            }
            label4.Text = sb.ToString();
            //code to find highest salary
            double high = emp[0].Salary;
            int foundat = 0;
           for(int i=0;i<3; i++)
            {
                if (high < emp[i].Salary)
                {
                    high = emp[i].Salary;
                    foundat = i;
                  
                }
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("employee with heigheest salary: \n");
            sb1.Append("employee number: " + emp[foundat].Empno + "\n");
            sb1.Append("employee name : " + emp[foundat].Empname + "\n");
            sb1.Append("employee salary : " + emp[foundat].Salary + "\n");
            label5.Text = sb1.ToString();

        }
    }
}
