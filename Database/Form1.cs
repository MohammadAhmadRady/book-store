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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && textBox1.Text!="" && textBox2.Text != "")
            {
                
                    SqlConnection con = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");

                    SqlCommand cmd = new SqlCommand("SELECT * FROM ADMIN WHERE A_ID = '"+textBox1.Text+"' AND PASSWORD = '"+textBox2.Text+"' ", con);

                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    //  If the record can be queried, it means passing verification, then open another form.  

                    if ((sdr.Read() == true))

                    {
                        AdminPanel AdminPanelObj = new AdminPanel(Convert.ToInt32(textBox1.Text));
                        AdminPanelObj.Show();
                        this.Hide();
                    }
                    else
                    {
                          MessageBox.Show("  ID and PASSWORD aren't matched ");
                          textBox1.Text = "";
                          textBox2.Text = "";
                    }
                                                   
            }
            else if (radioButton2.Checked && textBox1.Text != "" && textBox2.Text != "")
            {
                //string connectionString = "Data Source=DESKTOP-02AJKRB\\SQLEXPRESS;Initial Catalog=UniLibrary;Integrated Security=True";

                SqlConnection con = new SqlConnection("Data Source=SaVioLA;Initial Catalog=unilib;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT WHERE S_ID = '"+textBox1.Text+"' AND PASSWORD = '" + textBox2.Text + "' ", con);

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                //  If the record can be queried, it means passing verification, then open another form.  

                if ((sdr.Read() == true))

                {
                    Form7 Form7Obj = new Form7(Convert.ToInt32(textBox1.Text));
                    Form7Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("  ID and PASSWORD aren't matched ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else if ((!radioButton1.Checked && !radioButton2.Checked) || textBox1.Text=="" || textBox2.Text == "")
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.that;
                popup.TitleText = "Warning";
                popup.ContentText = "You should Enter ID && PASSWORD and Select the Person ";
                popup.Popup();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form2 Form2Obj = new Form2(0,0);
                Form2Obj.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                Form3 Form3Obj = new Form3();
                Form3Obj.Show();
                this.Hide();
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.that;
                popup.TitleText = "Warning";
                popup.ContentText = "You should Select a Person ";
                popup.Popup();
            }
           
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //// hena fe ta3del 3ashan el password yeban ***
            // Set to no text.
            ///textBox1.Text = "";
            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
            // The control will allow no more than 22 characters.
            textBox2.MaxLength = 22;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}

