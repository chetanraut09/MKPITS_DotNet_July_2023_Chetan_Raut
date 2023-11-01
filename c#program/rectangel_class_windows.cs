using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rectangle_windowsform
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        internal class Rectangle
        {
            public int width { get; set; }
            public int height { get; set; }
            public int area = 0;

            public void getdata(int width, int height)
            {
                this.width = width;
                this.height = height;

                area = width * height;
            }
        }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                Rectangle rect = new Rectangle();
                int width = Convert.ToInt32(textBox1.Text);
                int height = Convert.ToInt32(textBox2.Text);

                rect.getdata(width, height);
                StringBuilder sb = new StringBuilder();
                sb.Append("Area of Rectangle = " + rect.area);
                label3.Text = sb.ToString();
            }
        }
    }

