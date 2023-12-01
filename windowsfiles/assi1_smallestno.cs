using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace greaterno_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            StringBuilder sb = new StringBuilder();
            if (n1 < n2)
            {
                sb.Append("number 1 is smaller than number 2");

            }
            else if (n1 == n2)
            {
                sb.Append("number 1 is equal to number 2");
            }
            else
            {
                sb.Append("number 2 is less than number 1");
            }
            label3.Text = sb.ToString();

        }
    }
}

