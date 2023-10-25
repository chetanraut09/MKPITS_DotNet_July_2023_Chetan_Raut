using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_electtricbill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            int unit = Convert.ToInt32(textBox3.Text);
            float total = Convert.ToSingle(textBox8.Text);
            if(unit<200)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
