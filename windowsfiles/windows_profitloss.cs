using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_profitloss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(textBox1.Text);
            int sell = Convert.ToInt32(textBox2.Text);
            int profit, loss;
            if (cost < sell)
            {
                profit = sell - cost;
                label3.Text = "your profit is=" + profit;
            }
            else
            {

                loss = cost - sell;
                label3.Text = "your loss = " + loss;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
