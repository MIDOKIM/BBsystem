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
using System.Text.RegularExpressions;

namespace BBsystem
{
    public partial class ContactUs : Form
    {
        SqlCommand cmd;
        public ContactUs()
        {
            InitializeComponent();
            textBox1.Show();
            textBox2.Show();
            pictureBox4.Show();
            pictureBox2.Hide();
            label3.Hide();
            label4.Hide();
        }
        public ContactUs(User donor)
        {

            InitializeComponent();
            textBox1.Hide();
            textBox2.Hide();
            pictureBox2.Show();
            pictureBox4.Hide();
            label3.Text = donor.fName + " " + donor.lName;
            label4.Text = donor.email;
            textBox1.Text = label3.Text;
            textBox2.Text = label4.Text;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

            var form1 = (Start)Tag;
            form1.Show();
            Close();
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void ContactUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.connection.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {

                cmd = new SqlCommand("insert into [ContactMSG](fName,email,[message],subject,recivedate)  values('" + textBox1.Text + "','" + textBox2.Text + "','" + richTextBox1.Text + "','" + textBox3.Text + "',getdate())", Start.connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Message sent successfully");
            }
            else
                MessageBox.Show("Please Enter valid Information");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form1 = (home)Tag;
            form1.Show();
            Close();
        }

        private void ContactUs_Load(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
        }
        private bool CheckValid()
        {
            Regex email = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (email.IsMatch(textBox2.Text) == false)
            {
                return false;
            }
            if (textBox3.Text=="Subject")
            {
                return false;
            }
            if (richTextBox1.Text == "Your Message")
            {
                return false;
            }
            return true;
        }
    }
}
