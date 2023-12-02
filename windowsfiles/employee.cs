using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ename= textBox1.Text;
            int bsalary=Convert.ToInt32(textBox2.Text);
            string designation= textBox3.Text;

            float hra = 0;
            float bonus= 0;
            float totalsalary = 0;

            switch(designation)
            {
                case "manager":
                    hra = bsalary * 0.35f;
                    bonus = bsalary * 0.5f;
                    break;

                case "clerk":
                    hra = bsalary * 0.25f;
                    bonus = bsalary * 0.3f;
                    break;

                case "peon":
                    hra = bsalary * 0.15f;
                    bonus = bsalary * 0.2f;
                    break;
            }
            label4.Text = "hra:" + hra;
            label5.Text = "bonus:" + bonus;
            totalsalary = hra + bonus + bsalary;
            label6.Text = "totalsalary:" + totalsalary;
        }
    }
}
