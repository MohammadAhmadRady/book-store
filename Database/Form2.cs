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
   
    public partial class Form2 : Form
    {
        public static int AdminId , flag;
        public Form2(int id,int f = 0)
        {
            InitializeComponent();
            AdminId = id;
            textBox1.Text = id.ToString();
            if (f == 1) {
                button1.Text = "Update User Details !";
                flag = f; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text != "" && textBox5.Text != "" && textBox4.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {   
                SqlConnection conn = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                if (flag != 1)
                {
                    comm.CommandText = "INSERT INTO ADMIN VALUES ('" + textBox1.Text + "','" + textBox4.Text +
                        "','" + dateTimePicker1.Value + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')";
                }
                else
                { 
                    comm.CommandText = "UPDATE Admin set NAME = '"+textBox4.Text + "' , DOB = '" + dateTimePicker1.Value + "', ADDREss = '" + textBox2.Text + "' , SHIFT = '" + comboBox1.Text + "' , PASSWORD = '" + textBox5.Text + "' where A_ID = '"+ Form2.AdminId +"'";
                   
                    
                }
                comm.ExecuteNonQuery();
                conn.Close();

                textBox1.Text = ""; textBox2.Text = "";
                textBox4.Text = ""; textBox5.Text = ""; 
                MessageBox.Show("        Admin is added       ");
                Form1 Form1Obj = new Form1();
                Form1Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("     Please, Enter all Data  ");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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
