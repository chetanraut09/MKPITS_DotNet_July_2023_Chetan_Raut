using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumof5no_arr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num= new int[5];
        int i= 0;
        int sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if(i<5)
            {
                num[i] = Convert.ToInt32(textBox1.Text);
                sum = sum + i;
                i++;
                textBox1.Clear();
                textBox1.Focus();

                if(i==5)
                {
                    label2.Text = "sum of 5 no:" + sum;

                }
                else
                {

                }
            }
        }
    }
}
