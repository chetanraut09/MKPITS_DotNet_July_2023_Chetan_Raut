using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assi2_greatestnoin3no
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(textBox1.Text);
            int n2=Convert.ToInt32(textBox2.Text);
            int n3=Convert.ToInt32(textBox3.Text);

            StringBuilder sb = new StringBuilder();

            if (n1 > n2 && n1>n3)
            {
                sb.Append("n1 is greatest no");

            }
            else if (n2>n3 && n2>n1)
            {
                sb.Append("n2 is greatest no");
            }
            else
            {
                sb.Append("n3 is greatest no");
            }
            label4.Text = sb.ToString();
        }
    }
}
