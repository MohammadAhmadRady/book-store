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
    public partial class AdminPanel : Form
    {
        public static int AdminID;
        public AdminPanel(int Id)

        {
            InitializeComponent();
            AdminID = Id;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //Form1 ss = new Form1();
            //ss.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "INSERT INTO BOOK VALUES ('" + textBox1.Text + "','" + textBox6.Text +
                    "','" + textBox5.Text + "','" + textBox4.Text + "',1,'" + textBox3.Text + "','" + textBox2.Text +
                    "','" + textBox7.Text + "')";
                comm.ExecuteNonQuery();
                conn.Close();
                textBox1.Text = "";textBox2.Text = "";textBox3.Text = "";
                textBox4.Text = "";textBox5.Text = "";
                textBox6.Text = "";textBox7.Text = "";
                MessageBox.Show("            Insertion is Done          ");
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            SqlConnection con = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE B_ID = '" + textBox1.Text + "'", con);

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            //  If the record can be queried, it means passing verification, then open another form.  

            if ((sdr.Read() == true))
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
                {
                    SqlConnection conn = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = conn;
                    conn.Open();
                    comm.CommandText = "update BOOK set TITLE='" + textBox6.Text + "',CATEGORY = '" + textBox5.Text + "',AMOUNT='" + textBox4.Text + "',AVAIL='" + textBox4.Text + "',PRICE='" + textBox3.Text + "',AUTHOR_NAME='" + textBox2.Text + "',PUB_YEAR = '" + textBox7.Text + "'  where B_ID = '" + textBox1.Text + "'";
                    comm.ExecuteNonQuery();
                    conn.Close();

                    textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                    textBox4.Text = ""; textBox5.Text = "";
                    textBox6.Text = ""; textBox7.Text = "";
                    MessageBox.Show("            Update is Done          ");
                }
            }
            else
            {
                MessageBox.Show("    the enterd ID not Exists");
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                textBox4.Text = ""; textBox5.Text = "";
                textBox6.Text = ""; textBox7.Text = "";
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE B_ID = '" + textBox1.Text + "'", con);

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                //  If the record can be queried, it means passing verification, then open another form.  

                if ((sdr.Read() == true))
                {

                    SqlConnection conn = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = conn;
                    conn.Open();
                    comm.CommandText = "delete from BOOK  where B_ID = '" + textBox1.Text + "'";
                    comm.ExecuteNonQuery();
                    conn.Close();
                    textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                    textBox4.Text = ""; textBox5.Text = "";
                    textBox6.Text = ""; textBox7.Text = "";
                    MessageBox.Show("            Deletion is Done          ");
                }
            }
            else
            {
                MessageBox.Show("            Enter B_ID Please for Deletion..          ");

            }
        }





        private void button4_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 obj = new Form6();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool ex = true;
            string yourConnectionString = "Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True";
            string select = "SELECT * FROM BOOK WHERE ";

            if (textBox1.Text != "")
            {
                select += "B_ID = '" + textBox1.Text + "' ";
                if (textBox6.Text != "") { select += " and TITLE like '%" + textBox6.Text + "%'"; }
                if (textBox2.Text != "") { select += " and AUTHOR_NAME like '%" + textBox2.Text + "%' "; }
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
                if (textBox5.Text != "") { select += " and CATEGORY like '%" + textBox5.Text + "%'"; }
                if (textBox7.Text != "") { select += " and PUB_YEAR = '" + textBox7.Text + "'"; }

            }
            else if (textBox6.Text != "")
            {
                select += "  TITLE like '%" + textBox6.Text + "%' ";
                if (textBox2.Text != "") { select += " and AUTHOR_NAME like '%" + textBox2.Text + "%' "; }
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
                if (textBox5.Text != "") { select += " and CATEGORY like '%" + textBox5.Text + "%'  "; }
                if (textBox7.Text != "") { select += " and PUB_YEAR = '" + textBox7.Text + "'"; }
            }

            else if (textBox2.Text != "")
            {
                select += " AUTHOR_NAME like '%" + textBox2.Text + "%'  ";
                if (textBox5.Text != "") { select += " and CATEGORY like '%" + textBox5.Text + "%'  "; }
                if (textBox7.Text != "") { select += " and PUB_YEAR = '" + textBox7.Text + "'"; }
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
            }
            else if (textBox5.Text != "")
            {
                select += " CATEGORY like '%" + textBox5.Text + "%'  ";
                if (textBox7.Text != "") { select += " and PUB_YEAR = '" + textBox7.Text + "'"; }
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
            }
            else if (textBox7.Text != "")
            {
                select += " PUB_YEAR = '" + textBox7.Text + "'";
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
            }
            else if(textBox4.Text != "")
            {
                select += " AMOUNT = '" + textBox4.Text + "'";
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
            }
            else if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
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

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(AdminID,1);
            form.Show();
            
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool ex = true;
            string yourConnectionString = "Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True";
            string select = "SELECT count(B_ID) as [Number of Books] FROM BOOK WHERE ";

            if (textBox1.Text != "")
            {
                select += "B_ID = '" + textBox1.Text + "' ";
                if (textBox6.Text != "") { select += " and TITLE like '%" + textBox6.Text + "%'"; }
                if (textBox2.Text != "") { select += " and AUTHOR_NAME like '%" + textBox2.Text + "%' "; }
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
                if (textBox5.Text != "") { select += " and CATEGORY like '%" + textBox5.Text + "%'"; }
                if (textBox7.Text != "") { select += " and PUB_YEAR = '" + textBox7.Text + "'"; }

            }
            else if (textBox6.Text != "")
            {
                select += "  TITLE like '%" + textBox6.Text + "%' ";
                if (textBox2.Text != "") { select += " and AUTHOR_NAME like '%" + textBox2.Text + "%' "; }
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
                if (textBox5.Text != "") { select += " and CATEGORY like '%" + textBox5.Text + "%'  "; }
                if (textBox7.Text != "") { select += " and PUB_YEAR = '" + textBox7.Text + "'"; }
            }

            else if (textBox2.Text != "")
            {
                select += " AUTHOR_NAME like '%" + textBox2.Text + "%'  ";
                if (textBox5.Text != "") { select += " and CATEGORY like '%" + textBox5.Text + "%'  "; }
                if (textBox7.Text != "") { select += " and PUB_YEAR = '" + textBox7.Text + "'"; }
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
            }
            else if (textBox5.Text != "")
            {
                select += " CATEGORY like '%" + textBox5.Text + "%'  ";
                if (textBox7.Text != "") { select += " and PUB_YEAR = '" + textBox7.Text + "'"; }
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
            }
            else if (textBox7.Text != "")
            {
                select += " PUB_YEAR = '" + textBox7.Text + "'";
                if (textBox4.Text != "") { select += " and AMOUNT like '%" + textBox4.Text + "%' "; }
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
            }
            else if (textBox4.Text != "")
            {
                select += " AMOUNT = '" + textBox4.Text + "'";
                if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
            }
            else if (textBox3.Text != "") { select += " and PRICE like '%" + textBox3.Text + "%' "; }
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

        private void button8_Click(object sender, EventArgs e)
        {
            bool ex = true;
            string yourConnectionString = "Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True";
            string select = "select b.b_id , s.S_id ,s.name , s.DOB ,s.ADDRESS ,s.FACULTY ,s.LEVEL from STUDENT s , BOOK b, LOAN where LOAN.S_ID = s.S_ID and b.B_ID = LOAN.B_ID ";

            
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
    }

    }
