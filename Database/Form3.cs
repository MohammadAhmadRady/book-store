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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "INSERT INTO STUDENT VALUES ('"+textBox1.Text+ "','" +textBox2.Text+
                    "','" +dateTimePicker1.Value+ "','" +textBox3.Text+ "','" +comboBox1.Text+  "','" + textBox4.Text+
                    "','" +textBox5.Text+ "')";
                comm.ExecuteNonQuery();
                conn.Close();
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("        Student is added       ");
                Form1 Form1Obj = new Form1();
                Form1Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("     Please, Enter all Data     ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //Form1 s = new Form1();
           // s.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
            // The control will allow no more than 22 characters.
            textBox5.MaxLength = 22;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
}
