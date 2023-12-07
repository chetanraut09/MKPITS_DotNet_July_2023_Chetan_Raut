using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            int flag = 0;
            if(radioButton3.Checked)
            {
                flag++;
            }
           else
            {

            }
            if(radioButton6.Checked)
            {
                flag++;
            }
            else
            {

            }
            if(radioButton12.Checked)
            {
                flag++;
            }
            else
            {

            }
            sb.Append("Total marks is: " + flag);
            label4.Text= sb.ToString();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
