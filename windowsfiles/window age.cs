﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age, eligibility;

            age = Convert.ToInt32(textBox1.Text);
            if (age > 18)
            { 
            label2.Text = "eligible for vote";
            }
            else
            {
                label2.Text= "not elgible for vote";
            }
           
        }
    }
}
