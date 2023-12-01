using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_vote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age=Convert.ToInt32(textBox1.Text);
            StringBuilder sb = new StringBuilder();
            if (age > 18)
            {
                sb.Append("eligible for vote");
            }
            else
            {
                sb.Append("not eligible for vote");

            }
            label2.Text = sb.ToString();
        }
    }
}
