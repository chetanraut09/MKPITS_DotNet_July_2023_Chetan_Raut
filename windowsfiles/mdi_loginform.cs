using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrationform r = new registrationform();
                r.MdiParent = this;
            r.Show();
        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addmisionform a= new addmisionform();
            a.MdiParent = this;
            a.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrationform r = new registrationform();
            r.MdiParent = this;
            r.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account a= new account();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            account a= new account();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            register r=new register();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            register r= new register();
            r.MdiParent = this;
            r.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.MdiParent = this;
            r.Show();
            if (textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                MessageBox.Show("login successfullllllllll");
               fileToolStripMenuItem.Enabled = true;
                toolStripButton1.Enabled = true;
                toolStripButton2.Enabled = true;
                panel1.Hide();
            }
            else
            {
                MessageBox.Show("invalid incredentials");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
