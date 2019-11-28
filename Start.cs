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


namespace BBsystem
{
    public partial class Start : Form
    {

        public static SqlConnection connection;
        public Start()
        {
          InitializeComponent();
            connection = new SqlConnection(@"Data Source=MIDOKIM-PC\MKK;Initial Catalog=BloodBankDB;Integrated Security=True"); 

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp form6 = new SignUp();
            form6.Tag = this;
            form6.Show(this);
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Start_Load(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
            pictureBox1.Image = global::BBsystem.Properties.Resources.conusbutton;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ContactUs form2 = new ContactUs();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            About form3 = new About();
            form3.Tag = this;
            form3.Show(this);
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LogIn form7 = new LogIn();
            form7.Tag = this;
            form7.Show(this);
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SignUp form6 = new SignUp();
            form6.Tag = this;
            form6.Show(this);
            Hide();
        }
    }
}
