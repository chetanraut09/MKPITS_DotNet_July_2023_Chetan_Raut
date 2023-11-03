using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fees_of_10student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student []stud = new Student[10];
        int cnt = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new Student();
            stud[1] = new Student();
            stud[2] = new Student();
            stud[3] = new Student();
            stud[4] = new Student();
            stud[5] = new Student();
            stud[6] = new Student();
            stud[7] = new Student();
            stud[8] = new Student();
            stud[9] = new Student();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<10)
            {
                stud[cnt].Rollno = Convert.ToInt32(textBox1.Text);
                stud[cnt].Name = textBox2.Text;
                stud[cnt].Fees = Convert.ToDouble(textBox3.Text);
                stud[cnt].Date = textBox4.Text;
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                if(cnt==10)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled = true;

                    MessageBox.Show("details of 10 student accepted");


                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("student details are: " + "\n");
            for(int i=0; i<10;i++)
            {
                sb.Append("----------------------------------------\n");
                sb.Append("Roll no: " + stud[i].Rollno + "\n");
                sb.Append("student name : " + stud[i].Name + "\n");
                sb.Append("student fees : " + stud[i].Fees + "\n");
                sb.Append("student fees : " + stud[i].Fees + "\n");
                sb.Append("----------------------------------------\n");

            }
            label5.Text = sb.ToString();

            double high = stud[0].Fees;
            int foundat = 0;
            for(int i=1; i<10;i++)
            {
                if (high< stud[i].Fees)
                    {
                        high = stud[i].Fees;
                        foundat = i;
                    }
                
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("student with highest fees : \n");
            sb1.Append("Roll no : " + stud[foundat].Rollno + "\n");
            sb1.Append("Student name : " + stud[foundat].Name + "\n");
            sb1.Append("student fees : " + stud[foundat].Fees + "\n");
            sb1.Append("student fees : " + stud[foundat].Fees + "\n");
            label6.Text = sb1.ToString();


        }
    }
}
