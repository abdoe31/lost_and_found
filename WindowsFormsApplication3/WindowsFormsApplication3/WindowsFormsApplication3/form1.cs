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
    public partial class form1 : Form
    {
        SqlConnection Sqlonnection = new SqlConnection("Data Source=DESKTOP-VR3N1RM;Initial Catalog=lostfound;Integrated Security=True");

        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form6 f6 = new Form6();
            f6.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 f3 = new Form3();
            f3.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form4 f = new form4();
            this.Hide();
            f.Show();

        }
    }
}
