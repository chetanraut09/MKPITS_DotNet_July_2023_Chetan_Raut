using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dayname
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dayno = Convert.ToInt32(textBox1.Text);
            string res;
            switch(dayno)
            {
                case 1:
                    res = "Monday";
                    break;
                case 2:
                    res = "tuesday";
                    break;

                    case 3:
                    res = "Wednusday";
                    break;
                case 4:
                    res = "thusday";
                    break;
                case 5:
                    res = "friday";
                    break;
                case 6:
                    res = "saturday";
                    break;
                case 7:
                    res = "sunday";
                    break;
                default:
                    res = "invalid day";
                    break;


            }
            label2.Text = "res:" + res;
        }
    }
}
