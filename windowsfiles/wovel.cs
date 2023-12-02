using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wovel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Char ch = Convert.ToChar(textBox1.Text);
            string res;

            switch (ch)
            {
                case 'a':
                    res = "Vowel";
                    break;
                case 'e':
                    res = "Vowel";
                    break;
                case 'i':
                    res = "Vowel";
                    break;
                case 'o':
                    res = "Vowel";
                    break;
                case 'u':
                    res = "Vowel";
                    break;

                default:
                    res = "Consolen";
                        break;


            }
            label2.Text = res;
        }
    }
}
