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
    public partial class Form3 : Form
    {
        SqlConnection Sqlonnection = new SqlConnection("Data Source=DESKTOP-VR3N1RM;Initial Catalog=lostfound;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lostfoundDataSet9.govn' table. You can move, or remove it, as needed.
            this.govnTableAdapter.Fill(this.lostfoundDataSet9.govn);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Sqlonnection.Open();


                SqlCommand cd = new SqlCommand("select namegov,deliveredplace from govn where namegov='" + comboBox1.Text + "' ", Sqlonnection);
                SqlDataReader dr = cd.ExecuteReader();


                if (dr.Read())
                {
                    textBox1.Text = dr[1].ToString();
                    Sqlonnection.Close();

                }

            }
            catch
            {
                MessageBox.Show(" there is an error ");
                Sqlonnection.Close();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Sqlonnection.Open();


                SqlCommand cd = new SqlCommand("select namegov,deliveredplace from govn where namegov='" + comboBox1.Text + "' ", Sqlonnection);
                SqlDataReader dr = cd.ExecuteReader();


                if (dr.Read())
                {
                    textBox1.Text = dr[1].ToString();
                    Sqlonnection.Close();

                }

            }
            catch
            {
                MessageBox.Show(" there is an error ");
                Sqlonnection.Close();
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form1 f = new form1();
            this.Hide();
            f.Show();
        }
    }
}
