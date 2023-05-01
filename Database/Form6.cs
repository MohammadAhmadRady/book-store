using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Database
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "INSERT INTO LOAN VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + textBox3.Text + "')";
                comm.ExecuteNonQuery();
                conn.Close();
                textBox1.Text = ""; textBox2.Text = "";

                MessageBox.Show("            Loan is Done          ");
                //Form1 Form1Obj = new Form1();
                //Form1Obj.Show();
                //this.Hide();
            }
            else
                MessageBox.Show(" Enter BookID and StudentID ");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
}
