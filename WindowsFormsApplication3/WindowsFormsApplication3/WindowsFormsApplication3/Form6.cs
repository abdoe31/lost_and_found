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
    public partial class Form6 : Form
    {
        SqlConnection Sqlonnection = new SqlConnection("Data Source=DESKTOP-VR3N1RM;Initial Catalog=lostfound;Integrated Security=True");


        public Form6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            form1 f1 = new form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Sqlonnection.Open();


                SqlCommand cd = new SqlCommand("select id_lost,code,price,day,month,year,foundplace,gov_found,gov_dellivered,kind from found where id_lost='" + textBox2.Text + "' ", Sqlonnection);
                SqlDataReader dr = cd.ExecuteReader();


                if (dr.Read())
                {
                    textBox1.Text = dr[1].ToString();
                    textBox4.Text = dr[2].ToString();
                    textBox5.Text = dr[3].ToString();
                    textBox6.Text = dr[4].ToString();
                    textBox7.Text = dr[5].ToString();
                    textBox10.Text = dr[6].ToString();
                    textBox8.Text = dr[7].ToString();

                    textBox9.Text = dr[8].ToString();
                    textBox11.Text = dr[9].ToString();







                    Sqlonnection.Close();
                }
                else
                {
                    MessageBox.Show("sorry ,we dont found your lost yet");
                }
            }
            catch
            {
                MessageBox.Show("sorry ,we dont found your lost yet");

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
