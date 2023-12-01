using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_minor_young_old
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
            
            if (age < 18)
            {
                label2.Text = "Minor";
            }
            else if(age < 30)
            {
                label2.Text = "young";
            }
            else
            {
                label2.Text = "old";
            }
        }
    }
}
