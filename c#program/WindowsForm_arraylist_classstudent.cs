﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_arraylist_classstudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
           student s=new student(Convert.ToInt32(textBox1.Text),textBox2.Text);
            ar.Add(s);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();
             foreach(student s in ar)
            {
                sb.Append("rno:"+s.rno+"name:"+s.name+"\n");
            }
             label3.Text = sb.ToString();
        }
    }
}
