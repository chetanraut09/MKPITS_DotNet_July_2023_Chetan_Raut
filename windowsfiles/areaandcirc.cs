using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_areaandcircumference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int radius = Convert.ToInt32(textBox1.Text);
            float area = 3.14f * radius * radius;
            label2.Text = "result" + area;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int radius = Convert.ToInt32(textBox1.Text);
            float circ = 2 * 3.14f * radius;
            label2.Text = "result:" + circ;
        }
    }
}
