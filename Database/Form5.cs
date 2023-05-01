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
    public partial class Form5 : Form
    {
        public static int  BookID;
       
        public Form5(int ID)
        {
            InitializeComponent();
            Form5.BookID = ID;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                
                SqlConnection con = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("SELECT * FROM ADMIN WHERE A_ID = '" + textBox1.Text + "' AND PASSWORD = '" + textBox2.Text + "' ", con);

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                //  If the record can be queried, it means passing verification, then open another form.  
                
                if ((sdr.Read() == true))

                {
                    con.Close();
                    sdr.Close();
                    con.Open();
                    
                       // cmd = new SqlCommand("insert into LOAN (S_ID,A_ID,B_ID,START_LOAN,Return_DATE) values (+Form5.StudentID+)", con);
                    cmd.CommandText = "INSERT INTO LOAN VALUES ('" + Form7.StudentID + "','" + Form5.BookID +
                    "','" + DateTime.Now + "','" + DateTime.Now.AddDays(14) +   "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();

                   

                    SqlCommand c = new SqlCommand ("UPDATE BOOK SET avail = avail - 1 WHERE B_ID = '" +Form5.BookID+"'  and avail > 0",con);
                    c.ExecuteNonQuery();
                    


                    con.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("  ID and PASSWORD aren't matched ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 22;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
