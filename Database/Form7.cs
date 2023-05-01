using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using System.Data.SqlClient;
using System.Data.Common;

namespace Database
{
    public partial class Form7 : Form
    {
        public static int StudentID , flag ;

        public Form7(int ID,int f = 0)
        {
            InitializeComponent();
             Form7.StudentID = ID;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            conn.Open();
            comm.CommandText = "SELECT NAME FROM STUDENT WHERE S_ID = " + Form7.StudentID.ToString();
            string s_name = Convert.ToString(comm.ExecuteScalar());

            label6.Text = "Welcome , " + s_name;

            button3_Click(sender, e);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ex = true;
            string yourConnectionString = "Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True";
            string select = "SELECT * FROM BOOK WHERE ";
            
            if (textBox1.Text != "")   
            {
                select += "B_ID = '" + textBox1.Text + "' ";
                if (textBox2.Text != "") { select += " and TITLE like '%" + textBox2.Text + "%'"; }
                if (textBox3.Text != "") { select += " and AUTHOR_NAME like '%" + textBox3.Text + "%' "; }
                if (textBox4.Text != "") { select += " and CATEGORY like '%" + textBox4.Text + "%'"; }
                if (textBox5.Text != "") { select += " and PUB_YEAR = '" + textBox5.Text + "'"; }

            }
            else if (textBox2.Text != "")  
            {
                select += "  TITLE like '%" + textBox2.Text + "%' ";
                if (textBox3.Text != "") { select += " and AUTHOR_NAME like '%" + textBox3.Text + "%' "; }
                if (textBox4.Text != "") { select += " and CATEGORY like '%" + textBox4.Text + "%'  "; }
                if (textBox5.Text != "") { select += " and PUB_YEAR = '" + textBox5.Text + "'"; }
            }

            else if (textBox3.Text != "")  
            {
                select += " AUTHOR_NAME like '%" + textBox3.Text + "%'  ";
                if (textBox4.Text != "") { select += " and CATEGORY like '%" + textBox4.Text + "%'  "; }
                if (textBox5.Text != "") { select += " and PUB_YEAR = '" + textBox5.Text + "'"; }
            }
            else if (textBox4.Text != "")
            {
                select += " CATEGORY like '%" + textBox4.Text + "%'  ";
                if (textBox5.Text != "") { select += " and PUB_YEAR = '" + textBox5.Text + "'"; }
            }
            else if (textBox5.Text != "") { select += " PUB_YEAR = '" + textBox5.Text + "'"; }

            else
            {
                MessageBox.Show(" Please Enter At Least One Attribute! ");
                ex = false;

            }
            


            var c = new SqlConnection(yourConnectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            if (ex)
               {
                dataAdapter.Fill(ds);


                dataGridView1.ReadOnly = true;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables[0];
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            string yourConnectionString = "Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True";
            var select = "SELECT * FROM LOAN WHERE S_ID =" + Form7.StudentID;
            var c = new SqlConnection(yourConnectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["bIDDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.bOOKTableAdapter.Fill(this.uniLibraryDataSet.BOOK);

            string yourConnectionString = "Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True";
            var select = "SELECT B_id , TITLE , CATEGORY , AUTHOR_NAME , PUB_YEAR , PRICE  FROM BOOK WHERE AVAIL > 0 ";
            var c = new SqlConnection(yourConnectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(Convert.ToInt32(textBox1.Text));
            form.Show();
            /*
            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-02AJKRB\\SQLEXPRESS;Initial Catalog=UniLibrary;Integrated Security=True");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "";
                comm.ExecuteNonQuery();
                conn.Close();
               

                MessageBox.Show("THis Book Is Added to Your Loan List");
                //Form1 Form1Obj = new Form1();
                //Form1Obj.Show();
                //this.Hide();
            }
            */
        }

        private void label6_Click(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "delete from LOAN  where B_ID = '" + textBox1.Text + "' and S_ID = ' "+ Form7.StudentID+"' ";
                comm.ExecuteNonQuery();
                SqlCommand c = new SqlCommand("UPDATE BOOK SET avail = avail + 1 WHERE B_ID = '" + textBox1.Text+ "' ", conn);
                c.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("            Return is Complete !          ");
            }
            else
            {
                MessageBox.Show("            Enter B_ID Please for Deletion..          ");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "update LOAN set START_LOAN ='" + DateTime.Now + "',RETURN_DATE = '" +DateTime.Now.AddDays(14)+ "' where B_ID = '" + textBox1.Text + "' and S_ID = '"+ Form7.StudentID+ "' " ;
                comm.ExecuteNonQuery();
                MessageBox.Show("        Renew has been Complete !         ");
                conn.Close();

            }
            else
            {
                MessageBox.Show("            Enter the Book ID  Please for Renewing ..          ");

            }



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
