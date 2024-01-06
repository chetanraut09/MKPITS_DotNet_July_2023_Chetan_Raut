using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace crud_operation
{
    public partial class Form1 : Form
    {

        string ConnectioString = "server =TNL21885300-B\\SQLEXPRESS; integrated security = true; database = crud_operation;";
        SqlDataAdapter sqlda;
        DataSet dataset = new DataSet();
        SqlCommandBuilder cb;

        public Form1()
        {
            InitializeComponent();
            sqlda = new SqlDataAdapter("select * from employi ", ConnectioString);
            dataset = new DataSet();
            cb = new SqlCommandBuilder(sqlda);
            sqlda.Fill(dataset, "Emp1");
        }


        //select
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataset.Tables["Emp1"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlda = new SqlDataAdapter("select * from employi ", ConnectioString);
            dataset = new DataSet();
            cb = new SqlCommandBuilder(sqlda);
            sqlda.Fill(dataset, "Emp1");

            try
            {
                //steps to insert record in disconnected env
                //create a new row using datarow object
                DataRow dr = dataset.Tables["Emp1"].NewRow();
                //add values to newly created datarow
                dr[0] = Convert.ToInt32(textBox1.Text);
                dr[1] = textBox2.Text;
                dr[2] = textBox3.Text;
                dr[3] = Convert.ToInt16(textBox4.Text);
                dr[4] = textBox5.Text;
                dr[5] = Convert.ToInt32(textBox6.Text);
                dr[6] = Convert.ToInt64(textBox7.Text);

                //add the newly created row to datatable
                dataset.Tables["Emp1"].Rows.Add(dr);
                //using update  add the new row to sqlserver database table
                sqlda.Update(dataset.Tables["Emp1"]);
                MessageBox.Show("Data Successfully Inserted..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (DataRow dr in dataset.Tables["Emp1"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt16(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        sqlda.Update(dataset.Tables["Emp1"]);
                        MessageBox.Show("Data Successfully Updated..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
            MessageBox.Show("Employee not Exist...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int intCounter = 0;
            DataRow drTarget;
            foreach (DataRow dr in dataset.Tables["Emp1"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        //dataSet.Tables["Emp"].Rows.Remove(dr);
                        //dr.Delete();
                        //Sqlda.Update(dataSet.Tables["Emp"]);
                        dr.Delete();
                        // No need to call Rows.Remove(dr) if you are using dr.Delete()

                        sqlda.Update(dataset.Tables["Emp1"]);
                        dataset.Tables["Emp1"].AcceptChanges();
                        MessageBox.Show("Data Successfully Deleted..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();

        }
    }
}

        

            
    




