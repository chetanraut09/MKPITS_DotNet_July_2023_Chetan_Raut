using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3submarks
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
            int maths = Convert.ToInt32(textBox1.Text);
            int physics = Convert.ToInt32(textBox2.Text);
            int chemistry = Convert.ToInt32(textBox3.Text);

            int total = maths + physics + chemistry;
            label4.Text = "total:" + total;
            float per = (total / 300.0f) * 100.0f;
            label5.Text = "percentage:" + per;

            if (per > 75)
            {
                label6.Text = "distinction";
            }
            else if(per>60 && per<75)
            {
                label6.Text = "first class";
            }
            else
            {
                label6.Text = "second class";

            }
            
        }
    }
}
