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

    public partial class Form5 : Form
    {
        SqlConnection Sqlonnection = new SqlConnection("Data Source=DESKTOP-VR3N1RM;Initial Catalog=lostfound;Integrated Security=True");

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                string query = "insert into personn values('" + textBox1.Text + "' , '" + textBox6.Text + "' , '" + textBox2.Text + "' ,   '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox7.Text + "')";
                Sqlonnection.Open();

                SqlCommand sqlcommand = new SqlCommand(query, Sqlonnection);

                Sqlonnection.Open();

                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("Inserted Succefully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Sqlonnection.Close();
                this.Hide();

                form1 f1 = new form1();
                f1.Show();
            }
            catch
            {
                MessageBox.Show("incorrect information");

            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            form4 f4 = new form4();
            f4.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lostfoundDataSet8.govn' table. You can move, or remove it, as needed.
            this.govnTableAdapter.Fill(this.lostfoundDataSet8.govn);
            // TODO: This line of code loads data into the 'lostfoundDataSet6.personn' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'lostfoundDataSet4.govn' table. You can move, or remove it, as needed.

        }
    }
}
