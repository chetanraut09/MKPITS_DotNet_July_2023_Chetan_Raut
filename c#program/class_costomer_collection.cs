using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_costomer_collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, employee> emp = new Dictionary<int, employee>();
        private void button1_Click(object sender, EventArgs e)
        {
            employee emp1 = new employee(Convert.ToInt32(textBox1.Text), textBox2.Text);
            employee emp2 = new employee(Convert.ToInt32(textBox3.Text), textBox4.Text);
            emp.Add(emp1.empno, emp1);
            emp.Add(emp2.empno, emp2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, employee> kv in emp)
            {
                sb.Append("emp id " + kv.Key + " emp name " + kv.Value.empname + "\n");
            }
            label5.Text = sb.ToString();

        }
    }
}
