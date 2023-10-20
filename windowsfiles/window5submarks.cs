using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_5sub_marks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, c, p, b, i;
            int total;
            float per;
            string grade = null;
            m = Convert.ToInt32(textBox1.Text);
            c = Convert.ToInt32(textBox2.Text);
            p = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            i = Convert.ToInt32(textBox5.Text);
            total = m + c + p + b + i;
            per = (total / 500.0f) * 100.0f;
            label6.Text = "total:" + total;
            label7.Text = "percentage:" + per;
            if(per>90)
            {
                grade = "distinction";

            }
            else if(per>80 && per<90)
            {
                grade = "first class";
            }
            else if(per>60 && per<80)
            {
                grade = "second class";
            }
            else
            {
                grade = "failed";
            }
            label8.Text = "grade:" + grade;
        }
    }
}
