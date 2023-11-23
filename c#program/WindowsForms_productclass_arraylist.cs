using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_productclass_arraylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            product p=new product(Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text));
            ar.Add(p);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (product p in ar)
            {
                sb.Append("id :" +p.id + " name: " + p.name +"rate :"+p.rate+"\n");
            }
            label4.Text = sb.ToString();

        }
    }
}
