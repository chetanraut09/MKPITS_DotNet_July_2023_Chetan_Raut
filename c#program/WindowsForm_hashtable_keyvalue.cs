using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_hashtable_keyvalue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ht=new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            ht.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection key=ht.Keys;
            foreach (string str in key)
            {
                sb.Append("album name"+str+"\n");

            }
            label3.Text = sb.ToString();
            ICollection val = ht.Values;
           
            foreach (string str in val)
            {
                sb.Append("singer " + str + "\n");
            }
            label4.Text = sb.ToString();

        }
    }
}
