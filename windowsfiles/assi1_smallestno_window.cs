using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assi1_smallestno_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            StringBuilder sb = new StringBuilder();
            if (n1 < n2)
            {
                sb.Append("number 1 is smallest no");

            }
            else if (n1 == n2)
            {
                sb.Append("number 1 is equal to number 2");
            }
            else
            {
                sb.Append("number 2 is smallest no");
            }
            label3.Text = sb.ToString();

        }
    }
}
