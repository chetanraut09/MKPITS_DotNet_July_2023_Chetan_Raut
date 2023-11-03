using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booklibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Library[] book = new Library[3];
        int cnt = 0;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            book[0] = new Library();
            book[1] = new Library();
            book[2] = new Library();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                book[cnt].Title = textBox1.Text;
                book[cnt].Author = textBox2.Text;
                if(cnt<3)
                {
                    book[cnt].Isavailable = true;
                }
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                if(cnt==3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;

                    button2.Enabled = true;
                    MessageBox.Show("details of 3 books accepted");
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Available books are : " + "\n");
            for (int i = 0; i < 3; i++)
            {
                if (book[i].Isavailable == true)
                {
                    sb.Append("----------------------------------------\n");
                    sb.Append("title: " + book[i].Title + "\n");
                    sb.Append("author : " + book[i].Author + "\n");

                    sb.Append("----------------------------------------\n");
                }
            }

            label4.Text = sb.ToString();



        }
    }
}
