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

namespace WindowsFormsApplication3
{
    public partial class form4 : Form
    {
        SqlConnection Sqlonnection = new SqlConnection("Data Source=DESKTOP-VR3N1RM;Initial Catalog=lostfound;Integrated Security=True");

        public form4()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Sqlonnection.Open();


                SqlCommand cd = new SqlCommand("select * from personn where id ='" + textBox1.Text + "' and password ='" + textBox2.Text + "' ", Sqlonnection);
                SqlDataReader dr = cd.ExecuteReader();


                if (dr.Read())
                {

                    this.Hide();
                    form1 f = new form1();
                    f.Show();
                }
                else
                {
                    MessageBox.Show(" id or password is invaild ");
                    Sqlonnection.Close();

                }
            }
            catch 
            {
                MessageBox.Show(" there is an error ");
                Sqlonnection.Close();


            }
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();

        }

        private void form4_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form1 f = new form1();
            this.Hide();
            f.Show();
        }
    }
}
