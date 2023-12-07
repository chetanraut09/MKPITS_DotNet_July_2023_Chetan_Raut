using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pannnel_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if(radioButton1.Checked)
            {
               sb.Append(radioButton1.Text+"\n");
            }
            else
            {

            }
            if(radioButton2.Checked)
            {
                sb.Append(radioButton2.Text);

            }
            else
            {

            }
             if(radioButton3.Checked)
            {
                sb.Append(radioButton3.Text);

            }
             else
            {

            }
             if (radioButton4.Checked)
            {
                sb.Append(radioButton4.Text);
            }
            else
            {

            }

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                sb.Append("joind course: " + checkedListBox1.CheckedItems[i] + "\n");
            }

             label1.Text = sb.ToString();
        }
    }
}
